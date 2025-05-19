/*請建立2個過載的類別方法Cube()，可以分別計算int 和 double 參數的平方，然後建立2個過載MinElement()類別方法，傳入3個或4個int參數，其傳回值是參數中最小值*/
public class MathHelper
{
    public static int Cube(int x)
    {
        return x * x;
    }

    public static double Cube(double x)
    {
        return x * x;
    }

    public static int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    public static int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Cube(4): " + MathHelper.Cube(4));           // 輸出：16
        Console.WriteLine("Cube(3.2): " + MathHelper.Cube(3.2));       // 輸出：約 10.24

        Console.WriteLine("Min of 3, 8, 2: " + MathHelper.MinElement(3, 8, 2));       // 輸出：2
        Console.WriteLine("Min of 7, 4, 9, 1: " + MathHelper.MinElement(7, 4, 9, 1)); // 輸出：1
    }
}