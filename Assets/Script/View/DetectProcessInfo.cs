using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public partial class DetectProcessInfo : BaseUI
{
    VerticalLayoutGroup verticalLayout;
    void Start()
    {
        verticalLayout = transform.parent.GetComponent<VerticalLayoutGroup>();
        Toggle toggle = GetComponent<Toggle>();
        toggle.group = transform.parent.GetComponent<ToggleGroup>();
        toggle.onValueChanged.AddListener((bool _isOn) =>
        {
            Tweener tweener = rect.DOSizeDelta(new Vector2(rect.rect.width, _isOn ? 320 : 102), 0.2f);
            tweener.OnUpdate(() =>
            {
                LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)transform.parent);
            });
        });
    }
}
