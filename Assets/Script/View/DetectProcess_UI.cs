using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DetectProcess : BaseUI
{
    [HideInInspector]
    public GameObject scheduleGanttChart;
    [HideInInspector]
    public ScheduleGanttChart scheduleGanttChart_ScheduleGanttChart;
    [HideInInspector]
    public GameObject processInfoParent;
    [HideInInspector]
    public ScrollRect processInfoParent_ScrollRect;
    [HideInInspector]
    public GameObject detectProcessContent;
    [HideInInspector]
    public RectTransform detectProcessContent_Rect;
    [HideInInspector]
    public VerticalLayoutGroup detectProcessContent_VerticalLayoutGroup;
    [HideInInspector]
    public GameObject detectProcessItem;

    internal void _LoadUI()    
    {
        scheduleGanttChart = transform.Find("$scheduleGanttChart#ScheduleGanttChart").gameObject;
        scheduleGanttChart_ScheduleGanttChart = scheduleGanttChart.GetComponent<ScheduleGanttChart>();
        processInfoParent = transform.Find("right/$processInfoParent#ScrollRect").gameObject;
        processInfoParent_ScrollRect = processInfoParent.GetComponent<ScrollRect>();
        detectProcessContent = transform.Find("right/$processInfoParent#ScrollRect/Viewport/$detectProcessContent#Rect,VerticalLayoutGroup").gameObject;
        detectProcessContent_Rect = detectProcessContent.GetComponent<RectTransform>();
        detectProcessContent_VerticalLayoutGroup = detectProcessContent.GetComponent<VerticalLayoutGroup>();
        detectProcessItem = transform.Find("right/$processInfoParent#ScrollRect/Viewport/$detectProcessContent#Rect,VerticalLayoutGroup/$detectProcessItem").gameObject;
    }
}