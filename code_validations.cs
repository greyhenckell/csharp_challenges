

//PROJECT 1: Validate integer entered by propmt

string? readResult;

bool isNumber = false;
bool isRange = false;

Console.WriteLine("enter a number between 5-10");
do {
    readResult = Console.ReadLine();    
    isNumber = int.TryParse(readResult, out int numericValue);
    //Console.WriteLine($"read:{readResult},numv:{numericValue},:{isNumber},");
    isRange = (numericValue>=5 && numericValue<=10);
    if (isNumber) 
    {
        if (isRange) 
        {
            continue;
        }
        else
        {
            Console.WriteLine("enter value between 5-10");
        }
    } 
    else
    {
        Console.WriteLine("pls enter digit");
    } 
}
while ( (readResult == null) || (!isNumber) || (!isRange) );

Console.WriteLine($"THNKS! Input Accepted: {readResult}");


//PROJECT 2
//VALIDATE STRING ROLE

bool validEntry = false;

Console.WriteLine("are you Admin|Manager|User");
do 
{

    readResult = Console.ReadLine();
    if (readResult!=null)
    {
        string result = readResult.ToLower();
        if ( (result == "admin") || (result == "manager") || (result == "user") )
        {
            validEntry = true;
        }
        else { Console.WriteLine("Plese enter a valid role"); }
    }

}
while ( !validEntry );

Console.WriteLine($"The role name is: {readResult}");


//PROJECT3: print each likes sentence using for and do-while when is needed

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad",
                                     "I like all three of the menu choices" };


foreach ( string myString in myStrings)
{
    if (myString.Contains(".") )
    {
        string[] senteceLike = myString.Split(".");
        int count = 0;
        do 
        {
            
            foreach ( string sentece in senteceLike)
            {
                Console.WriteLine(sentece.TrimStart());
                count +=1;
            }            
        }
        while ( count < senteceLike.Length );
    }
    else 
    {
        Console.WriteLine(myString.TrimStart());
    }
    
}
