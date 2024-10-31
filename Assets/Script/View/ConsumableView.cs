using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class ConsumableView : BaseView
{
    //ÊÔ¼Á
    public Toggle tgReagent;
    //ºÄ²Ä
    public Toggle tgConsumable;
    //ÊÔ¼Á
    public GameObject reagentTable;
    //ºÄ²Ä
    public GameObject consumableTable;

    public override void Init(params object[] _params)
    {
        base.Init(_params);
        tgReagent.onValueChanged.AddListener((bool _isOn) =>
        {
            if (!_isOn)
            {
                return;
            }
            reagentTable.SetActive(_isOn);
            consumableTable.SetActive(!_isOn);
        });
        tgConsumable.onValueChanged.AddListener((bool _isOn) =>
        {
            if (!_isOn)
            {
                return;
            }
            reagentTable.SetActive(!_isOn);
            consumableTable.SetActive(_isOn);
        });
        tgReagent.isOn = true;
    }

    public override void OnOpen(params object[] _params)
    {
        base.OnOpen(_params);
    }
}
