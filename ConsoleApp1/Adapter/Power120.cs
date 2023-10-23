public class Powwer120 :Ipower120
{
    public void about()
    {
        Console.WriteLine("I am from Poweri120");
    }

    public void consumpower120(int w)
    {
        if (w > 120)
        {
            Console.WriteLine(" I can not consume this power > 120");
        }
        else 
        {
            Console.WriteLine(" I can  consume this power  <= 120");
        }

    }

}