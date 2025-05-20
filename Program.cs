namespace Hex_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            int char_inv = 0;
            do
            {
                Console.WriteLine("Input a hexcode: ");
                string us_in = Console.ReadLine();
                char[] checker = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f'];
                
                if (us_in.Length == 7)
                {
                    if (us_in[0] == '£' || us_in[0] == '#')
                    {
                        for (int i = 1; i < 7; i++)
                        {
                            if (checker.Contains(us_in[i]))
                            {
                                char_inv = char_inv + 1;
                            }

                        }
                        if (char_inv == 6)
                        {
                            // £123456→
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, not a hexcode");
                        }
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
