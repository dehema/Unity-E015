using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class shutDown : BaseUI
{
    [HideInInspector]
    public GameObject account;
    [HideInInspector]
    public Button account_Button;
    [HideInInspector]
    public GameObject shutdown;
    [HideInInspector]
    public Button shutdown_Button;

    internal void _LoadUI()    
    {
        account = transform.Find("$account#Button").gameObject;
        account_Button = account.GetComponent<Button>();
        shutdown = transform.Find("$shutdown#Button").gameObject;
        shutdown_Button = shutdown.GetComponent<Button>();
    }
}