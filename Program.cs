using System;
using System.Text.RegularExpressions;
using System.Xml;
namespace HelloWorld { 
class Program { 
    static void Main(){ 
    (string ColourInput, string hints)[]UserInput = new (string, string)[12];   
    int Turns = 0;
    //Generating the correct answer
    string[]CorrectAns = GenAns();
    PrintGen(CorrectAns);
    while (Turns < 12){
        UserInput[Turns].ColourInput = InputAns();
        string colours = UserInput[Turns].ColourInput;
        PrintInt(UserInput,colours,Turns);
        UserInput[Turns].hints = ProcessAns(UserInput,CorrectAns,Turns);
        string hints = UserInput[Turns].hints;
        CurrentPos(UserInput,hints,colours);
        if (hints == "WIN"){
            break;
        }
        Turns++;
    }
}

static void PrintGen(string[] CorrectAns){
    for (int i = 0; i < CorrectAns.Length; i++){
        Console.Write($"{i+1}" + "|" + CorrectAns[i] + "|");
        Console.WriteLine("");
    }
}

static void PrintInt((string ColourInput, string hints)[]UserInput, string Colour,int Turns){
    Console.Write($"{Turns+1}" + "|" + Colour + "|");
    Console.WriteLine("");
}
static string InputAns(){
    Console.WriteLine("Enter a guess: (eg:red,yellow,blue,green):");
    string ans = Console.ReadLine();
    return ans;
}

static string[] GenAns(){
    string[] Colour = {"red","yellow","blue","green","purple","orange","black","white"};
    string[] CorrectAns = new string[4];
    Random r = new Random();
    for (int n = 0; n < CorrectAns.Length; n++){
        int i = r.Next(7);
        CorrectAns[n] = Colour[i];
    }
    return CorrectAns;
}

static string ProcessAns((string ColourInput, string hints)[] UserInput, string[] CorrectAns, int Turns){
    string[] hints = new string[4];
    string[] ciarray = UserInput[Turns].ColourInput.Split(",");
    int whitePegsCount = 0;
    int redPegsCount = 0;
    for (int i = 0; i < 4; i++){
        if (ciarray[i] == CorrectAns[i]){
            hints[i] = "white";
            whitePegsCount++;
        }
        else if (Array.Exists(CorrectAns, element => element == ciarray[i])){
            hints[i] = "red";
            redPegsCount++;
        }else{
            hints[i] = "nothing";
        }
    }
    string jointhint;
    Console.WriteLine("White Pegs: " + whitePegsCount);
    Console.WriteLine("Red Pegs: " + redPegsCount);
    if (whitePegsCount == 4){
        Console.WriteLine("Congratulations!");
        jointhint = "WIN";
    }else{
        Console.WriteLine("Wrong guess");
        jointhint = string.Join(",",hints);
    }
    return jointhint;
}

static void CurrentPos((string ColourInput, string hints)[]UserInput, string hints, string Colour){
    Console.WriteLine("|" + Colour + "|");
    Console.WriteLine("|" + hints + "|");
}
}
}
