using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class SampleTableItem : BaseUI
{
    [HideInInspector]
    public GameObject colID;
    [HideInInspector]
    public TextMeshProUGUI colID_TextMeshProUGUI;
    [HideInInspector]
    public GameObject slotID;
    [HideInInspector]
    public TextMeshProUGUI slotID_TextMeshProUGUI;
    [HideInInspector]
    public GameObject sampleID;
    [HideInInspector]
    public TMP_InputField sampleID_TMP_InputField;
    [HideInInspector]
    public GameObject sortSampleID;
    [HideInInspector]
    public Button sortSampleID_Button;
    [HideInInspector]
    public GameObject unlockSampleID;
    [HideInInspector]
    public Button unlockSampleID_Button;
    [HideInInspector]
    public GameObject lockSampleID;
    [HideInInspector]
    public Button lockSampleID_Button;
    [HideInInspector]
    public GameObject sampleType;
    [HideInInspector]
    public TMP_Dropdown sampleType_TMP_Dropdown;
    [HideInInspector]
    public GameObject applySampleType;
    [HideInInspector]
    public Button applySampleType_Button;
    [HideInInspector]
    public GameObject detectProject;
    [HideInInspector]
    public TextMeshProUGUI detectProject_TextMeshProUGUI;
    [HideInInspector]
    public Button detectProject_Button;
    [HideInInspector]
    public GameObject patientInfo;
    [HideInInspector]
    public Button patientInfo_Button;

    internal void _LoadUI()    
    {
        colID = transform.Find("hor/$colID#TextMeshProUGUI").gameObject;
        colID_TextMeshProUGUI = colID.GetComponent<TextMeshProUGUI>();
        slotID = transform.Find("hor/$slotID#TextMeshProUGUI").gameObject;
        slotID_TextMeshProUGUI = slotID.GetComponent<TextMeshProUGUI>();
        sampleID = transform.Find("hor/sampleID/$sampleID#TMP_InputField").gameObject;
        sampleID_TMP_InputField = sampleID.GetComponent<TMP_InputField>();
        sortSampleID = transform.Find("hor/sampleID/$sortSampleID#Button").gameObject;
        sortSampleID_Button = sortSampleID.GetComponent<Button>();
        unlockSampleID = transform.Find("hor/sampleID/$unlockSampleID#Button").gameObject;
        unlockSampleID_Button = unlockSampleID.GetComponent<Button>();
        lockSampleID = transform.Find("hor/sampleID/$lockSampleID#Button").gameObject;
        lockSampleID_Button = lockSampleID.GetComponent<Button>();
        sampleType = transform.Find("hor/sampleType/$sampleType#TMP_Dropdown").gameObject;
        sampleType_TMP_Dropdown = sampleType.GetComponent<TMP_Dropdown>();
        applySampleType = transform.Find("hor/sampleType/$applySampleType#Button").gameObject;
        applySampleType_Button = applySampleType.GetComponent<Button>();
        detectProject = transform.Find("hor/$detectProject#TextMeshProUGUI,Button").gameObject;
        detectProject_TextMeshProUGUI = detectProject.GetComponent<TextMeshProUGUI>();
        detectProject_Button = detectProject.GetComponent<Button>();
        patientInfo = transform.Find("hor/$patientInfo#Button").gameObject;
        patientInfo_Button = patientInfo.GetComponent<Button>();
    }
}