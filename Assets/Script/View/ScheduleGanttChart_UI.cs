using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class ScheduleGanttChart : BaseUI
{
    [HideInInspector]
    public GameObject title;
    [HideInInspector]
    public RectTransform title_Rect;
    [HideInInspector]
    public GameObject time1;
    [HideInInspector]
    public TextMeshProUGUI time1_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time2;
    [HideInInspector]
    public TextMeshProUGUI time2_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time3;
    [HideInInspector]
    public TextMeshProUGUI time3_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time4;
    [HideInInspector]
    public TextMeshProUGUI time4_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time5;
    [HideInInspector]
    public TextMeshProUGUI time5_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time6;
    [HideInInspector]
    public TextMeshProUGUI time6_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time7;
    [HideInInspector]
    public TextMeshProUGUI time7_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time8;
    [HideInInspector]
    public TextMeshProUGUI time8_TextMeshProUGUI;
    [HideInInspector]
    public GameObject ver;
    [HideInInspector]
    public VerticalLayoutGroup ver_VerticalLayoutGroup;
    [HideInInspector]
    public GameObject scheduleItem;

    internal void _LoadUI()    
    {
        title = transform.Find("$title#Rect").gameObject;
        title_Rect = title.GetComponent<RectTransform>();
        time1 = transform.Find("$title#Rect/hor/$time1#TextMeshProUGUI").gameObject;
        time1_TextMeshProUGUI = time1.GetComponent<TextMeshProUGUI>();
        time2 = transform.Find("$title#Rect/hor/$time2#TextMeshProUGUI").gameObject;
        time2_TextMeshProUGUI = time2.GetComponent<TextMeshProUGUI>();
        time3 = transform.Find("$title#Rect/hor/$time3#TextMeshProUGUI").gameObject;
        time3_TextMeshProUGUI = time3.GetComponent<TextMeshProUGUI>();
        time4 = transform.Find("$title#Rect/hor/$time4#TextMeshProUGUI").gameObject;
        time4_TextMeshProUGUI = time4.GetComponent<TextMeshProUGUI>();
        time5 = transform.Find("$title#Rect/hor/$time5#TextMeshProUGUI").gameObject;
        time5_TextMeshProUGUI = time5.GetComponent<TextMeshProUGUI>();
        time6 = transform.Find("$title#Rect/hor/$time6#TextMeshProUGUI").gameObject;
        time6_TextMeshProUGUI = time6.GetComponent<TextMeshProUGUI>();
        time7 = transform.Find("$title#Rect/hor/$time7#TextMeshProUGUI").gameObject;
        time7_TextMeshProUGUI = time7.GetComponent<TextMeshProUGUI>();
        time8 = transform.Find("$title#Rect/hor/$time8#TextMeshProUGUI").gameObject;
        time8_TextMeshProUGUI = time8.GetComponent<TextMeshProUGUI>();
        ver = transform.Find("$ver#VerticalLayoutGroup").gameObject;
        ver_VerticalLayoutGroup = ver.GetComponent<VerticalLayoutGroup>();
        scheduleItem = transform.Find("$ver#VerticalLayoutGroup/$scheduleItem").gameObject;
    }
}