using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class ProjectManage : BaseUI
{
    [HideInInspector]
    public GameObject detectManage;
    [HideInInspector]
    public Toggle detectManage_Toggle;
    [HideInInspector]
    public GameObject reactionProgram;
    [HideInInspector]
    public Toggle reactionProgram_Toggle;
    [HideInInspector]
    public GameObject fluoSetting;
    [HideInInspector]
    public Toggle fluoSetting_Toggle;
    [HideInInspector]
    public GameObject axeProcess;
    [HideInInspector]
    public Toggle axeProcess_Toggle;
    [HideInInspector]
    public GameObject autoProcess;
    [HideInInspector]
    public Toggle autoProcess_Toggle;
    [HideInInspector]
    public GameObject qualityControl;
    [HideInInspector]
    public Toggle qualityControl_Toggle;
    [HideInInspector]
    public GameObject pageDetectManage;
    [HideInInspector]
    public GameObject pageReactionProgram;
    [HideInInspector]
    public GameObject pageFluoSetting;
    [HideInInspector]
    public GameObject pageAxeProcess;
    [HideInInspector]
    public GameObject pageAutoProcess;
    [HideInInspector]
    public GameObject pageQualityControl;

    internal void _LoadUI()    
    {
        detectManage = transform.Find("menu/$detectManage#Toggle").gameObject;
        detectManage_Toggle = detectManage.GetComponent<Toggle>();
        reactionProgram = transform.Find("menu/$reactionProgram#Toggle").gameObject;
        reactionProgram_Toggle = reactionProgram.GetComponent<Toggle>();
        fluoSetting = transform.Find("menu/$fluoSetting#Toggle").gameObject;
        fluoSetting_Toggle = fluoSetting.GetComponent<Toggle>();
        axeProcess = transform.Find("menu/$axeProcess#Toggle").gameObject;
        axeProcess_Toggle = axeProcess.GetComponent<Toggle>();
        autoProcess = transform.Find("menu/$autoProcess#Toggle").gameObject;
        autoProcess_Toggle = autoProcess.GetComponent<Toggle>();
        qualityControl = transform.Find("menu/$qualityControl#Toggle").gameObject;
        qualityControl_Toggle = qualityControl.GetComponent<Toggle>();
        pageDetectManage = transform.Find("page/$pageDetectManage").gameObject;
        pageReactionProgram = transform.Find("page/$pageReactionProgram").gameObject;
        pageFluoSetting = transform.Find("page/$pageFluoSetting").gameObject;
        pageAxeProcess = transform.Find("page/$pageAxeProcess").gameObject;
        pageAutoProcess = transform.Find("page/$pageAutoProcess").gameObject;
        pageQualityControl = transform.Find("page/$pageQualityControl").gameObject;
    }
}