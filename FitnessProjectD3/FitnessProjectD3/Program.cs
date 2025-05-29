namespace FitnessProjectD3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------------------------Start Program------------------------");
        
        //We need to make the club member
        // Get name and set checked in to false
        //Create list of clubs in program or have the list exist in the club class
        List<Club> clubList = new List<Club>();
        clubList.Add(new Club("Club 1", "1234567890"));
        clubList.Add(new Club("Club 2", "1234567890"));
        clubList.Add(new Club("Club 3", "1234567890"));
        clubList.Add(new Club("Club 4", "1234567890"));
        clubList.Add(new Club("Club 5", "1234567890"));
        clubList.Add(new Club("Club 6", "1234567890"));
        clubList.Add(new Club("Club 7", "1234567890"));
        clubList.Add(new Club("Club 8", "1234567890"));
        clubList.Add(new Club("Club 9", "1234567890"));
        
        //Create single club members
        SingleClubMember frank = new SingleClubMember(clubList[0].Name, 1, "Frank", 15);
        SingleClubMember jay = new SingleClubMember(clubList[1].Name, 2, "Jay", 15, true);
        
        //Create multi club members
        MultiClubMember kay = new MultiClubMember(clubList[0], 1, "Kay", 25);
        MultiClubMember jess = new MultiClubMember(clubList[1], 2, "Jess", 25, true);
        
        //Show list of clubs
        for(int i = 0; i < clubList.Count; i++)
        {
            Console.WriteLine($"{i}: {clubList[i].Name}");
        }
        
        
        // Add members to club
        clubList[0].AddMember(frank);
        clubList[1].AddMember(jay);
        clubList[0].AddMember(kay);
        clubList[1].AddMember(jess);
        
        //Checkin members
        frank.CheckIn(clubList[0]);
        jay.CheckIn(clubList[1]);
        kay.CheckIn(clubList[0]);
        jess.CheckIn(clubList[1]);
      
        clubList[0].CheckIn(frank);
        clubList[1].CheckIn(jay);
        clubList[0].CheckIn(kay);
        clubList[1].CheckIn(jess);
        
        //Check if member is in club
        clubList[0].CheckMember(frank);
        clubList[1].CheckMember(jay);
        clubList[0].CheckMember(kay);
        clubList[1].CheckMember(jess);
        
        
        //Generate fees and points
        
        //Check members out of club
        clubList[0].CheckOut(frank);
        clubList[1].CheckOut(jay);
        clubList[0].CheckOut(kay);
        clubList[1].CheckOut(jess);
        
        
        //Ask the user if they want to select a club
        Console.WriteLine("What club number would you like to select?");
        int clubChoice = (int.Parse(Console.ReadLine()));

        //Check member into that selection
        kay.CheckIn(clubList[clubChoice]);

        //Ask the user if they want to chekin
        //Make a list for the club the lets you add a member
        //add the member to clubName list
        //Set checked in to true

        //Ask user if they want to select a club

        /*
        SingleClubMember aSingleClubMember = new SingleClubMember(clubList[0].Name, 2, "Kay", 15);
        SingleClubMember aSingleClubMember2 = new SingleClubMember(clubList[1].Name, 3, "Jay", 15, true);
        Console.WriteLine(aSingleClubMember);
        Console.WriteLine(aSingleClubMember2);
        */
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("---------------------------End Program--------------------------");
    }
}