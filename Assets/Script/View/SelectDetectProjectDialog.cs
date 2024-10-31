using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public partial class SelectDetectProjectDialog : BaseView
{
    public override void Init(params object[] _params)
    {
        TextMeshProUGUI text = (TextMeshProUGUI)_params[0];
        base.Init(_params);
        save_Button.SetButton(() =>
        {
            Toggle[] tgs = GetComponentsInChildren<Toggle>();
            string str = "";
            foreach (Toggle _tg in tgs)
            {
                if (_tg.isOn)
                {
                    TextMeshProUGUI _t = _tg.transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
                    str += _t.text + "¡¢";
                }
            }
            if (str.Length != 0)
            {
                str = str.Substring(0, str.Length - 1);
            }
            text.text = str;
            Close();
        });

        saveAll_Button.SetButton(() =>
        {
            save_Button.onClick.Invoke();
            Action action = _params[1] as Action;
            action();
        });
    }
}
