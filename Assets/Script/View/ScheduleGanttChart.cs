using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class ScheduleGanttChart : BaseUI
{
    public List<ScheduleItem> scheduleItemList = new List<ScheduleItem>();
    List<TextMeshProUGUI> timeList = new List<TextMeshProUGUI>();
    List<DateTime> dateTimeList = new List<DateTime>();
    const float lineWidth = 2;
    const int itemSlotNum = 10;
    int lineNum;
    //每30分钟宽度
    float itemSlotWidth;
    float scheduleItemHeight = 60;
    DateTime startTime;
    DateTime endTime;

    void Start()
    {
        _LoadUI();
        scheduleItem.SetActive(false);
        scheduleItemHeight = scheduleItem_Rect.rect.height;
        lineNum = itemSlotNum - 1;
        itemSlotWidth = (title_Rect.rect.width - lineNum * lineWidth) / itemSlotNum;
        DateTime now = DateTime.Now;
        int min = now.Minute % 30;
        now = now.AddMinutes(-min);
        timeList.Add(time1_TextMeshProUGUI);
        timeList.Add(time2_TextMeshProUGUI);
        timeList.Add(time3_TextMeshProUGUI);
        timeList.Add(time4_TextMeshProUGUI);
        timeList.Add(time5_TextMeshProUGUI);
        timeList.Add(time6_TextMeshProUGUI);
        timeList.Add(time7_TextMeshProUGUI);
        timeList.Add(time8_TextMeshProUGUI);
        timeList.Add(time9_TextMeshProUGUI);
        timeList.Add(time10_TextMeshProUGUI);
        for (int i = 0; i < timeList.Count; i++)
        {
            dateTimeList.Add(now.AddMinutes(-30 + i * 30));
            timeList[i].SetText(dateTimeList[i].ToString("hh:mm"));
        }
        startTime = dateTimeList.First();
        endTime = dateTimeList.Last();
        legend_Button.onClick.AddListener(() => { UIMgr.Ins.OpenView<DetectProcessLegendDialog>(); });
    }

    //计划对象宽度
    public float getScheduleItemWidth(float _minute)
    {
        float s = _minute / 30;
        float width = s * itemSlotWidth;
        width += (s - 1) * lineWidth;
        return width;
    }

    public void createScheduleInfo(DetectProcessInfo _info)
    {
        GameObject item = Instantiate<GameObject>(scheduleItem, scheduleItem.transform.parent);
        item.SetActive(true);
        ScheduleItem schedule = item.GetComponent<ScheduleItem>();
        schedule.init(_info);
        schedule.toggle_Toggle.group = scheduleIParent_ToggleGroup;
        schedule.toggle_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            if (_ison)
            {
                onScheduleItemClick(_info);
            }
        });
        int index = scheduleItemList.Count;
        scheduleItemList.Add(schedule);
        RectTransform rect = item.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(getScheduleItemPosX(_info, rect), -5 - (5 + scheduleItemHeight) * index);
    }

    public void onScheduleItemClick(DetectProcessInfo _info)
    {

    }

    public float getScheduleItemPosX(DetectProcessInfo _info, RectTransform _rect)
    {
        if (_info.status == DetectProcessStatus.Detect)
        {
            double min = (DateTime.Now - startTime).TotalMinutes;
            double width = itemSlotWidth * (min / 30f);
            float posX = (float)width;
            return posX;
        }
        else
        {
            return scheduleIParent_Rect.rect.width - _rect.rect.width;
        }
    }
}
