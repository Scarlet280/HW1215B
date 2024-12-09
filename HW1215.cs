using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 呼叫第一部分
        MyHomeWork01();

        // 呼叫第二部分
        MyHomeWork02();
    }

    static void MyHomeWork01()
    {
        // 第1題：宣告陣列
        int[] intArray = new int[10];
        float[] floatArray = new float[8];
        double[] doubleArray = new double[4];
        string[] stringArray = new string[5];

        // 第2題：走訪陣列，輸入資料並計算平均值
        Console.WriteLine("請依序輸入整數陣列的值:");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write($"輸入第 {i + 1} 個整數: ");
            intArray[i] = int.Parse(Console.ReadLine());
        }
        PrintArrayAndAverage(intArray);

        Console.WriteLine("請依序輸入浮點數陣列的值:");
        for (int i = 0; i < floatArray.Length; i++)
        {
            Console.Write($"輸入第 {i + 1} 個浮點數: ");
            floatArray[i] = float.Parse(Console.ReadLine());
        }
        PrintArrayAndAverage(floatArray);

        Console.WriteLine("請依序輸入倍精確度數陣列的值:");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.Write($"輸入第 {i + 1} 個倍精確度數: ");
            doubleArray[i] = double.Parse(Console.ReadLine());
        }
        PrintArrayAndAverage(doubleArray);

        Console.WriteLine("請依序輸入字串陣列的值:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write($"輸入第 {i + 1} 個字串: ");
            stringArray[i] = Console.ReadLine();
        }
        PrintArray(stringArray);
    }

    static void MyHomeWork02()
    {
        // 第3題：宣告陣列並初始化
        int[] intArray = { 1, 2, 3, 4, 5 };
        float[] floatArray = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
        double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 };
        string[] stringArray = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

        // 第4題：走訪陣列並印出
        PrintArrayAndAverage(intArray);
        PrintArrayAndAverage(floatArray);
        PrintArrayAndAverage(doubleArray);
        PrintArray(stringArray);
    }

    static void PrintArrayAndAverage<T>(T[] array) where T : struct
    {
        Console.WriteLine("陣列內容:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // 計算平均值 (僅限數值類型)
        if (array is int[] intArr)
        {
            Console.WriteLine($"平均值: {intArr.Average()}");
        }
        else if (array is float[] floatArr)
        {
            Console.WriteLine($"平均值: {floatArr.Average()}");
        }
        else if (array is double[] doubleArr)
        {
            Console.WriteLine($"平均值: {doubleArr.Average()}");
        }
        Console.WriteLine();
    }

    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine("陣列內容:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
