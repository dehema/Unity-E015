using DG.Tweening;
using DotLiquid.Util;
using System;
using UnityEngine;
using UnityEngine.UI;

public enum DetectProcessStatus
{
    //�ȴ��ύ
    WaitSubmit,
    //���ύ
    Submit,
    //�ȴ����
    WaitDetect,
    //�����
    Detect,
    //������
    CompleteDetect,
}

public class DetectProcessInfo
{
    public string scheduleID = "�����Ŀ";
    public string detectProject = "HPV";
    public int slotNum = 2;
    public DetectProcessStatus status;
    public DateTime createTime;
    public DateTime estimateStartTime;
    public int estimateDuration;

    public DetectProcessInfo()
    {
        createTime = DateTime.Now;
        estimateStartTime = DateTime.Now.AddMinutes(30);
        estimateDuration = 120;
    }
}

public partial class DetectProcessTab : BaseUI
{
    VerticalLayoutGroup verticalLayout;
    DetectProcessInfo info = new DetectProcessInfo();

    public void init()
    {
        _LoadUI();
        verticalLayout = transform.parent.GetComponent<VerticalLayoutGroup>();
        Toggle toggle = GetComponent<Toggle>();
        toggle.group = transform.parent.GetComponent<ToggleGroup>();
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 102);
        processIDParent_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 495);
        sampleSlot.SetActive(false);
        detectProjectParent_Rect.anchoredPosition = new Vector2(566, -30);
        toggle.onValueChanged.AddListener((bool _isOn) =>
        {
            Tweener tweener = rect.DOSizeDelta(new Vector2(rect.rect.width, _isOn ? 380 : 102), 0.2f);
            tweener.OnUpdate(() =>
            {
                LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)transform.parent);
            });
            sampleSlot.SetActive(_isOn);
            processIDParent_Rect.DOSizeDelta(new Vector2(_isOn ? 640 : 495, processIDParent_Rect.rect.height), 0.2f);
            detectProjectParent_Rect.anchoredPosition = _isOn ? new Vector2(30, -100) : new Vector2(566, -30);
        });

        slotsNum_TextMeshProUGUI.text = info.slotNum.ToString();
        for (int i = 1; i <= info.slotNum; i++)
        {
            Transform trans = sampleSlot.transform.Find("col_1/Image_" + i);
            trans.GetComponent<Image>().sprite = Resources.Load<Sprite>("Art/Icon/Բ��");
        }
        startTime_TextMeshProUGUI.text = info.estimateStartTime.ToString("yyyy-MM-dd hh:mm:ss");
        createTime_TextMeshProUGUI.text = info.createTime.ToString("yyyy-MM-dd hh:mm:ss");
        endTime_TextMeshProUGUI.text = info.estimateDuration + "Min";
        detail_Button.onClick.AddListener(() => { UIMgr.Ins.OpenView<DetectProcessDetailDialog>(); });
    }
}
