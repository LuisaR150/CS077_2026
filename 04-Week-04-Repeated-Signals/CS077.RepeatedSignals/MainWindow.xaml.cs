using System;
using System.Windows;

namespace CS077.RepeatedSignals;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ScanButton_Click(object sender, RoutedEventArgs e)
    {
        string[] packets = PacketInput.Text.Split(';',
            StringSplitOptions.RemoveEmptyEntries |
            StringSplitOptions.TrimEntries);
        SignalOutput.Text = ProcessPackets(packets);
    }
    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        PacketInput.Text = "PING;PING;DISTRESS;STOP;PING";
        SignalOutput.Text = "Ready.";
    }

    public static string ProcessPackets(string[] packets)
    {
        int processed = 0;
        string log = "";
        for (int i = 0; i < packets.Length && processed < 6; i++)
        {
            if (packets[i] == "STOP")
            {
                log += "STOP received.\n";
                break;
            }
            log += $"{processed + 1}. {packets[i]}\n";
            processed++;
        }
        if (processed == 6)
        {
            log += "Safety limit reached.\n";
        }
        return log + $"Processed: {processed}";
    }
}