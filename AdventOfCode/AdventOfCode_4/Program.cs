void Day4_Task1()
{
    int totalAssignmentPairs = 0;

    string[] lines = File.ReadAllLines("../../../input.txt");
    foreach (string line in lines)
    {
        string[] sections = line.Split(",");
        string[] range1 = sections[0].Split("-");
        string[] range2 = sections[1].Split("-");

        int range1Start = Int32.Parse(range1[0]);
        int range1End = Int32.Parse(range1[1]);
        int range2Start = Int32.Parse(range2[0]);
        int range2End = Int32.Parse(range2[1]);

        if ((range2Start >= range1Start && range2End <= range1End) || (range1Start >= range2Start && range1End <= range2End))
        {
            totalAssignmentPairs++;
        }

    }

    Console.WriteLine($"Total pairs: {totalAssignmentPairs}");
}

Day4_Task1();