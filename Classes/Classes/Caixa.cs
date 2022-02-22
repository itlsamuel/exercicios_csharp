namespace Classes
{
    internal class Caixa
    {
        private double lado;
        public Caixa()
        {
            lado = 10;
        }

        public double Volume()
        {
            return lado * lado * lado;
        }
    }

}