using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using Coffee.UIEffects;

public class MenuToggleItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Toggle toggle;
    Image icon;
    UIShadow shadow;
    float alpha;
    Color color;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        icon = toggle.image;
        shadow = icon.GetComponent<UIShadow>();
        if (shadow != null)
            color = shadow.effectColor;
    }

    void Update()
    {
        if (shadow != null)
        {
            color.a = alpha;
            shadow.effectColor = color;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (shadow != null)
        {
            alpha = shadow.effectColor.a;
            DOTween.To(() => alpha, x => alpha = x, 0.5f, 0.5f);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (shadow != null)
        {
            alpha = shadow.effectColor.a;
            DOTween.To(() => alpha, x => alpha = x, 0, 0.5f);
        }
    }
}
