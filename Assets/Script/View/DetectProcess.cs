using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public partial class DetectProcess : BaseUI
{
    List<DetectProcessInfo> detectProcessInfoList = new List<DetectProcessInfo>();
    List<Toggle> sampleItemList = new List<Toggle>();

    void Start()
    {
        _LoadUI();
        detectProcessItem.SetActive(false);
        for (int i = 0; i < 3; i++)
        {
            GameObject item = Instantiate(detectProcessItem, detectProcessItem.transform.parent);
            detectProcessItem.SetActive(true);
            DetectProcessInfo info = item.GetComponent<DetectProcessInfo>();
            info.GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
            {
                if (_isOn)
                {
                    foreach (var item in sampleItemList)
                    {
                        item.isOn = Random.Range(1, 10) > 7;
                    }
                }
            });
            detectProcessInfoList.Add(info);
        }
        float contentHeight = (detectProcessInfoList.Count - 1) * (detectProcessContent_VerticalLayoutGroup.spacing + 102) + 320;
        detectProcessContent_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);

        foreach (Transform item in sampleCol_Transform)
        {
            sampleItemList.Add(item.GetComponent<Toggle>());
        }

        Timer.Ins.SetTimeOut(() =>
        {
            detectProcessInfoList.First().GetComponent<Toggle>().isOn = true;
        }, 0.5f);

    }
}
