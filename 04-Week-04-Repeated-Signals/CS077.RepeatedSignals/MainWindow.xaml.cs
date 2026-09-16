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

    public static string ProcessPackets(string[] packets)
    {
        int processed = 0;
        string log = "";
        for (int i = 0; i < packets.Length; i++)
        {
            log += $"{i + 1}. {packets[i]}\n";
            processed++;
        }
        return log + $"Processed: {processed}";
    }
}