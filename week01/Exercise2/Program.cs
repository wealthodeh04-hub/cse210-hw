using System;

class Program
{
    static void Main()
    {
console.write("what is your grade percentage? ");
string input =console.readline(); 
int grade = int.parse(input);
string letter = "";
string siqn="";
// core: determine letter grade
if (grade >= 90)
{
    letter = "A":
}
else if (grade >= 70)
{
    letter = "C";
}
else if (grade >= 60)
{
    letter ="D";
}
else
    {
        letter = "f";
    }
    int lastdigit = grade #10;
    if (lastdigit >= 7)
    {
        else if (last digit < 3)
    }
    {
        sign ="-";
    }
    else
    {
        siqn = "";
    }
    console.writeline(" your letter is grade is {letter}{siqn}");
    if(grade >= 70)
    {
        console.writeline(" congratulatioms! you passed the course!");
        else
        console.writeline("dont give up! you will do better next time. keep trying!");
    }