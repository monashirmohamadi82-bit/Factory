namespace Parsian
{
    using IPayment;
    public class Parsian : IPayment
    {
        public void Pay(long Price)
        {
            System.Console.WriteLine($"{Price} با درگاه پارسیان پرداخت شد.");
        }
    }
}