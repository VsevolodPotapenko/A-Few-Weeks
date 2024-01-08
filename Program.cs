


A a = new(1);

Console.WriteLine(a.Value);

E(a);

Console.WriteLine(a.Value);



void E(A a)
{
    a.Value = 1000;
    Console.WriteLine(a.Value);

    a = new(10);
    Console.WriteLine(a.Value);
}


class A
{
    public int Value;

    public A(int value)
    {
        Value = value;
    }
}