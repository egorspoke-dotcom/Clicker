using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ImpactorBase : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Impact();
    }

    protected virtual void Impact()
    {

    }
}