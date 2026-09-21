using System.Windows;
namespace StoryProduct;
public partial class MainWindow : Window
{

 public MainWindow(){InitializeComponent();}
    private void Build_Click(object sender, RoutedEventArgs e)
    {
        ResultText.Text = "Your first interaction works.";
    }
}