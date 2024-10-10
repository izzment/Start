// Use this folder to implement your solution to the challenge
DateTime result;

// Prompt the user to enter a date or type "exit" to quit the program
while (true){
    Console.WriteLine("Please enter a date or type 'exit' to quit the program: ");
    
    string userInput = Console.ReadLine();

//Parse the entered date and check if it is valid
    if (userInput.ToLower() == 'exit'){
        Environment.Exit(0);
    }
    else {

        if (DateTime.TryParse(userInput, out result)){
            Console.WriteLine($"{userInput, -25} can be parsed as: {result}");
        }
        else {
            Console.WriteLine($"Could not parse '{userInput}'");
        }

// Compare the entered date with the current date to determine if it is in the past, present, or future.
        DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
        dt = dt:d
        int res = DateTime.Compare(dt, result);

// Display the appropriate message based on the comparison
        if (res < 0){
            Console.WriteLine("The entered date is in the future");
        } else if (res = 0){
            Console.WriteLine("The entered date is in the present");
        } else {
            Console.WriteLine("The entered date is in the past");
        }

    }

}



// Handle invalid date inputs gracefully by showing an error message

// The program should loop until the user decides to exit