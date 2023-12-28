using System.Windows;
using System.Windows.Controls;

namespace DontHarmWPF.Pages.AdminPages;

public partial class MainMenuPage : Page
{
    public MainMenuPage()
    {
        InitializeComponent();
    }

    private void HistoryButton_OnClick(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new HistoryPage());
    }
}