public class Power240 :Ipower240
{
    public void about()
    {
        Console.WriteLine("I am from Poweri120");
    }

    public void consumpower240(int w)
    {
        if (w >240)
        {
            Console.WriteLine(" I can not consume this power > 240");
        }
        else 
        {
            Console.WriteLine(" I can  consume this power  <= 240");
        }

    }

}