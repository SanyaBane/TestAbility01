using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.Game;

public static class AbilityBehavioursFactory
{
  public static IAbilityBehaviour CreateBehaviour(string behaviourId)
  {
    switch (behaviourId)
    {
      case "Damage":
        return new DirectDamage("damage");
      default:
        throw new NotSupportedException();
    }
  }
}