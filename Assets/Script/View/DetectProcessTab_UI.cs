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
    public GameObject detectProject;
    [HideInInspector]
    public TextMeshProUGUI detectProject_TextMeshProUGUI;
    [HideInInspector]
    public GameObject isUrgent;
    [HideInInspector]
    public Toggle isUrgent_Toggle;
    [HideInInspector]
    public GameObject slotsNum;
    [HideInInspector]
    public TextMeshProUGUI slotsNum_TextMeshProUGUI;
    [HideInInspector]
    public GameObject detail;
    [HideInInspector]
    public Button detail_Button;
    [HideInInspector]
    public GameObject up;
    [HideInInspector]
    public Button up_Button;
    [HideInInspector]
    public GameObject down;
    [HideInInspector]
    public Button down_Button;

    internal void _LoadUI()    
    {
        processIDParent = transform.Find("$processIDParent#Rect").gameObject;
        processIDParent_Rect = processIDParent.GetComponent<RectTransform>();
        processID = transform.Find("$processIDParent#Rect/$processID#TextMeshProUGUI").gameObject;
        processID_TextMeshProUGUI = processID.GetComponent<TextMeshProUGUI>();
        detectProject = transform.Find("$processIDParent#Rect/$detectProject#TextMeshProUGUI").gameObject;
        detectProject_TextMeshProUGUI = detectProject.GetComponent<TextMeshProUGUI>();
        isUrgent = transform.Find("$processIDParent#Rect/$isUrgent#Toggle").gameObject;
        isUrgent_Toggle = isUrgent.GetComponent<Toggle>();
        slotsNum = transform.Find("$processIDParent#Rect/$slotsNum#TextMeshProUGUI").gameObject;
        slotsNum_TextMeshProUGUI = slotsNum.GetComponent<TextMeshProUGUI>();
        detail = transform.Find("$processIDParent#Rect/operate/$detail#Button").gameObject;
        detail_Button = detail.GetComponent<Button>();
        up = transform.Find("$processIDParent#Rect/operate/$up#Button").gameObject;
        up_Button = up.GetComponent<Button>();
        down = transform.Find("$processIDParent#Rect/operate/$down#Button").gameObject;
        down_Button = down.GetComponent<Button>();
    }
}