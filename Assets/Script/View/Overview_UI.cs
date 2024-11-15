using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class Overview : BaseUI
{
    [HideInInspector]
    public GameObject content;
    [HideInInspector]
    public RectTransform content_Rect;
    [HideInInspector]
    public GameObject pageOverview;
    [HideInInspector]
    public GameObject tgRuning;
    [HideInInspector]
    public Toggle tgRuning_Toggle;
    [HideInInspector]
    public GameObject tgFinish;
    [HideInInspector]
    public Toggle tgFinish_Toggle;
    [HideInInspector]
    public GameObject tgWait;
    [HideInInspector]
    public Toggle tgWait_Toggle;
    [HideInInspector]
    public GameObject pageRunningDetectProject;
    [HideInInspector]
    public GameObject runingSampleTableItem;
    [HideInInspector]
    public GameObject pageWaitDetectProject;
    [HideInInspector]
    public GameObject waitSampleTableItem;
    [HideInInspector]
    public GameObject pageFinishDetectProject;
    [HideInInspector]
    public GameObject finishSampleTableItem;

    internal void _LoadUI()    
    {
        content = transform.Find("$content#Rect").gameObject;
        content_Rect = content.GetComponent<RectTransform>();
        pageOverview = transform.Find("$content#Rect/$pageOverview").gameObject;
        tgRuning = transform.Find("$content#Rect/$pageOverview/DetectProject/menu/hor/$tgRuning#Toggle").gameObject;
        tgRuning_Toggle = tgRuning.GetComponent<Toggle>();
        tgFinish = transform.Find("$content#Rect/$pageOverview/DetectProject/menu/hor/$tgFinish#Toggle").gameObject;
        tgFinish_Toggle = tgFinish.GetComponent<Toggle>();
        tgWait = transform.Find("$content#Rect/$pageOverview/DetectProject/menu/hor/$tgWait#Toggle").gameObject;
        tgWait_Toggle = tgWait.GetComponent<Toggle>();
        pageRunningDetectProject = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageRunningDetectProject").gameObject;
        runingSampleTableItem = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageRunningDetectProject/tbSample/$runingSampleTableItem").gameObject;
        pageWaitDetectProject = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageWaitDetectProject").gameObject;
        waitSampleTableItem = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageWaitDetectProject/tbSample/$waitSampleTableItem").gameObject;
        pageFinishDetectProject = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageFinishDetectProject").gameObject;
        finishSampleTableItem = transform.Find("$content#Rect/$pageOverview/DetectProject/hor/$pageFinishDetectProject/tbSample/$finishSampleTableItem").gameObject;
    }
}