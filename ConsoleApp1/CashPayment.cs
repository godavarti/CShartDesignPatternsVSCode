public class CashPayment:Ipayment
{
    public int Payment(double invoiceamount)
    {
      if (invoiceamount>0)
             {
                Console.WriteLine("Payment processed with CashPay");
                return 1;
             }
             else 
             return 0;
    }
}