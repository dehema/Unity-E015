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
    public GameObject reagent;
    [HideInInspector]
    public Toggle reagent_Toggle;
    [HideInInspector]
    public GameObject equip;
    [HideInInspector]
    public Toggle equip_Toggle;
    [HideInInspector]
    public GameObject pageEqupState;
    [HideInInspector]
    public GameObject pageOverview;

    internal void _LoadUI()    
    {
        content = transform.Find("$content#Rect").gameObject;
        content_Rect = content.GetComponent<RectTransform>();
        reagent = transform.Find("$content#Rect/menu/$reagent#Toggle").gameObject;
        reagent_Toggle = reagent.GetComponent<Toggle>();
        equip = transform.Find("$content#Rect/menu/$equip#Toggle").gameObject;
        equip_Toggle = equip.GetComponent<Toggle>();
        pageEqupState = transform.Find("$content#Rect/$pageEqupState").gameObject;
        pageOverview = transform.Find("$content#Rect/$pageOverview").gameObject;
    }
}