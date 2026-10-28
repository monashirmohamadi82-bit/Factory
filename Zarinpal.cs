namespace Zarinpal
{
    using IPayment;
    public class Zarinpal : IPayment
    {
        public void Pay(long Price)
        {
            System.Console.WriteLine($"{Price}  با درگاه زرین‌پال پرداخت شد.");
        }
    }
}