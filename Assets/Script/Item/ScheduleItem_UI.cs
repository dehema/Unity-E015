using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class ScheduleItem : BaseUI
{
    [HideInInspector]
    public GameObject toggle;
    [HideInInspector]
    public Toggle toggle_Toggle;
    [HideInInspector]
    public GameObject scheduleID;
    [HideInInspector]
    public TextMeshProUGUI scheduleID_TextMeshProUGUI;
    [HideInInspector]
    public GameObject detectProject;
    [HideInInspector]
    public TextMeshProUGUI detectProject_TextMeshProUGUI;
    [HideInInspector]
    public GameObject force;
    [HideInInspector]
    public GameObject status;
    [HideInInspector]
    public Image status_Image;

    internal void _LoadUI()    
    {
        toggle = transform.Find("$toggle#Toggle").gameObject;
        toggle_Toggle = toggle.GetComponent<Toggle>();
        scheduleID = transform.Find("$toggle#Toggle/$scheduleID#TextMeshProUGUI").gameObject;
        scheduleID_TextMeshProUGUI = scheduleID.GetComponent<TextMeshProUGUI>();
        detectProject = transform.Find("$toggle#Toggle/$detectProject#TextMeshProUGUI").gameObject;
        detectProject_TextMeshProUGUI = detectProject.GetComponent<TextMeshProUGUI>();
        force = transform.Find("$toggle#Toggle/$force").gameObject;
        status = transform.Find("$toggle#Toggle/$status#Image").gameObject;
        status_Image = status.GetComponent<Image>();
    }
}