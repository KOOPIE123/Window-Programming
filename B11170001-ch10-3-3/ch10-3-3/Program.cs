/*請依照第10-3-1 節的類別圖寫出C#程式的IPrice介面和Car類別，以便顯示車輛的價格*/
interface IPrice
{
    double GetPrice();
}
public class  Car : IPrice
{
    public double Price { get; set; }
    public string Name { get; set; }
    public Car(double price,string name)
    {
        Price = price;
        Name = name;
    }
    public double GetPrice()
    {
        return Price;
    }
    public string GetName()
    {
        return Name;
    }
}
public class Program {
    public static void Main(String[] args)
    {
        IPrice Car1 = new Car(1000, "BMW");
        Console.WriteLine("Car Name: " + ((Car)Car1).GetName());
        Console.WriteLine("Car Price: " + Car1.GetPrice());
        Console.WriteLine("------------------------------------");
        IPrice Car2 = new Car(500, "TOYOTA");
        Console.WriteLine("Car Name: " + ((Car)Car2).GetName());
        Console.WriteLine("Car Price: " + Car2.GetPrice());
    }
}
