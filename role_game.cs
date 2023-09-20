//Role Play - Game Batle
Random random = new Random();
//Health points
int heroHealth = 10;
int monsterHealth = 10;

//game turn 
bool turn = true;

while ( (heroHealth>0) && (monsterHealth>0) )
{
    int attackValue = random.Next(1,11);
    if (turn) 
    {
        //hero attack first
        monsterHealth -= attackValue;
        turn = false;
    }
    else {
        //monster attack 
        heroHealth -= attackValue;
        turn = true;
    }
    
    string msg =  (turn) ? $"Hero damaged, lost: {attackValue}, remain:{heroHealth}p" :  $"Monster damaged, lost:{attackValue}, remain: {monsterHealth}p";
    Console.WriteLine(msg);

}
Console.WriteLine($"Final score :  Hero: {heroHealth}p, Monster:{monsterHealth}p");
string msg_result = (heroHealth>monsterHealth) ? "Hero wins!" : "Monster wins!";
Console.WriteLine(msg_result);