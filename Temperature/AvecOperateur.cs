namespace Evaluation1.Exercice1
{
    public class AvecOperateur
    {
        public class Celsius
        {
            public double Valeur { get; set; }

            public override string ToString()
            {
                return $"La valeur en Celsius: {Valeur}";
            }
            static public explicit operator Fahrenheit(Celsius celsius)
            {
                return new Fahrenheit() { Valeur = (celsius.Valeur * 9 / 5) + 32 };
            }
        }

        public class Fahrenheit
        {
            public double Valeur { get; set; }

            public override string ToString()
            {
                return $"La valeur en Fahrenheit {Valeur}";
            }
            static public implicit operator Celsius(Fahrenheit fahrenheit)
            {
                return new Celsius() { Valeur = (fahrenheit.Valeur - 32) * 5 / 9 };
            }

        }
    }
}
