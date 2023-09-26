using System;
using System.Text.RegularExpressions;
using System.Xml;
namespace HelloWorld { 
class Program { 
    static void Main(){ 
    (string[] ColourInput, string[] hints)[]UserInput = new (string[], string[])[11];
    int Turns = 1;
    //Generating the correct answer
    string[]CorrectAns = GenAns();
    while (Turns < 13){
        string[] colours = UserInput[Turns].ColourInput;
        string[] hints = UserInput[Turns].hints;
        colours = InputAns();
        //CurrentPos(UserInput,Turns);
        hints = ProcessAns(UserInput,CorrectAns,Turns);
        Console.WriteLine(Match(hints));
        Turns++;
    }
}

static string[] InputAns(){
    string[] ans = new string[3];
    for (int i = 0; i < 3; i++){
        Console.Write($"Enter the {i+1} guess");
        ans[i] = Console.ReadLine();
    }
    return ans;
}

static string[] GenAns(){
    string[] Colour = {"red","yellow","blue","green","purple","orange","black","white"};
    string[] CorrectAns = new string[3];
    Random r = new Random();
    int i = r.Next(7);
    for (int n = 0; n < 3; n++){
        CorrectAns[n] = Colour[i];
    }
    return CorrectAns;
}

static string[] ProcessAns((string[] ColourInput, string[] hints)[]UserInput, string[] CorrectAns,int Turns){
    int Match = 0;
    string[] colour = UserInput[Turns].ColourInput;
    string[] hints = UserInput[Turns].hints;
    
    for (int i = 0; i < 3;i++){
        if (colour[i] == CorrectAns[i]){
            hints[i] = "white";
        }else if (CorrectAns.Contains(colour[i])){
            hints[i] = "red";
        }else{
            hints[i] = "nothing";
        }
    }
    return hints;
    }

static string CurrentPos((string[] ColourInput, string[] hints)[]UserInput, int Turns){
    for (int i = 0; i < Turns; i++){
        
    }
    return;
}

static string Match(string[] hints){
    if (hints[0] == "white" & hints[1] == "white" & hints[2] == "white" & hints[3] == "white"){
            return "Wrong";
        }else{
            return "Correct";
        }
}
} 
}

