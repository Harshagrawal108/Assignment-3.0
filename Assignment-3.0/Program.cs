using System.Diagnostics;
using System.Runtime.Remoting.Lifetime;
using System;

Que1Ass3:
Ans: -
using System;

public class MyClass
{
    private int myField;

    public void SetMyField(int value)
    {
        myField = value;
    }

    public int GetMyField()
    {
        return myField;
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        myObject.SetMyField(560);

        int value = myObject.GetMyField();
        Console.WriteLine($"The value of myField is: {value}");
    }
}

Que2Ass4:
Ans: -
using System;

public class MyClass
{
    private int myField;

    public void SetMyField(int value)
    {
        myField = value;
    }

    public int GetMyField()
    {
        return myField;
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        myObject.SetMyField(560);

        int value = myObject.GetMyField();
        Console.WriteLine($"The value of myField is: {value}");
    }
}

Que3Ass3:
Ans: -
using System;

public static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The input array must not be empty or null.");
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        double average = MathHelper.CalculateAverage(numbers);

        Console.WriteLine("Average: {average}");
    }
}

Que4Ass3:
Ans: -
using System;

public class MyBaseClass
{
    protected int protectedField = 127;

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMembers()
    {
        Console.WriteLine($"Accessing protected field from derived class: {protectedField}");
        ProtectedMethod();
    }
}

class Program
{
    static void Main()
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        derivedObject.AccessProtectedMembers();
    }
}

Que5Ass3:
Ans: -
using System;

namespace AssemblyA
{
    public class MyClass
    {
        protected internal int ProtectedInternalMember = 172;

        public void Display()
        {
            Console.WriteLine($"Protected Internal Member{ProtectedInternalMember}");
        }
    }
}
AssemblyClass:
using System;

namespace AssemblyA
{
    public class MyClass
    {
        protected internal int ProtectedInternalMember = 172;

        public void Display()
        {
            Console.WriteLine($"Protected Internal Member: {ProtectedInternalMember}");
        }
    }
}

Que6Ass3:
Ans: -
using System;

class Program
{
    static void Main(string[] args)
    {
        DerivedClass derivedInstance = new DerivedClass();

        derivedInstance.AccessProperty();

        Console.WriteLine($"Value of MyProperty: {derivedInstance.MyProperty}");
    }
}
Dclass:
// DerivedClass.cs
public class DerivedClass : BaseClass
{
    public void AccessProperty()
    {
        MyProperty = "Accessed from DerivedClass";
    }
}
Que7Ass3:
Ans: -
using System;

public class MyClass
{
    private int myPrivateProperty;

    public MyClass(int initialValue)
    {
        myPrivateProperty = initialValue;
    }

    public void SetPrivateProperty(int newValue)
    {
        myPrivateProperty = newValue;
    }

    public int GetPrivateProperty()
    {
        return myPrivateProperty;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass(10);

        Console.WriteLine($"Initial Value: {myObject.GetPrivateProperty()}");

        myObject.SetPrivateProperty(20);

        Console.WriteLine($"Updated Value: {myObject.GetPrivateProperty()}");
    }
}

Que8Ass3:
Ans: -
using System;

public class MyClass
{
    private void MyPrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    public void MyPublicMethod()
    {
        Console.WriteLine("This is a public method.");

        MyPrivateMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.MyPublicMethod();
    }
}

Que9Ass3:
Ans: -
using System;

public class MyBaseClass
{
    protected void MyProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

public class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMethod()
    {
        Console.WriteLine("Calling the protected method from the derived class:");

        MyProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        derivedObject.AccessProtectedMethod();
    }
}
Que10Ass3:
Ans: -

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.7.34031.279
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Que10 ass3", "Que10 ass3\Que10 ass3.csproj", "{93F1C2D9-8229-4BD4-90B3-9A7994CE2392}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution

        Debug | Any CPU = Debug | Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution

        { 93F1C2D9 - 8229 - 4BD4 - 90B3 - 9A7994CE2392}.Debug | Any CPU.ActiveCfg = Debug | Any CPU
		{93F1C2D9-8229-4BD4-90B3-9A7994CE2392}.Debug | Any CPU.Build.0 = Debug | Any CPU
		{93F1C2D9-8229-4BD4-90B3-9A7994CE2392}.Release | Any CPU.ActiveCfg = Release | Any CPU
		{93F1C2D9-8229-4BD4-90B3-9A7994CE2392}.Release | Any CPU.Build.0 = Release | Any CPU
    EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution

        HideSolutionNode = FALSE

    EndGlobalSection

    GlobalSection(ExtensibilityGlobals) = postSolution

        SolutionGuid = { B7142976 - FEA0 - 4907 - A0FB - 99D341ACFFA5}
EndGlobalSection
EndGlobal
