namespace Runners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Run> runs = new List<Run>();

            if (int.TryParse(Console.ReadLine(), out int inputsCount))
            {
                for (int i = 0; i < inputsCount; i++)
                {
                    string line = Console.ReadLine();
                    string[] lineParams = line.Split(' ');

                    if (lineParams.Length == 3)
                    {
                        string personName = lineParams[0];
                        string familyName = lineParams[1];

                        if (double.TryParse(lineParams[2], out double runTime))
                        {
                            Run obj = new Run(personName, familyName, runTime);
                            runs.Add(obj);
                        }
                        else
                        {
                            Console.WriteLine("Invalid run time format: " + lineParams[2]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input: " + line);
                    }
                }

                runs.Sort();

                foreach (Run run in runs)
                {
                    Console.WriteLine($"{run.PersonName} {run.PersonFamilyName} {run.Time}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the number of runs.");
            }
        }
    }
}