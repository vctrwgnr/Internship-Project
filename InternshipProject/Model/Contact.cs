namespace InternshipProject.Model;

public class Contact(int id, string fname, string lname, string email, string phone)
{
 
    public int Id { get; set; } = id;
    public string Fname { get; set; } = fname;
    public string Lname { get; set; } = lname;
    public string Email { get; set; } = email;
    public string Phone { get; set; } = phone;

    public override string ToString()
    {
        return Fname + " " + Lname;
    }
}