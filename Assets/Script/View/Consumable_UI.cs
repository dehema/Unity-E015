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
    public GameObject axe;
    [HideInInspector]
    public Toggle axe_Toggle;
    [HideInInspector]
    public GameObject legend;
    [HideInInspector]
    public Button legend_Button;
    [HideInInspector]
    public GameObject pageConsumable;
    [HideInInspector]
    public GameObject pageAxe;
    [HideInInspector]
    public GameObject machine;
    [HideInInspector]
    public MachinePlanform machine_MachinePlanform;
    [HideInInspector]
    public GameObject load;
    [HideInInspector]
    public Button load_Button;

    internal void _LoadUI()    
    {
        menuParent2 = transform.Find("$menuParent2").gameObject;
        menu2 = transform.Find("$menuParent2/$menu2#Toggle").gameObject;
        menu2_Toggle = menu2.GetComponent<Toggle>();
        detectionReagent = transform.Find("$menuParent2/$detectionReagent#Toggle").gameObject;
        detectionReagent_Toggle = detectionReagent.GetComponent<Toggle>();
        consumable = transform.Find("$menuParent2/$consumable#Toggle").gameObject;
        consumable_Toggle = consumable.GetComponent<Toggle>();
        axe = transform.Find("$menuParent2/$axe#Toggle").gameObject;
        axe_Toggle = axe.GetComponent<Toggle>();
        legend = transform.Find("$menuParent2/$legend#Button").gameObject;
        legend_Button = legend.GetComponent<Button>();
        pageConsumable = transform.Find("$pageConsumable").gameObject;
        pageAxe = transform.Find("$pageAxe").gameObject;
        machine = transform.Find("machine/$machine#MachinePlanform").gameObject;
        machine_MachinePlanform = machine.GetComponent<MachinePlanform>();
        load = transform.Find("machine/$load#Button").gameObject;
        load_Button = load.GetComponent<Button>();
    }
}