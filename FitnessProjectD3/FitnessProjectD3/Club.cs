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
     *
     *  What Club needs Method wise ************
     *
     *  AddMember(SingleCLub member) { };
     *  AddMember(MultiClub member) { };
     *
     *  RemoveMember(SingleClub member) { };
     *  RemoveMember(MultiClub member) { };
     *
     *  This Method takes in a member and a club to list the information for the member of said club
     *  ListMemberInformation(Member member, Club club) { };   // Not super convinced we need both of these methods 
     *  ListAllMemberInformation() { }; 
     *
     *  
     *  This Method takes a member of type Member and checks to see if they are a member of the entered club
     *  CheckMember(Member member, Club club) { };             // It says call the CheckIn method, and I am not super sure as to what that means 
     *
     *
     *  This Method takes a member a generates a list of their fees (likely how )
     *  GenerateFees(Member member) { };                       // Maybe inside of this method there is an if method which adds membership points
     *                                                         // to the output if the selected member is a type of MultiClub member
     * 
     */
    
    private string _name;
    private string  _address;
    private List<Member> _members = new List<Member>();

    public string Name { get { return _name; } set { _name = value; } }
    public string Address { get { return _address; } set { _address = value; } }

    public Club(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void AddMember(Member member)
    {
        _members.Add(member);
    }

    public void CheckIn(Member member)
    {
        if (_members.Contains(member))
        {
            member._isCheckedIn = true;
        }
    }

    public void CheckOut(Member member)
    {
        if (member._isCheckedIn == true)
        {
            member._isCheckedIn = false;
        }
    }
}