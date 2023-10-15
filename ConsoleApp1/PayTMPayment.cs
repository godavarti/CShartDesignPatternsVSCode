public class PayTMPayment:Ipayment
{
    public int Payment(double invoiceamount)
    {
      if (invoiceamount>0)
             {
                Console.WriteLine("Payment processed with PayTMPay");
                return 1;
             }
             else 
             return 0;
    }
}