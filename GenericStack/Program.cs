using System;

var intStack = new MyStack<int>(5);
intStack.push(10);
intStack.push(20);
intStack.push(30);

Console.WriteLine("=== 정수 스택 테스트 ===");
Console.WriteLine($"Count: {intStack._count}");
Console.WriteLine($"Peek: {intStack.Peek()}");
Console.WriteLine($"Pop: {intStack.pop()}");
Console.WriteLine($"Pop: {intStack.pop()}");
Console.WriteLine($"Count: {intStack._count}");

// 문자열 스택 테스트
var stringStack = new MyStack<string>(5);
stringStack.push("첫번째");
stringStack.push("두번째");
stringStack.push("세번째");

Console.WriteLine("\n=== 문자열 스택 테스트 ===");
Console.WriteLine($"Count: {stringStack._count}");
Console.WriteLine($"Peek: {stringStack.Peek()}");
Console.WriteLine($"Pop: {stringStack.pop()}");
Console.WriteLine($"IsEmpty: {stringStack.IsEmpty()}");