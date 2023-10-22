public class PaypallPayment:Ipayment
{
    public int Payment(double invoiceamount)
    {
      if (invoiceamount>0)
             {
                Console.WriteLine("Payment processed with PaypallPay");
                return 1;
             }
             else 
             return 0;
    }
}