using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DetectReport : BaseUI
{
    [HideInInspector]
    public GameObject sample;
    [HideInInspector]
    public Button sample_Button;
    [HideInInspector]
    public GameObject detect;
    [HideInInspector]
    public Button detect_Button;
    [HideInInspector]
    public GameObject pageSample;
    [HideInInspector]
    public GameObject pageDetect;

    internal void _LoadUI()    
    {
        sample = transform.Find("bg/page/$sample#Button").gameObject;
        sample_Button = sample.GetComponent<Button>();
        detect = transform.Find("bg/page/$detect#Button").gameObject;
        detect_Button = detect.GetComponent<Button>();
        pageSample = transform.Find("bg/$pageSample").gameObject;
        pageDetect = transform.Find("bg/$pageDetect").gameObject;
    }
}