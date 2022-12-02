void Day2_Task1()
{
    int score = 0;
    string[] lines = File.ReadAllLines("../../../input.txt");
    foreach (string line in lines)
    {
        string[] chooses = line.Split(" ");
        switch (chooses[0])
        {
            case "A":
                switch (chooses[1])
                {
                    case "X":
                        score += 4;
                        continue;
                    case "Y":
                        score += 8;
                        continue;
                    case "Z":
                        score += 3;
                        continue;
                }
                break;

            case "B":
                switch (chooses[1])
                {
                    case "X":
                        score += 1;
                        continue;
                    case "Y":
                        score += 5;
                        continue;
                    case "Z":
                        score += 9;
                        continue;
                }
                break;

            case "C":
                switch (chooses[1])
                {
                    case "X":
                        score += 7;
                        continue;
                    case "Y":
                        score += 2;
                        continue;
                    case "Z":
                        score += 6;
                        continue;
                }
                break;
        }
    }
    Console.WriteLine($"Your score is {score}");
}

void Day2_Task2()
{
    int score = 0;
    string[] lines = File.ReadAllLines("../../../input.txt");
    foreach (string line in lines)
    {
        string[] chooses = line.Split(" ");
        switch (chooses[0])
        {
            case "A":
                switch (chooses[1])
                {
                    case "X":
                        score += 3;
                        continue;
                    case "Y":
                        score += 4;
                        continue;
                    case "Z":
                        score += 8;
                        continue;
                }
                break;

            case "B":
                switch (chooses[1])
                {
                    case "X":
                        score += 1;
                        continue;
                    case "Y":
                        score += 5;
                        continue;
                    case "Z":
                        score += 9;
                        continue;
                }
                break;

            case "C":
                switch (chooses[1])
                {
                    case "X":
                        score += 2;
                        continue;
                    case "Y":
                        score += 6;
                        continue;
                    case "Z":
                        score += 7;
                        continue;
                }
                break;
        }
    }
    Console.WriteLine($"Your score is {score}");
}

Day2_Task1();
Day2_Task2();