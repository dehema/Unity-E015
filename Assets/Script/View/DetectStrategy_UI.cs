using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DetectStrategy : BaseUI
{
    [HideInInspector]
    public GameObject detectPriority;
    [HideInInspector]
    public Toggle detectPriority_Toggle;
    [HideInInspector]
    public GameObject qcStrategy;
    [HideInInspector]
    public Toggle qcStrategy_Toggle;
    [HideInInspector]
    public GameObject pageDetectPriority;
    [HideInInspector]
    public GameObject pageQcStrategy;

    internal void _LoadUI()    
    {
        detectPriority = transform.Find("menu/$detectPriority#Toggle").gameObject;
        detectPriority_Toggle = detectPriority.GetComponent<Toggle>();
        qcStrategy = transform.Find("menu/$qcStrategy#Toggle").gameObject;
        qcStrategy_Toggle = qcStrategy.GetComponent<Toggle>();
        pageDetectPriority = transform.Find("page/$pageDetectPriority").gameObject;
        pageQcStrategy = transform.Find("page/$pageQcStrategy").gameObject;
    }
}