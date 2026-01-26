using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

public class MysteriousName
{    
    public double Calc(double a, double b) // Bad naming
    {
        return (a + b) / 2;
    }
    
    public double Average(double a, double b) // Better naming
    {
        return (a + b) / 2;
    }
}

// Bad Naming
public class SomeDataStructure
{
    // ...
    public int Read()
    {
        //...
        throw new NotImplementedException("Ongoing implementation");
    }

    public void Write(int value)
    {
        // ...
    }
}
// Better Naming
public class Queue
{
    // ...
    public int Dequeue()
    {
        //...
        throw new NotImplementedException("Ongoing implementation");
    }

    public void Enqueue(int value)
    {
        // ...
    }
}
