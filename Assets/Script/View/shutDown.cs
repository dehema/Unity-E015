using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class shutDown : BaseUI
{
    private void Start()
    {
        _LoadUI();
        //shutdown_Button.onClick.AddListener(() =>
        //{
        //Canvas canvas = GetComponentInParent<Canvas>();
        //canvas.GetComponent<BaseView>().Close();
        //Application.Quit();
        //});
        shotDown_TMP_Dropdown.onValueChanged.AddListener((int _val) =>
        {
            if (_val == 3)
            {
                UIMgr.Ins.OpenView<DisinfectDialog>();
            }
        });
    }
}
