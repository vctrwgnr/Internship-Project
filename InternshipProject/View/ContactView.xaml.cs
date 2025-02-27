using System.Windows;
using System.Windows.Controls;
using InternshipProject.ViewModel;

namespace InternshipProject.View
{
    public partial class ContactView : UserControl
    {
        private ContactViewModel viewModel;

        public ContactView()
        {
            InitializeComponent();
            viewModel = new ContactViewModel();
            DataContext = viewModel;
        }

        private void AddContactButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AddContact();
        }
    }
}