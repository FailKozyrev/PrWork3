namespace PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double A;
                double B;
                double C;
                Console.WriteLine("Введите число A");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число B");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию ");
                string D;
                D = Convert.ToString(Console.ReadLine());
                if (D == "+")
                {
                    C = A + B;
                    Console.WriteLine(C);
                }
                else if (D == "-")
                {
                    C = A - B;
                    Console.WriteLine(C);
                }
                else if (D == "*")
                {
                    C = A * B;
                    Console.WriteLine(C);
                }
                else if (D == "/")
                {
                    C = A / B;
                    Console.WriteLine(C);
                }

            }
        }
    }
}
