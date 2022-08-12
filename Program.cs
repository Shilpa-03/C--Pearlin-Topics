/*INTERFACE*/
/*public interface Rocket
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


/* ENCAPSULATION*/
/*class Adharcard
{
    private double adharnum;
    private string? adharname;
    public double getadharnum()
    {
       
        return adharnum;
    }
    public string getadharname()
   {
        
      return adharname;
   }
    public void setno(double no)
    {
        this.adharnum = no;
    }
    public void setname(string name)
    {
        this.adharname = name;
    }
}
class GoveProof
{
    public static void Main (string[] args)
    {
        Adharcard ad = new Adharcard();
        ad.setno(1234509876);
        Console.WriteLine(ad.getadharnum());
        ad.setname("Shilpa");
        Console.WriteLine(ad.getadharname());

    }
}

 // MULTIPLE INHERITANCE
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


/*OVERLOADING
class Employee
{
    public void display(string name)
    {
        Console.WriteLine("Employee Name: " + name);

    }
    public void display(String empId, Double mobileNo)
    {
        Console.WriteLine("Employee Id: " + empId);
        Console.WriteLine("Mobile Number: " + mobileNo);
    }
    public void display(string email, string gender)
    {
        Console.WriteLine("email id: " + email);
        Console.WriteLine("Gender: " + gender);
    }
}
class PolyC
{
    public static void Main (string[] args)
    {
        Employee emp = new Employee();
        emp.display("Shilpa");
        emp.display("01T003", 6563784569);
        emp.display("Shilpa.nivalagi@kalpitatechnologies.com", "Female");
    }
}

/* OVERRIDING */
class Hotel
{
    public virtual void order()
    {
        Console.WriteLine("Prepare the food according to order");
    }
}
class Zomato : Hotel
{
    public override void order()
    {
        Console.WriteLine("Zomato Offers");
    }
}

class Swiggy : Hotel
{
    public override void order()
    {
        Console.WriteLine("Swiggy offers");
    }
}
//class customer:Hotel
//{
   // public void order(Hotel h)
   // {
   //     h.order();
   // }
//
class Polyr
{
    public static void Main(string[] args)
    {
       Zomato z = new Zomato();
        z.order();
        Swiggy s = new Swiggy();
        s.order();
    }
}



