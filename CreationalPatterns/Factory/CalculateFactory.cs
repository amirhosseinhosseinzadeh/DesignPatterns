namespace DesignPatterns.CreationalPatterns.Factory
{
    public class Calculatefactory
    {
        public ICalculate GetCalCulation(string type)
            => type.ToLower() switch 
            {
                "add" => new Add(),
                "minues" => new Minues(),
                "divide" => new Divide(),
                _ => throw new System.ArgumentException()
            };

        public class Add : ICalculate
        {
            public void Calculate(int a, int b)
            {
                System.Console.WriteLine("a + b = {0}", a + b);
            }
        }

        public class Divide : ICalculate
        {
            public void Calculate(int a, int b)
            {
                System.Console.WriteLine("a / b = {0}", a / b);
            }
        }

        public class Minues : ICalculate
        {
            public void Calculate(int a, int b)
            {
                System.Console.WriteLine("a - b = {0}", a - b);
            }
        }
    }
}