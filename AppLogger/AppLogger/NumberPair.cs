namespace AppLogger
{
    public class Szamparos
    {
        public float Number1 { get; set; }
        public float Number2 { get; set; }
        public char Operation { get; set; }

        public Szamparos(float number1, float number2, char operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
        }

        private float osszeadas()
        {
            return Number1 + Number2;
        }
        private float kivonas()
        {
            return Number1 - Number2;
        }
        private float szorzas()
        {
            return Number1 * Number2;
        }
        private float osztas()
        {
            return Number1 / Number2;
        }

        public float? calculate()
        {
            if(Operation == '+') { return osszeadas(); }
            else if(Operation == '-') { return kivonas();}
            else if(Operation == '*') { return szorzas(); }
            else if(Operation == '/') { return osztas(); }
            else { return null; }
        }


    }
}