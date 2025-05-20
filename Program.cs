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

                if (us_in.Length == 7)
                {
                    if (us_in.Substring(0,1) == "£" && us_in.Substring(0,1) == "#")
                    {
                        Console.WriteLine("gid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again - first char");
                        valid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again - input length");
                    valid = false;
                }
            }
            while (valid!=true);


        }
    }
}
