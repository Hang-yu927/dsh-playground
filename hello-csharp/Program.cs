using System;
using System.Linq;

namespace HelloCSharp;

internal static class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var line = new string('=', 46);

        Console.WriteLine(line);
        Console.WriteLine("  C# 最小示例项目 · hello-csharp");
        Console.WriteLine(line);
        Console.WriteLine($"  .NET 版本 : {Environment.Version}");
        Console.WriteLine($"  操作系统  : {Environment.OSVersion}");
        Console.WriteLine($"  机器名    : {Environment.MachineName}");
        Console.WriteLine($"  当前时间  : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine();

        Console.WriteLine("① 斐波那契前 10 项:");
        var fibonacci = Enumerable.Range(0, 10).Select(Fib);
        Console.WriteLine("   " + string.Join(", ", fibonacci));
        Console.WriteLine();

        Console.WriteLine("② LINQ 示例 — 统计句子里的单词:");
        const string sentence = "the quick brown fox jumps over the lazy dog the end";
        var stats = sentence
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(w => w)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key)
            .Take(5);
        foreach (var g in stats)
        {
            Console.WriteLine($"   {g.Key,-8} x{g.Count()}");
        }
        Console.WriteLine();

        Console.WriteLine("③ 恭喜，编译并运行成功！可以开始改代码了。");
        Console.WriteLine(line);
    }

    private static int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);
}
