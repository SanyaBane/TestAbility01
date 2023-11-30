using TestAbility01.AbilitySystem;

namespace TestAbility01.Game;

public static class AbilityBehavioursFactory
{
  public static AbilityBehaviour CreateBehaviour(string behaviourId)
  {
    switch (behaviourId)
    {
      case "Damage":
        return new DirectDamage();
      default:
        throw new NotSupportedException();
    }
  }
}