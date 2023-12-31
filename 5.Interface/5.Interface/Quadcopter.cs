using System.Text;

namespace _5.Interface;

public class Quadcopter : IFlyingRobot, IChargeable
{
    private readonly List<string> _components = new() {"rotor1", "rotor2", "rotor3", "rotor4"};
    
    public List<string> GetComponents()
    {
        return _components;
    }
    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged!");
    }

    public string GetInfo()
    {
        var strInfo = new StringBuilder();
        strInfo.Append($"Count Rotor: {_components.Count}\n");
        foreach (var component in _components)
        {
            strInfo.Append($"- {component}\n");
        }

        return strInfo.ToString();
    }

    public string GetRobotType()
    {
        return $"{nameof(Quadcopter)}";
    }
}
