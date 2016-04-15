using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

class A
{
    private string name = "SYSAl4";
    ArrayList a = new ArrayList();
    public virtual string Name
    {
        get { return name; }
        set { name = value; }
    }
    public void print(Person p)
    {
        Console.WriteLine(p.Name);
    }
}
interface IMyInterface1
{
    object whoAreYou(IMyInterface1 imi);
}
interface IMyInterface2
{
    object whoAreYou(string str);
}
class Person : A, IMyInterface1, IMyInterface2
{
    private string id;

    public Person() { }

    public Person(string id, string name)
    {
        Name = name;
        this.id = id;
    }
    public override string ToString()
    {
        return "Hata Data";
    }

    public void print()
    {
        int s = Name.Length;
        Console.WriteLine(s.GetType());
    }
    public object whoAreYou(IMyInterface1 imi)
    {
        string s = "jocke";
        Console.WriteLine(imi.ToString());
        return imi.GetType();
    }

    public object whoAreYou(string s)
    {
        return s.GetType();
    }
    public static Person operator *(Person p1, Person p2)
    {
        return new Person(p1.id + p2.id, "hata tenta");
    }

}

class Uppgift1
{

    private string name = "tenta";

    static void a()
    {
        Person p1 = new Person("1", "anna");
        Person p2 = p1;
        ((Person)p2).print();
        Console.WriteLine(p2.GetType() + "\n");
    }
    static void b()
    {
        Person p1 = new Person("1", new Uppgift1().name);
        Console.WriteLine(new Uppgift1().bTemp(p1) + "\n");
    }
    public bool bTemp(IMyInterface2 imi)
    {
        Person p = imi as Person;
        Person p2 = p;
        Console.WriteLine(p.Equals(p2));
        return Equals(p2);
    }
    static void c()
    {
        IMyInterface1 imi;
        Person p1 = new Person("123", "anna");
        imi = p1 as IMyInterface1;
        Console.WriteLine(imi.whoAreYou(imi) + "\n");
    }
    static bool f(object a, object b)
    {
        return (Object.ReferenceEquals(a, b));
    }
    static bool f2(Person a, Person b)
    {
        return (Object.ReferenceEquals(a, b));
    }
    static bool f2()
    {
        Person p1 = new Person("1234", "anna");
        Console.WriteLine(p1.whoAreYou("eva"));
        return false;
    }
    static void d()
    {
        Person p1 = new Person("1", "anna");
        Person p2 = new Person("2", "data");
        Person p3 = p1 * p2;
        p3.print();
    }
    static void e()
    {

        Person p1 = new Person("1234", "anna");
        Person p2 = new Person("1234", "anna");

        Console.WriteLine(object.ReferenceEquals(p1, p2));
    }

    static void Main(string[] args)
    {
        a();
        b();
        c();
        d();
        e();
        Console.Read();
    }
}
