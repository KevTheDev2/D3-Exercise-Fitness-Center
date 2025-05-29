namespace FitnessProjectD3;

public abstract class Member
{
    /********************************************
     * Member variables
     ********************************************/
    public int _id { get; set; }//A generate id method should be in the ctr for singleclub and multiclub
    public string _name { get; set; }
    public bool _isCheckedIn { get; set; }
    public int _membershipPoints { get; set; }
    public double _monthlyFee { get; set; } //SingleClub and MultiClub should set a default fee
    
    //The club class will be able to add that fee to the member

    public Member (int theId, String theName, double theMonthlyFee)
    {
        _id = theId;
        _name = theName;
        _monthlyFee = theMonthlyFee;
        _isCheckedIn = false;
        _membershipPoints = 0;

    }
    // Contructor to allow member a checkin at sign up
    public Member(int theId, String theName, double theMonthlyFee, bool isCheckedIn)
    {
        _id = theId;
        _name = theName;
        _monthlyFee = theMonthlyFee;
        _isCheckedIn = isCheckedIn;
        _membershipPoints = 0;

    }
    /********************************************
     * Member Method
     ********************************************/
    public abstract void CheckIn(Club club);
}