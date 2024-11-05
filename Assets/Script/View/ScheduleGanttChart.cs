using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

struct ScheduleInfo
{
    public string scheduleName;
    public float duration;
    public string detectProject;

    public ScheduleInfo()
    {
        scheduleName = "¼ì²âÏîÄ¿";
    }
}


public partial class ScheduleGanttChart : BaseUI
{
    List<TextMeshProUGUI> timeList = new List<TextMeshProUGUI>();
    const float lineWidth = 2;
    const int itemSlotNum = 7;
    int lineNum;
    float itemSlotWidth;
    const float scheduleItemHeight = 60;

    void Start()
    {
        _LoadUI();
        lineNum = itemSlotNum - 1;
        itemSlotWidth = (title_Rect.rect.width - lineNum * lineWidth) / itemSlotNum;
        timeList.Add(time1_TextMeshProUGUI);
        timeList.Add(time2_TextMeshProUGUI);
        timeList.Add(time3_TextMeshProUGUI);
        timeList.Add(time4_TextMeshProUGUI);
        timeList.Add(time5_TextMeshProUGUI);
        timeList.Add(time6_TextMeshProUGUI);
        timeList.Add(time7_TextMeshProUGUI);
        timeList.Add(time8_TextMeshProUGUI);



    }
}
