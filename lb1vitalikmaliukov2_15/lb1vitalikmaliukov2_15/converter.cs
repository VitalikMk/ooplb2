namespace lb1vitalikmaliukov2_15
{
    public class Converter
    {

        private double usd;
        private double eur;
        private double pln;

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public int convertUAHToUSD(double amount)
        {
            return (int)Math.Round((amount / usd));
        }

        public int convertUSDToUAH(double amount)
        {
            return (int)Math.Round(amount * usd);
        }

        public int convertEURToUAH(double amount)
        {
            return (int)Math.Round(amount * eur);
        }
        public int convertPLNToUAH(double amount)
        {
            return (int)Math.Round(amount * pln);
        }
    }
}
