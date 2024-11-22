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
    public GameObject pageOverview;
    [HideInInspector]
    public GameObject btConsumable;
    [HideInInspector]
    public Button btConsumable_Button;
    [HideInInspector]
    public GameObject btReagent;
    [HideInInspector]
    public Button btReagent_Button;
    [HideInInspector]
    public GameObject pageConsumable;
    [HideInInspector]
    public GameObject pageReagent;

    internal void _LoadUI()    
    {
        content = transform.Find("$content#Rect").gameObject;
        content_Rect = content.GetComponent<RectTransform>();
        pageOverview = transform.Find("$content#Rect/$pageOverview").gameObject;
        btConsumable = transform.Find("$content#Rect/$pageOverview/right/Consumable/title/$btConsumable#Button").gameObject;
        btConsumable_Button = btConsumable.GetComponent<Button>();
        btReagent = transform.Find("$content#Rect/$pageOverview/right/Consumable/title/$btReagent#Button").gameObject;
        btReagent_Button = btReagent.GetComponent<Button>();
        pageConsumable = transform.Find("$content#Rect/$pageOverview/right/Consumable/$pageConsumable").gameObject;
        pageReagent = transform.Find("$content#Rect/$pageOverview/right/Consumable/$pageReagent").gameObject;
    }
}