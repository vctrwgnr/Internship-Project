using System.Windows.Controls;
using InternshipProject.Model;
using InternshipProject.ViewModel;

namespace InternshipProject.View;

public partial class ContactView : UserControl
{
    public ContactView()
    {
        InitializeComponent();
        
        ContactViewModel viewModel = new ContactViewModel();
        var contacts = viewModel.Contacts;
        Console.WriteLine(contacts.Count);
        // DataContext = contacts.Count;
        
       
    }
}