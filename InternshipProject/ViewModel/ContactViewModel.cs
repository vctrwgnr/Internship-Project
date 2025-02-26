using InternshipProject.Model;

namespace InternshipProject.ViewModel;

public class ContactViewModel
{
    public List <Contact> Contacts { get; set; }

    public ContactViewModel()
    {
        Contacts = new List<Contact>
        {
            new Contact(1, "Victoria", "Emich", "abc@uk.de", "123456789"),
            new Contact(2, "John", "Smith", "bbq@uk.de", "987654321"),
        };
    }
    
    

}