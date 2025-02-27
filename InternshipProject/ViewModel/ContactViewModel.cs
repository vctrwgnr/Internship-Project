using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using InternshipProject.Model;

namespace InternshipProject.ViewModel;

class ContactViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Contact> Contacts { get; set; }

    private string _newFirstName;
    private string _newLastName;
    private string _newEmail;
    private string _newPhone;

    public string NewFirstName
    {
        get => _newFirstName;
        set { _newFirstName = value; OnPropertyChanged(); }
    }

    public string NewLastName
    {
        get => _newLastName;
        set { _newLastName = value; OnPropertyChanged(); }
    }

    public string NewEmail
    {
        get => _newEmail;
        set { _newEmail = value; OnPropertyChanged(); }
    }

    public string NewPhone
    {
        get => _newPhone;
        set { _newPhone = value; OnPropertyChanged(); }
    }

    public ContactViewModel()
    {
        Contacts = new ObservableCollection<Contact>
        {
            new Contact { FirstName = "Victoria", LastName = "Emich", Email = "abc@uk.de", Phone = "123456789" },
            new Contact { FirstName = "John", LastName = "Smith", Email = "bbq@uk.de", Phone = "123456789" },
        };
    }

    public void AddContact()
    {
        Contacts.Add(new Contact
        {
            FirstName = NewFirstName,
            LastName = NewLastName,
            Email = NewEmail,
            Phone = NewPhone
        });

     
        NewFirstName = "";
        NewLastName = "";
        NewEmail = "";
        NewPhone = "";
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}