using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class ScheduleGanttChart : BaseUI
{
    [HideInInspector]
    public GameObject legend;
    [HideInInspector]
    public Button legend_Button;
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
    public GameObject time9;
    [HideInInspector]
    public TextMeshProUGUI time9_TextMeshProUGUI;
    [HideInInspector]
    public GameObject time10;
    [HideInInspector]
    public TextMeshProUGUI time10_TextMeshProUGUI;
    [HideInInspector]
    public GameObject scheduleIParent;
    [HideInInspector]
    public RectTransform scheduleIParent_Rect;
    [HideInInspector]
    public ToggleGroup scheduleIParent_ToggleGroup;
    [HideInInspector]
    public GameObject scheduleItem;
    [HideInInspector]
    public RectTransform scheduleItem_Rect;

    internal void _LoadUI()    
    {
        legend = transform.Find("$legend#Button").gameObject;
        legend_Button = legend.GetComponent<Button>();
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
        time9 = transform.Find("$title#Rect/hor/$time9#TextMeshProUGUI").gameObject;
        time9_TextMeshProUGUI = time9.GetComponent<TextMeshProUGUI>();
        time10 = transform.Find("$title#Rect/hor/$time10#TextMeshProUGUI").gameObject;
        time10_TextMeshProUGUI = time10.GetComponent<TextMeshProUGUI>();
        scheduleIParent = transform.Find("$scheduleIParent#Rect,ToggleGroup").gameObject;
        scheduleIParent_Rect = scheduleIParent.GetComponent<RectTransform>();
        scheduleIParent_ToggleGroup = scheduleIParent.GetComponent<ToggleGroup>();
        scheduleItem = transform.Find("$scheduleIParent#Rect,ToggleGroup/$scheduleItem#Rect").gameObject;
        scheduleItem_Rect = scheduleItem.GetComponent<RectTransform>();
    }
}