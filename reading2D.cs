
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


// Creates a 3x4 two-dimensional
//string[,] twoDArray = new string[3, 4]; 

for(int i = 0; i < corporate.GetLength(0) ; i++)
{
    (string firstName, string lastName) = (corporate[i, 0], corporate[i, 1]);
    showEmail(firstName, lastName);
}

for(int i = 0; i < external.GetLength(0) ; i++)
{
    string name =  corporate[i,0].Substring(0,2); //name with first 2 letters
    string lastname = corporate[i,1]; //lastname
    showEmail(name,lastname, domain:"external.com");
}


void showEmail(string name,string lastname, string domain="contoso.com")
{
  
    (name,lastname) =  (name.Substring(0,2).ToLower(), lastname.ToLower()); //name with first 2 letters

    Console.WriteLine($"{name}{lastname}@{domain}");
}