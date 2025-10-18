using UnityEngine;

public class RedImpactor : ImpactorBase
{
    [SerializeField] private GameLogic _gameLogic;

    protected override void Impact()
    {
        _gameLogic.Loss();
    }
}