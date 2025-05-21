namespace FitnessProjectD3;

public abstract class Member
{
    private int _id { get; set; }
    private string _name { get; set; }

    Member(string name)
    {
        _id = _id.GetHashCode();
        _name = name;
    }
    
  //  public abstract void CheckIn(Club club);
}