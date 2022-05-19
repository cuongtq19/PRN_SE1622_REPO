namespace Prn.Se1622;
public class Student
{
    /*Fields/Data*/

    private int _id;
    private string _name;
    private DateTime _dob;
    private string _address;

    /*Properties*/
    //Init-auto Properties
    public int Id { get; init; }
    public string Name { get => _name; set => _name = value; }
    //Read-only Auto Prpperties
    public DateTime Dob { get; }
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    public double Mark { get; set; }
    
    //Construtor => ham khoi tao
    public Student()
    {

    }

    public Student(int id, string name, DateTime dob, string address, double mark)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Address = address;
        Mark = mark;
    }

    //To increase Mark by a percentage rate
    public void IncreaseMarkByPercent(int? percent)
    {
        if (percent is not null && percent > 0 && percent <= 100)
        {
            this.Mark = this.Mark * percent.Value / 100;
        }
    }

    //Expression Bodied
    public override string? ToString() => $"Id = {Id}, Name = {Name}, Date of Birth = {Dob}, Address = {Address}, Mark = {Mark}";   
}