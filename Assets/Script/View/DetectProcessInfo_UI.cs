using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DetectProcessInfo : BaseUI
{
    [HideInInspector]
    public GameObject processID;
    [HideInInspector]
    public TextMeshProUGUI processID_TextMeshProUGUI;
    [HideInInspector]
    public GameObject status;
    [HideInInspector]
    public Image status_Image;
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

    internal void _LoadUI()    
    {
        processID = transform.Find("检测ID/$processID#TextMeshProUGUI").gameObject;
        processID_TextMeshProUGUI = processID.GetComponent<TextMeshProUGUI>();
        status = transform.Find("$status#Image").gameObject;
        status_Image = status.GetComponent<Image>();
        detectProject = transform.Find("检测项目/$detectProject#TextMeshProUGUI").gameObject;
        detectProject_TextMeshProUGUI = detectProject.GetComponent<TextMeshProUGUI>();
        isUrgent = transform.Find("$isUrgent#Toggle").gameObject;
        isUrgent_Toggle = isUrgent.GetComponent<Toggle>();
        createTime = transform.Find("创建时间/$createTime#TextMeshProUGUI").gameObject;
        createTime_TextMeshProUGUI = createTime.GetComponent<TextMeshProUGUI>();
        slotsNum = transform.Find("占用孔位/$slotsNum#TextMeshProUGUI").gameObject;
        slotsNum_TextMeshProUGUI = slotsNum.GetComponent<TextMeshProUGUI>();
        startTime = transform.Find("开始时间/$startTime#TextMeshProUGUI").gameObject;
        startTime_TextMeshProUGUI = startTime.GetComponent<TextMeshProUGUI>();
        endTime = transform.Find("结束时间/$endTime#TextMeshProUGUI").gameObject;
        endTime_TextMeshProUGUI = endTime.GetComponent<TextMeshProUGUI>();
    }
}