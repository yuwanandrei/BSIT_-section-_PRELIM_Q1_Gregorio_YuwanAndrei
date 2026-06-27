namespace TransportChallenge;

public class Submarine : Vehicle, ISailable
{
    public override string Move()
    {
        return "Sailing on the water.";
    }
}