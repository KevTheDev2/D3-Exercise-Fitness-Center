namespace FitnessProjectD3;

public abstract class Member
{
    public int _id { get; set; }
    public string _name { get; set; }
    public bool _isCheckedIn { get; set; }
    
    
    public abstract void CheckIn(Club club);
}