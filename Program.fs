// For more information see https://aka.ms/fsharp-console-apps
//program written by Lauren Lira
//Takes a user input number and prints out Fibonacci sequence list up the list item right after input
//Fibonacci sequence is when the previous number is added to the number before it
//To get a new number to add on a list
//Then, the new number becomes the previous number, and the previous number
//becomes the number before it

let fibSequence =
    //Function named
    let mutable startNum = 0
    //Number before the last item on the list
    let mutable prevNum = 1
    //last item added to list
    let mutable currentNum = 1
    //new item to be added to list
    //Mutable variables defined, they cannot be changed
    printfn"Hi! I am a fibonacci sequence generator :)"
    printfn "Enter a whole number you want the Fibonacci sequence to print out to"
    //Prompts user to enter the number they want the list to lead to
    let userNum = System.Console.ReadLine() |> int
    //System will read user input as an integer
    while currentNum < userNum  do
        //While loop runs while the current list item is less than the user input
        currentNum <- startNum + prevNum
        //adds previous number used and the number before it to get the current number
        //creates list up until the number right after user input
        printfn "%A" currentNum
        //Printout of result to add to list
        prevNum <- startNum
        //Assigns value of the number before it to previous number
        startNum<- currentNum
        //assigns the current number value to the previous number variable
        //this keeps the list going

