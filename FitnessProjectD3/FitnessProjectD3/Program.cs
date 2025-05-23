namespace FitnessProjectD3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------Start Program------------------------");
<<<<<<< HEAD
=======
        
        //We need to make the club member
        // Get name and set checked in to false
>>>>>>> 78a2c279a8b1b033a14b2c86485648943e7f7e8c
        
        //Create list of clubs in program or have the list exist in the club class
        List<Club> clubList = new List<Club>();
        clubList.Add(new Club("Club 1", "1234567890"));
        clubList.Add(new Club("Club 2", "1234567890"));
        clubList.Add(new Club("Club 3", "1234567890"));
        clubList.Add(new Club("Club 4", "1234567890"));
        //Show list of clubs
        foreach (var club in clubList)
        {
            Console.WriteLine(club.Name);
        }
        Console.WriteLine(clubList);
        
        //Ask the user if they want to select a club
        Console.WriteLine("What club would you like to select?");
        string clubName = (Console.ReadLine().ToUpper());
        
        
        //Ask the user if they want to chekin
        //Make a list for the club the lets you add a member
        //add the member to clubName list
        //Set checked in to true
        
        //Ask user if they want to select a club
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("---------------------------End Program--------------------------");
    }
}