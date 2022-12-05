void Day3_Task1()
{
    int totalPriority = 0;
    List<char> doubledCharacters = new List<char>();

    string[] lines = File.ReadAllLines("../../../input.txt");
    foreach (string line in lines)
    {
        string firstHalf = line.Substring(0, line.Length / 2);
        char[] characters = firstHalf.ToCharArray();
        char[] characters2 = line.Substring(line.Length / 2).ToCharArray();
        foreach (char character in characters)
        {
            if (characters2.Contains(character))
            {
                doubledCharacters.Add(character);
                break;
            }
        }
    }

    foreach (char doubledCharacter in doubledCharacters)
    {
        if (doubledCharacter > 64 && doubledCharacter < 91)
        {
            totalPriority += (doubledCharacter - 38);
        }
        else
        {
            totalPriority += (doubledCharacter - 96);
        }
    }

    Console.WriteLine($"Total priority is {totalPriority}");
}

void Day3_Task2()
{
    int totalPriority = 0;
    List<char> badgeItems = new List<char>();

    string[] lines = File.ReadAllLines("../../../input.txt");
    for (int i = 0; i < lines.Length; i = i + 3)
    {
        char[] backpack1 = lines[i].ToCharArray();
        char[] backpack2 = lines[i + 1].ToCharArray();
        char[] backpack3 = lines[i + 2].ToCharArray();

        foreach (char item in backpack1)
        {
            if (backpack1.Contains(item) && backpack2.Contains(item) && backpack3.Contains(item))
            {
                badgeItems.Add(item);
                break;
            }
        }
    }

    foreach (char item in badgeItems)
    {
        if (item > 64 && item < 91)
        {
            totalPriority += (item - 38);
        }
        else
        {
            totalPriority += (item - 96);
        }
    }

    Console.WriteLine($"Total priority is {totalPriority}");
}

Day3_Task1();
Day3_Task2();
