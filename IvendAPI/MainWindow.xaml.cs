
using IvendAPI.ServiceIvendAPI;
using System;
using System.Windows;

namespace IvendAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IntegrationServiceClient client;

        public MainWindow()
        {
            InitializeComponent();
            client = new IntegrationServiceClient();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CustomerGroup customerGroup = new CustomerGroup();
                customerGroup.Id = txtId.Text;
                customerGroup.Description = txtName.Text;

                var result = client.SaveCustomerGroup(customerGroup);
                if(result.Message.Trim() != "Success")
                {
                    //throw error
                }

                MessageBox.Show(result.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
