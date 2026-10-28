namespace factory
{
    using Parsian;
    using Zarinpal;
    using IPayment;
    public class Factory
    {
        public static IPayment Create(long Price)
        {
            if (Price < 0) throw new ArgumentException("مبلغ معتبر نیست.");
            if (Price <= 1000000) return new Parsian();
            return new Zarinpal();
        }
    }
}