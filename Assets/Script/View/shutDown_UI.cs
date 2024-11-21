using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class shutDown : BaseUI
{
    [HideInInspector]
    public GameObject account;
    [HideInInspector]
    public Button account_Button;
    [HideInInspector]
    public GameObject shotDown;
    [HideInInspector]
    public TMP_Dropdown shotDown_TMP_Dropdown;

    internal void _LoadUI()    
    {
        account = transform.Find("$account#Button").gameObject;
        account_Button = account.GetComponent<Button>();
        shotDown = transform.Find("$shotDown#TMP_Dropdown").gameObject;
        shotDown_TMP_Dropdown = shotDown.GetComponent<TMP_Dropdown>();
    }
}