class Adharcard
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
