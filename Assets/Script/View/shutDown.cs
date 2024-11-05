using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class shutDown : BaseUI
{
    private void Start()
    {
        _LoadUI();
        shutdown_Button.onClick.AddListener(() =>
        {
            //Canvas canvas = GetComponentInParent<Canvas>();
            //canvas.GetComponent<BaseView>().Close();
            Application.Quit();
        });
    }
}
