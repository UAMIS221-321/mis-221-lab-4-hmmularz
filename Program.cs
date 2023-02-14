Console.WriteLine("Enter a menu choice: 1 is full, 2 is partial, 3 to exit");
int userChoice = int.Parse(Console.ReadLine()); //making it read an int instead of string

while( userChoice != 3){
    if( userChoice == 1){
        GetFull();
    }

    else if( userChoice == 2){
        GetPartial();
    }

    else
        Console.WriteLine("Invalid Option");
Console.WriteLine("Enter a menu choice: 1 is full, 2 is partial, 3 to exit");
userChoice = int.Parse(Console.ReadLine()); //update read 
}

Console.WriteLine("You have exited the program");



static void GetFull(){
    Random rnd = new Random();
    int number = rnd.Next(3,10); //need to do one higher than 9 
    for( int i =0; i < number; i++){ //initalize, check the condition, 
         //won't actually need this for submission but to help me test
        for(int j = 0; j <= i; j++){
            Console.Write("O"); //write makes it print on the same one line 
        }
        Console.WriteLine("");
    } 

}


static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3,10); //need to do one higher than 9 
    for( int i =0; i < number; i++){ //initalize, check the condition, 
         //won't actually need this for submission but to help me test
        for(int j = 0; j <= i; j++){
            if(rnd.Next(3,10) == number)
                Console.Write(" "); //write makes it print on the same one line 
            else{
                Console.Write("O");
            }
    
            
        }
        Console.WriteLine("");
    } 

}

