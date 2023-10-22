public class ApplePayment:Ipayment
{
    public int Payment(double invoiceamount)
    {
      if (invoiceamount>0)
             {
                Console.WriteLine("Payment processed with ApplePay");
                return 1;
             }
             else 
             return 0;
    }
}