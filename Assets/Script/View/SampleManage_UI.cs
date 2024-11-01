using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class SampleManage : BaseUI
{
    [HideInInspector]
    public GameObject legend;
    [HideInInspector]
    public Button legend_Button;
    [HideInInspector]
    public GameObject save;
    [HideInInspector]
    public Button save_Button;

    internal void _LoadUI()    
    {
        legend = transform.Find("right/按钮/$legend#Button").gameObject;
        legend_Button = legend.GetComponent<Button>();
        save = transform.Find("right/按钮/$save#Button").gameObject;
        save_Button = save.GetComponent<Button>();
    }
}