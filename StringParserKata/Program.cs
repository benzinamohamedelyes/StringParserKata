namespace StringParserKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the stringParser kata");
            Console.WriteLine("************************************");
            var stop = false;
            while (!stop)
            {
                Console.WriteLine("Please enter the original string or 'exit' to quit");
                var input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    stop = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please enter the string to search for");
                        var stringToSearch = Console.ReadLine();
                        if (!string.IsNullOrEmpty(stringToSearch))
                        {
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (input[i] == stringToSearch[0] && i + stringToSearch.Length < input.Length)
                                {
                                    var found = true;
                                    for (int j = 1; j < stringToSearch.Length; j++)
                                    {
                                        if (input[i + j] != stringToSearch[j])
                                        {
                                            found = false;
                                            break;
                                        }
                                    }
                                    if (found)
                                    {
                                        Console.WriteLine($"Found '{stringToSearch}' at index {i}");
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine($"Not Found '{stringToSearch}'");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid string to search for .");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid string .");
                    }
                }
            }
        }
    }
}
