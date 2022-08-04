// See https://aka.ms/new-console-template for more information
class Day1
{
    public void Register()
    {
        Console.WriteLine("Registered");
    }
    public void Aptitude()
    {
        Console.WriteLine("Aptitude round Cleared");

    }
}

class Day2 : Day1
{
    public void Technical1()
    {
        Console.WriteLine("technical one cleared");
    }
    public void Technical2()
    {
        Console.WriteLine("Technical two cleared");
    }
}

class Day3 : Day2
{
    public void HR()
    {
        Console.WriteLine("cleared HR round");
    }
}
class JoiningDay : Day3
{
    public string status = "Selected";
}

class Interview
{
    static void Main(string[] args)
    {
        JoiningDay join = new JoiningDay();
        Console.WriteLine("Interviw Details");
        join.Register();
        join.Aptitude();
        join.Technical1();
        join.Technical2();
        join.HR();
        Console.WriteLine("Status: "+join.status);
    }
}