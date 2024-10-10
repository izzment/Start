
// Use this folder to implement your solution to the challenge
DateTime result;
String userInput;
int totalDays;

// Prompt the user to enter a date or type "exit" to quit the program
while (true){
    Console.WriteLine("Please enter a date or type 'exit' to quit the program: ");
    userInput = Console.ReadLine();

//Parse the entered date and check if it is valid
    if (userInput.ToLower() == "exit"){
        Environment.Exit(0);
    }
    else {

        if (DateTime.TryParse(userInput, out result)){
            Console.WriteLine($"{userInput} can be parsed as: {result}");

// Compare the entered date with the current date to determine if it is in the past, present, or future.
        DateTime dt = DateTime.Now;
        int res = DateTime.Compare(dt, result);

// Display the appropriate message based on the comparison
        if (res < 0){
            totalDays = (int)(result - dt).TotalDays;
            Console.WriteLine($"The entered date is {totalDays} days in the future");
        } else if (res == 0){
            Console.WriteLine("The entered date is in the present");
        } else {
            totalDays = (int)(dt - result).TotalDays;
            Console.WriteLine($"The entered date is {totalDays} days in the past");
        }
        }
        else {
            Console.WriteLine($"Could not parse '{userInput}'");
        }

    }

}



// Handle invalid date inputs gracefully by showing an error message

// The program should loop until the user decides to exit