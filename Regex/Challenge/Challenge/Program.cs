using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Dynamic;

const int MAX_REGEX_TIME = 1000;




static void ReverseDateFormat(String s){
    DateTime result;
    Stopwatch sw;

    TimeSpan Timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);
    
    
    if (DateTime.TryParse(s, out result)){
        string datestr = result.ToString();

        try {
            sw = Stopwatch.StartNew();
            string backwardsBob = "";
            Regex DateInput = new Regex(@"\d{1,2}\/\d{1,2}\/\d{2,4}", RegexOptions.None, Timeout);
            

            MatchCollection mc = DateInput.Matches(datestr);
            foreach(Match m in mc){
                string bob = m.ToString();
                for(int i = bob.Length-1; i >= 0; i--){
                    backwardsBob += bob[i];
                }
                Console.WriteLine($"Your date is {bob}");
                Console.WriteLine($"Your reversed date is {backwardsBob}");
            }
            sw.Stop(); 
        }
        catch (RegexMatchTimeoutException e){
            Console.WriteLine($"The Regex took too long to execute {e.MatchTimeout}");
        }
    }
    else{
        Console.WriteLine("Sorry, not a date. Please try again"); 
    }
}

String userInput;

while (true){
    Console.WriteLine("Please enter a date to be reversed or 'exit' to close this program:");
    userInput = Console.ReadLine();
    
    if (userInput == "exit"){
        Environment.Exit(0);
    } else{
        ReverseDateFormat(userInput);
    }
}

