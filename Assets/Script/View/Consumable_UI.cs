using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class Consumable : BaseUI
{
    [HideInInspector]
    public GameObject menuParent2;
    [HideInInspector]
    public GameObject menu2;
    [HideInInspector]
    public Toggle menu2_Toggle;
    [HideInInspector]
    public GameObject detectionReagent;
    [HideInInspector]
    public Toggle detectionReagent_Toggle;
    [HideInInspector]
    public GameObject consumable;
    [HideInInspector]
    public Toggle consumable_Toggle;
    [HideInInspector]
    public GameObject legend;
    [HideInInspector]
    public Button legend_Button;

    internal void _LoadUI()    
    {
        menuParent2 = transform.Find("$menuParent2").gameObject;
        menu2 = transform.Find("$menuParent2/$menu2#Toggle").gameObject;
        menu2_Toggle = menu2.GetComponent<Toggle>();
        detectionReagent = transform.Find("$menuParent2/$detectionReagent#Toggle").gameObject;
        detectionReagent_Toggle = detectionReagent.GetComponent<Toggle>();
        consumable = transform.Find("$menuParent2/$consumable#Toggle").gameObject;
        consumable_Toggle = consumable.GetComponent<Toggle>();
        legend = transform.Find("按钮/$legend#Button").gameObject;
        legend_Button = legend.GetComponent<Button>();
    }
}