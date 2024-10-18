using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuContentLeftLeft2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    RectTransform rect;

    private void OnEnable()
    {
        if (rect == null)
        {
            rect = GetComponent<RectTransform>();
        }
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 55);
    }

    private void OnDisable()
    {
        rect.DOKill();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rect.DOSizeDelta(new Vector2(140, rect.rect.height), 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rect.DOSizeDelta(new Vector2(55, rect.rect.height), 0.3f);
    }
}
