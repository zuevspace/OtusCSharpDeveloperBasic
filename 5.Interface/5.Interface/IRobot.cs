namespace _5.Interface;

public interface IRobot
{
    public string GetInfo()
    {
        throw new Exception();
    }
    
    public List<string> GetComponents()
    {
        throw new Exception();
    }

    public string GetRobotType()
    {
        return "I am a simple robot.";
    }
    
}