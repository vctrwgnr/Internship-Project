using System.ComponentModel;
namespace InternshipProject.Model;

public class Contact : INotifyPropertyChanged
{
    private string fname;
    private string lname;
    private string email;
    private string phone;

    public string FirstName
    {
        get
        {
            return fname;
        }
        set
        {
            fname = value;
            OnPropertyChanged("FirstName");
        }
    }
    public string LastName
    {
        get
        {
            return lname;
        }
        set
        {
            lname = value;
            OnPropertyChanged("LastName");
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
            OnPropertyChanged("Email");
        }
    }
    public string Phone
    {
        get
        {
            return phone;
        }
        set
        {
            phone = value;
            OnPropertyChanged("Phone");
        }
    }
    
    
    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion

}