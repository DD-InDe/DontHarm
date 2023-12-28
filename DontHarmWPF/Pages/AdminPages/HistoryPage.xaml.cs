using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using DontHarmWPF.Api;
using DontHarmWPF.Models;

namespace DontHarmWPF.Pages.AdminPages;

public partial class HistoryPage : Page
{
    private EmployeeAPI _employeeApi;
    private HistoryAPI _historyApi;
    
    public HistoryPage()
    {
        _employeeApi = new EmployeeAPI();
        _historyApi = new HistoryAPI();
        InitializeComponent();
        
        Load();

        SortComboBox.SelectedIndex = 0;
        FilterComboBox.SelectedIndex = 0;
    }

    private async void Load()
    {
        List<string> sort = new List<string> { "не выбрано", "сначала новые", "сначала старые" };
        List<Employee> employees = new List<Employee>();
        Employee employee = new Employee() { Login = "не выбран" };
        employees.Add(employee);
        employees.AddRange(await _employeeApi.GetEmployee());

        SortComboBox.ItemsSource = sort;
        FilterComboBox.ItemsSource = employees;
    }

    private async void UpdateData()
    {
        List<LoginHistory> loginHistories = await _historyApi.GetHistory();

        if (FilterComboBox.SelectedIndex != 0)
            loginHistories = loginHistories.Where(c => c.Employee.Login == ((Employee)FilterComboBox.SelectedItem).Login).ToList();
        if (SortComboBox.SelectedIndex == 1)
            loginHistories = loginHistories.OrderBy(c => c.LogDate).ToList();
        if (SortComboBox.SelectedIndex == 2)
            loginHistories = loginHistories.OrderByDescending(c => c.LogDate).ToList();

        HistoryDataGrid.ItemsSource = loginHistories;
    }

    private void SortComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateData();

    private void FilterComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateData();
}