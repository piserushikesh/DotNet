﻿ using System.Reflection;
 string path=@"D:\dotnet_workspace\Practice\DotNet\Day5\Catlog\bin\Debug\net7.0\Catlog.dll";
Assembly asm=Assembly.LoadFile(path);

string name=asm.FullName;
Console.WriteLine(name);

Type [] types=asm.GetTypes();

for(int i=0;i<types.Count();i++)
{
    string typeName=types[i].Name;
    Console.WriteLine(typeName);
    MethodInfo [] mi=types[i].GetMethods();
    foreach ( MethodInfo m in mi)
    {
        string methodName=m.Name;
        Console.WriteLine(methodName);
    }
}
