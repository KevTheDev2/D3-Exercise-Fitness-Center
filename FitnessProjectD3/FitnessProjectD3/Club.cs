namespace FitnessProjectD3;

public class Club
{
    /*
     *
     * private string _name;
     * private string _address;
     *
     *       *** OR ***
     *
     * public string Name {get; set;}
     * public string Address {get; set;}
     *
     * (If price of the club is in the club class)
     * (private double _price;)
     * (public double Price {get; set;})
     *
     *
     *  When adding single club members to a club it adds it to this list and stores it there
     *  When the CheckIn method is called under Members it checks to see which List<SingleClub> they belong to ?
     *   - I'm not completely sure if you are allowed to check to see if you are a member of a List of another class
     *
     *  Alternate solutions
     *   - When you call the singleClub ctor you give a club as a parameter
     *   - So when you call the CheckIn() method it checks to see if the parameter you enter matches the Club from the
     *     ctor
     * 
     * A List<SingleClub> singleMembers = new List<SingleClub>();
     * 
     *
     *  idk man ;(
     */
    
    private string _name;
    private string  _address;

    public string Name { get { return _name; } set { _name = value; } }
    public string Address { get { return _address; } set { _address = value; } }

    public Club(string name, string address)
    {
        Name = name;
        Address = address;
    }
    
    
}