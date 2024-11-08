using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public partial class DetectProcess : BaseUI
{
    List<DetectProcessTab> detectProcessInfoList = new List<DetectProcessTab>();
    TimerHandler timerHandler;

    void Start()
    {
        _LoadUI();
        detectProcessItem.SetActive(false);
        for (int i = 0; i < 3; i++)
        {
            GameObject item = Instantiate(detectProcessItem, detectProcessItem.transform.parent);
            item.SetActive(true);
            DetectProcessTab tab = item.GetComponent<DetectProcessTab>();
            tab.init();
            tab.GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
            {
                tab.submit_Button.onClick.AddListener(() =>
                {
                    DetectProcessInfo info = new DetectProcessInfo();
                    info.status = scheduleGanttChart_ScheduleGanttChart.scheduleItemList.Count == 0 ? DetectProcessStatus.Detect : DetectProcessStatus.WaitDetect;
                    scheduleGanttChart_ScheduleGanttChart.createScheduleInfo(info);
                    detectProcessInfoList.Remove(tab);
                    Destroy(item);
                });
            });
            detectProcessInfoList.Add(tab);
        }
        float contentHeight = (detectProcessInfoList.Count - 1) * (detectProcessContent_VerticalLayoutGroup.spacing + 102) + 380;
        detectProcessContent_Rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);

        timerHandler = Timer.Ins.SetTimeOut(() =>
        {
            detectProcessInfoList.First().GetComponent<Toggle>().isOn = true;
        }, 0.5f);
    }

    private void OnDestroy()
    {
        timerHandler.Remove();
    }
}
