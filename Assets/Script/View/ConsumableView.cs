using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class ConsumableView : BaseView
{
    //�Լ�
    public Toggle tgReagent;
    //�Ĳ�
    public Toggle tgConsumable;
    //�Լ�
    public GameObject reagentTable;
    //�Ĳ�
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
