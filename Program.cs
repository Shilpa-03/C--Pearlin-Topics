public interface Rocket
{
    public void flying();
    
}
public interface Auto
{
    public void threeweel();
}
public class Flight : Rocket, Auto
{
    public void flying()
    {
        Console.WriteLine("Fly using wings");
    }
    public void threeweel()
    {
        Console.WriteLine("Run using three weels");
    }

}
 //Explicit Inteface Implementation

class Interface
{
    static void Main (string[] args)
    {
        Flight f = new Flight();

        Rocket r = f;
        r.flying();

        Auto a = f;
        a.threeweel();
       
    }
}
