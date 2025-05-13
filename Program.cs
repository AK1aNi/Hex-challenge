namespace Hex_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Input a hexcode: ");
                string us_in = Console.ReadLine();

                if (us_in.Length != 7)
                {
                    Console.WriteLine("Invalid input, try again - input length");
                    valid = false;
                }
                if (us_in.Substring(0,1) != "£" && us_in.Substring(0,1)!= "#")
                {

                }
            }
            while (valid!=true);


        }
    }
}
