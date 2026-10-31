# hello-csharp

最小可运行的 C# 控制台示例（.NET 9）。

## 运行

```powershell
cd hello-csharp
dotnet run
```

## 发布成 exe

```powershell
dotnet publish -c Release -r win-x64 --self-contained false
# 输出: bin\Release\net9.0\win-x64\publish\
```

## 内容

- 打印运行环境信息
- 斐波那契数列（递归 + LINQ 生成）
- 单词频次统计（LINQ GroupBy / OrderByDescending）
