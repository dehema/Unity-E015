using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DetectProcessTab : BaseUI
{
    [HideInInspector]
    public GameObject processIDParent;
    [HideInInspector]
    public RectTransform processIDParent_Rect;
    [HideInInspector]
    public GameObject processID;
    [HideInInspector]
    public TextMeshProUGUI processID_TextMeshProUGUI;
    [HideInInspector]
    public GameObject detectProjectParent;
    [HideInInspector]
    public RectTransform detectProjectParent_Rect;
    [HideInInspector]
    public GameObject detectProject;
    [HideInInspector]
    public TextMeshProUGUI detectProject_TextMeshProUGUI;
    [HideInInspector]
    public GameObject isUrgent;
    [HideInInspector]
    public Toggle isUrgent_Toggle;
    [HideInInspector]
    public GameObject createTime;
    [HideInInspector]
    public TextMeshProUGUI createTime_TextMeshProUGUI;
    [HideInInspector]
    public GameObject slotsNum;
    [HideInInspector]
    public TextMeshProUGUI slotsNum_TextMeshProUGUI;
    [HideInInspector]
    public GameObject startTime;
    [HideInInspector]
    public TextMeshProUGUI startTime_TextMeshProUGUI;
    [HideInInspector]
    public GameObject endTime;
    [HideInInspector]
    public TextMeshProUGUI endTime_TextMeshProUGUI;
    [HideInInspector]
    public GameObject sampleSlot;
    [HideInInspector]
    public GameObject submit;
    [HideInInspector]
    public Button submit_Button;
    [HideInInspector]
    public GameObject detail;
    [HideInInspector]
    public Button detail_Button;

    internal void _LoadUI()    
    {
        processIDParent = transform.Find("$processIDParent#Rect").gameObject;
        processIDParent_Rect = processIDParent.GetComponent<RectTransform>();
        processID = transform.Find("$processIDParent#Rect/$processID#TextMeshProUGUI").gameObject;
        processID_TextMeshProUGUI = processID.GetComponent<TextMeshProUGUI>();
        detectProjectParent = transform.Find("$detectProjectParent#Rect").gameObject;
        detectProjectParent_Rect = detectProjectParent.GetComponent<RectTransform>();
        detectProject = transform.Find("$detectProjectParent#Rect/$detectProject#TextMeshProUGUI").gameObject;
        detectProject_TextMeshProUGUI = detectProject.GetComponent<TextMeshProUGUI>();
        isUrgent = transform.Find("$isUrgent#Toggle").gameObject;
        isUrgent_Toggle = isUrgent.GetComponent<Toggle>();
        createTime = transform.Find("创建时间/$createTime#TextMeshProUGUI").gameObject;
        createTime_TextMeshProUGUI = createTime.GetComponent<TextMeshProUGUI>();
        slotsNum = transform.Find("占用孔位/$slotsNum#TextMeshProUGUI").gameObject;
        slotsNum_TextMeshProUGUI = slotsNum.GetComponent<TextMeshProUGUI>();
        startTime = transform.Find("预计开始时间/$startTime#TextMeshProUGUI").gameObject;
        startTime_TextMeshProUGUI = startTime.GetComponent<TextMeshProUGUI>();
        endTime = transform.Find("结束时间/$endTime#TextMeshProUGUI").gameObject;
        endTime_TextMeshProUGUI = endTime.GetComponent<TextMeshProUGUI>();
        sampleSlot = transform.Find("$sampleSlot").gameObject;
        submit = transform.Find("$submit#Button").gameObject;
        submit_Button = submit.GetComponent<Button>();
        detail = transform.Find("$detail#Button").gameObject;
        detail_Button = detail.GetComponent<Button>();
    }
}