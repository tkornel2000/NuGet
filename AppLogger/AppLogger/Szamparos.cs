namespace AppLogger
{
    public class Szamparos
    {
        public float egyik { get; set; }
        public float masik { get; set; }

        public Szamparos(float egyik, float masik)
        {
            this.egyik = egyik;
            this.masik = masik;
        }
        public void Setter(float egyik, float masik)
        {
            this.egyik = egyik;
            this.masik = masik;
        }
        public float osszeadas()
        {
            return egyik + masik;
        }
        public float kivonas()
        {
            return egyik - masik;
        }
        public float szorzas()
        {
            return egyik * masik;
        }
        public float osztas()
        {
            return egyik / masik;
        }

    }
}