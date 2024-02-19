/*1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.*/

//int[] ipItems ;

string[] ipv4Inputs = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};

string[] ipItems;

bool validLength = false;
bool validZeroes = false; 
bool validRange = false;




foreach (string ip in ipv4Inputs)
{
    ipItems = ip.Split('.',StringSplitOptions.RemoveEmptyEntries);
    ipValidLength();
    ipValidRange();
    ipValidZeroes();

    if (validLength && validRange && validZeroes)
    {
        Console.WriteLine($"Good!, Valid ip!:  {ip}");
    }
    else 
    {
        Console.WriteLine($"sorry,Invalid {ip}");
    }
   
}




//check ip contain 4 numbers
void ipValidLength ()
{
    //Console.WriteLine(ipItems.Length);   
    if (ipItems.Length == 4)
    {
        validLength = true;
    }
    else 
    {
        validLength = false;
    }
}

//check each number doesnt start with 0
void ipValidZeroes () 
{
    foreach (string item in ipItems)
    {
        if (item.Trim().StartsWith("0") && item.Length>1 )
        {
            validZeroes=false;
            
            return;
        }
    }
    validZeroes = true;
}

//check range 
void ipValidRange () 
{
    foreach (string ipItem in ipItems)
    {
        //convert to int
        bool isNumber = int.TryParse(ipItem.Trim(), out int outVal);
       
        if (outVal>255 && isNumber)
        {
            validRange=false;
            return;
        }
    }
    validRange = true;
}
