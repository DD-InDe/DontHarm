using System;
using System.Windows;
using System.Windows.Controls;
using DontHarmWPF.Api;
using DontHarmWPF.Models;

namespace DontHarmWPF.Pages;

public partial class AuthPage : Page
{
    private readonly AuthAPI _authApi;

    public AuthPage()
    {
        _authApi = new AuthAPI();

        InitializeComponent();
    }

    private async void LoginButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(LoginTextBox.Text) && !String.IsNullOrWhiteSpace(PassTextBox.Text))
        {
            Employee employee = await _authApi.Auth(LoginTextBox.Text, PassTextBox.Text);
            if (employee != null)
            {
                switch (employee.Role.Id)
                {
                    case 1:
                        NavigationService.Navigate(new AccountantPages.MainMenuPage());
                        break;
                    case 2:
                        NavigationService.Navigate(new LaborantPages.MainMenuPage());
                        break;
                    case 3:
                        NavigationService.Navigate(new IsLaborantPages.MainMenuPage());
                        break;
                    case 4:
                        NavigationService.Navigate(new AdminPages.MainMenuPage());
                        break;
                }
            }
            else
                MessageBox.Show("Пользователь не найден");
        }
        else
            MessageBox.Show("Поля не могут быть пустыми");
    }
}