using System.Numerics;

public class Cards
{
    public string Name;
    public string Occupation;
    public int Age;
    public PhoneList Phone;
    public string Email;

    public Cards(string name, string occupation, int age, PhoneList phone, string email)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Phone = phone;
        Email = email;
    }

    public string GetCard()
    {
        return $"Name: {Name}\n" +
               $"Occupation: {Occupation}\n" +
               $"Age: {Age}\n" +
               $"Home Phone: {Phone.HomePhone}\n" + 
               $"Business Phone: {Phone.BusinessPhone}\n" +
               $"Cell Phone: {Phone.CellPhone}\n" +
               $"Email: {Email}";
    }
}
public class PhoneList
{
    public string HomePhone;
    public string BusinessPhone;
    public string CellPhone;

    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }
}
public class program 
{
    public static void Main()
    {
        PhoneList phoneList = new PhoneList("03-43682975","02-58347859","0958-478395");
        Cards cd = new Cards("monkey","網頁工程師",35, phoneList, "monkey930624@gmail.com");
        Console.WriteLine(cd.GetCard());
        Console.ReadKey();
    }
}
