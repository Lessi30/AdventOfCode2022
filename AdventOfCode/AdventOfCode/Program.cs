
void Day1_Task1()
{
    string[] lines = File.ReadAllLines("../../../input.txt");
    List<int> elves = new List<int>();
    int calories = 0;

    foreach (string line in lines)
    {
        if (line == "")
        {
            elves.Add(calories);
            calories = 0;
            continue;
        }
        calories += Int32.Parse(line);
    }

    elves.Sort();
    Console.WriteLine($"Day 1: {elves[elves.Count - 1]}");
}

void Day1_Task2()
{
    string[] lines = File.ReadAllLines("../../../input.txt");
    List<int> elves = new List<int>();
    int calories = 0;

    foreach (string line in lines)
    {
        if (line == "")
        {
            elves.Add(calories);
            calories = 0;
            continue;
        }
        calories += Int32.Parse(line);
    }

    elves.Sort();
    Console.WriteLine($"Day 2: {elves[elves.Count - 1] + elves[elves.Count - 2] + elves[elves.Count - 3]}");
}

Day1_Task1();
Day1_Task2();