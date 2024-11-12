using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class ResultReport : BaseUI
{
    [HideInInspector]
    public GameObject openFile;
    [HideInInspector]
    public Button openFile_Button;
    [HideInInspector]
    public GameObject detailResult;
    [HideInInspector]
    public Button detailResult_Button;
    [HideInInspector]
    public GameObject detectReport;
    [HideInInspector]
    public Button detectReport_Button;

    internal void _LoadUI()    
    {
        openFile = transform.Find("content/operate/operate/$openFile#Button").gameObject;
        openFile_Button = openFile.GetComponent<Button>();
        detailResult = transform.Find("content/operate/operate/$detailResult#Button").gameObject;
        detailResult_Button = detailResult.GetComponent<Button>();
        detectReport = transform.Find("content/operate/operate/$detectReport#Button").gameObject;
        detectReport_Button = detectReport.GetComponent<Button>();
    }
}