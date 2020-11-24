using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    private string name = "Anusha";
    public string GetName()
    {
        return this.name;
    }

    public void SetName(string s)
    {
        this.name = s;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.SetName("Anusha");
        Console.WriteLine(s.GetName());
    }
}