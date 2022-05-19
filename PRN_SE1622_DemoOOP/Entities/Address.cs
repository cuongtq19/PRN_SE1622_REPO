namespace Prn.Se1622;

public class Address
{
    public int Number { get; set; }
    public string Ward { get; set; }
    public string Street { get; set; }
    public string City { get; set; }

    public Address()
    {

    }

    public Address(int number, string ward, string street, string city)
    {
        Number = number;
        Ward = ward;
        Street = street;
        City = city;
    }

    public override string? ToString()
    {
        return $"[.No = {Number}, Ward = {Ward}, Street = {Street}, City = {City}";
    }
}