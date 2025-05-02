/* 實作題
 * 請使用C# 語言寫出 Box 類別的宣告來建立盒子物件，在類別提供計算盒子的體積與面積，如下:
    A.成員變數: Width、Height和 Length 貯存寬、高和長。
    B.	建構子:Box(double width, double height, double length)。
    C.成員方法:double Volume() 計算體積和double Area() 計算面積。
*/
public class Box
{
    private double Width;
    private double Height;
    private double Length;
    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 計算表面積
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
    public void show()
    {
        Console.WriteLine("體積=" + Volume());
        Console.WriteLine("表面積=" + Area());
    }
}
public class program
{
    public static void Main()
    {
        Console.WriteLine("第一組數字 整數測試");
        Box B1 = new Box(10, 20, 30);
        B1.show();
        Console.WriteLine("…………………………");
        Console.WriteLine("第二組數字 浮點數測試");
        B1 = new Box(45.5, 85.5, 34.0);
        B1.show();
        Console.ReadLine();
    }
}
