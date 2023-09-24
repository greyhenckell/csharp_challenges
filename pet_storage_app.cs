// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:    
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:    
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
    
        case 3:    
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    
        default:    
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}


do 
{
    // display the top-level menu options
    Console.Clear();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        Console.WriteLine($"You selected menu option {menuSelection}.");
        
        switch (menuSelection)
        {
            case "1":
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i,0].Length > "ID #: ".Length)
                    {
                        Console.WriteLine();
                        for (int j = 0; j <6; j++)
                        {
                            Console.WriteLine(ourAnimals[i,j]);        
                        }
                    }
                }
                
                Console.WriteLine("Press the Enter key to continue");
                readResult = Console.ReadLine();                
                break;

            case "2":
                int count = 0;
                string newPet = string.Empty;
                for (int i = 0; i < maxPets; i++)
                {   
                    if (ourAnimals[i,0].Length > "ID #: ".Length)
                    {
                        count ++ ;
                    }               
                }
                Console.WriteLine($"Current number of pets: {count}");
                
                if (maxPets-count > 0)
                {
                    do 
                    {
                        Console.WriteLine($"Spots available: {(maxPets-count)}");
                        Console.WriteLine("Add a new Pet y/n ? ");
                        
                        readResult = Console.ReadLine();
                        if ((readResult == "y") && (maxPets-count > 0))
                        {
                            bool validEntry = false;
                            // CAT OR DOG & ID value
                            do
                            {
                                Console.WriteLine("Enter a cat or dog to begin a new entry");
                                readResult = Console.ReadLine();
                                if (readResult!=null)
                                {
                                    animalSpecies = readResult.ToLower();
                                    int idValue = count +1;
                                    if (animalSpecies == "cat" || animalSpecies == "dog")
                                    {
                                        animalID = animalSpecies.Substring(0, 1) + idValue.ToString();
                                        validEntry = true;
                                    }

                                }

                            }
                            while (validEntry==false);

                            //AGE validation
                            int petAge = 0;
                            do {
                                Console.WriteLine("enter pet's Age or type 0 if unknown");
                                readResult = Console.ReadLine();
                                
                                if (readResult!=null)
                                {
                                    validEntry = int.TryParse(readResult, out petAge);                                                                               
                                }
                            }
                            while (validEntry==false);
                            animalAge = petAge.ToString();

                            //physical description
                            do
                            {
                                Console.WriteLine("enter physical pets description");
                                readResult = Console.ReadLine();
                                if (readResult!=null)
                                {
                                    animalPhysicalDescription = readResult.ToLower();
                                    validEntry = true;
                                }
                                else 
                                {
                                    animalPhysicalDescription = "unknown";
                                    validEntry = true;
                                }                          
                            }
                            while (validEntry==false);

                            // Personality validation
                            do
                            {
                                Console.WriteLine("enter personality description");
                                readResult = Console.ReadLine();
                                if (readResult!=null)
                                {
                                    animalPersonalityDescription = readResult.ToLower();
                                    validEntry = true;
                                }
                                else 
                                {
                                    animalPersonalityDescription = "unknown";
                                    validEntry = true;
                                }                                  
                            }
                            while (validEntry==false);

                            // Nickname validation
                            do
                            {
                                Console.WriteLine("enter pet's nickname");
                                readResult = Console.ReadLine();
                                if (readResult!=null)
                                {
                                    animalNickname = readResult.ToLower();
                                    validEntry = true;
                                }
                                else
                                {
                                    animalNickname = "unknown";
                                    validEntry = true;
                                }                             
                                
                            }
                            while (validEntry==false);

                            //UPDATE animals array                            
                            ourAnimals[count, 0] = "ID #: " + animalID;
                            ourAnimals[count, 1] = "Species: " + animalSpecies;
                            ourAnimals[count, 2] = "Age: " + animalAge;
                            ourAnimals[count, 3] = "Nickname: " + animalNickname;
                            ourAnimals[count, 4] = "Physical description: " + animalPhysicalDescription;
                            ourAnimals[count, 5] = "Personality: " + animalPersonalityDescription;
                            
                            //add pet count
                            count ++;
                        }
                    }
                    while ( (readResult != "n") && (maxPets-count > 0));
                    
                }
               
                Console.WriteLine($"Sorry, you reached max storage pets: {count}!");                        
                
                Console.WriteLine("Press the Enter key to continue");
                readResult = Console.ReadLine();
                break;

            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
                Console.WriteLine($"Sorry, we are working hard to build this option, thnks!");
                Console.WriteLine("Press the Enter key to continue");
                readResult = Console.ReadLine();
                break;
            default:                
                break;
        }

    }
}
while (menuSelection != "exit");
Console.WriteLine("bye bye!");