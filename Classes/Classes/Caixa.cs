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

        public static int area()
        {
            int l = 2;
            int a = l*l;
            return a;
        }
    }

}