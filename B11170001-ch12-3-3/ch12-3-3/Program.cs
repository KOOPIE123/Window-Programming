/*請建立單位轉換的C#程式，一英尺有12英吋;一英碼等於3英尺，FeetToInches()方法可以將英尺轉換成英吋;YardsToInches()方法將英碼轉換成英，程式在輸入英吋後，使用委派來動態執行轉換方法*/
public class UnitConverter
{
    // 委派定義
    public delegate double ConvertDelegate(double value);

    // 英尺轉英吋
    public static double FeetToInches(double feet)
    {
        return feet * 12;
    }

    // 英碼轉英吋
    public static double YardsToInches(double yards)
    {
        return yards * 3 * 12;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("請輸入要轉換的數值：");
        double input = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("請輸入單位 (feet 或 yards)：");
        string unit = Console.ReadLine().ToLower();

        ConvertDelegate converter;

        if (unit == "feet")
        {
            converter = FeetToInches;
        }
        else if (unit == "yards")
        {
            converter = YardsToInches;
        }
        else
        {
            Console.WriteLine("不支援的單位！");
            return;
        }

        double result = converter(input);
        Console.WriteLine($"轉換結果為：{result} 英吋");
    }
}