public class SamsungPayment:Ipayment
{
    public int Payment(double invoiceamount)
    {
      if (invoiceamount>0)
             {
                Console.WriteLine("Payment processed with SamsungPay");
                return 1;
             }
             else 
             return 0;
    }
}