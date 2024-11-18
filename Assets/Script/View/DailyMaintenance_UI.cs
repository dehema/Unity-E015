using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class DailyMaintenance : BaseView
{
    [HideInInspector]
    public GameObject sampleType;
    [HideInInspector]
    public TMP_Dropdown sampleType_TMP_Dropdown;
    [HideInInspector]
    public GameObject startTime;

    internal override void _LoadUI()    
    {
        base._LoadUI();
        sampleType = transform.Find("content/top/清洁/content/紫外线/计时/$sampleType#TMP_Dropdown").gameObject;
        sampleType_TMP_Dropdown = sampleType.GetComponent<TMP_Dropdown>();
        startTime = transform.Find("content/top/清洁/content/紫外线/计时/$startTime").gameObject;
    }
}