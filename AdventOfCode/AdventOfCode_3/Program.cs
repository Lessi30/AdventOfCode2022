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

Day3_Task1();
