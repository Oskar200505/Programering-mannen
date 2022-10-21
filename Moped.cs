using System.Security.Cryptography.X509Certificates;

public class moped
{

    private string motorTyp = "el";
    private int däck = 2;
    private string färg = "röd";

    public int getDäck()
    {
        return this.däck;
    }
    public string getFärg()
    {
        return this.färg;
    }

    public void setFärg(string färg)
    {
        this.färg = färg;
    }
}