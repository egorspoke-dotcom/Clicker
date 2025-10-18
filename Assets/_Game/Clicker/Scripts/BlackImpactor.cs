using UnityEngine;

public class BlackImpactor : ImpactorBase
{
    [SerializeField] private BlackModificator _modificator;
    [SerializeField] private GameLogic _logic;

    protected override void Impact()
    {
        _modificator.DecreseSize();
        _modificator.Dublicate();
        _modificator.AddSpeed();
        _logic.AddScore();
    }
}
