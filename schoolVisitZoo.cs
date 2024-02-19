//randomize the animals
//asign animals  to the correct # groups
//school name, animal groups

//A : 6g, B:3g, C:2g


string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};


PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 4);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups=6)
{
    RandomAnimals();
    //string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(AssignGroup(groups));
}

void RandomAnimals()
{
    Random rand = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = rand.Next(i,pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
    
}

string[,] AssignGroup(int groups=6)
{
    //set size 2d array
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {            
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i+1}: ");
        for (int j = 0; j < group.GetLength(1);j++)
        {
            Console.Write($"{group[i,j]}| ");
        }
        Console.WriteLine();
    }
}

