using System;
using System.Xml;
namespace HelloWorld { 
class Program { 
    string UserInput;
    static void Main(){ 
    int Turns = 0;
    //Generating the correct answer
    string[]CorrectAns = GenAns();
    while (Turns < 12){
        InputAns();
        ProcessAns();

    }
}

static string[] InputAns(){
    string[] ans = new string[3];
    for (int i = 0, i > 3; i++){
        Console.Write($"Enter the {i+1} guess");
        ans[i] = Console.ReadLine();
    }
    return ans;
}

static string[] GenAns(){
    string[] CorrectAns = new string[3];
    return CorrectAns;
}

static string[] ProcessAns(){
    
    return;
}

static string CurrentPos(){
    return;
}
} 
}

