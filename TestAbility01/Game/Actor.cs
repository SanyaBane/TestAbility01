using TestAbility01.Game.Abstractions.Interfaces;

namespace TestAbility01.Game;

public class Actor : IActor
{
  public Actor(string name)
  {
    Name = name;
  }

  public string Name { get; }
}