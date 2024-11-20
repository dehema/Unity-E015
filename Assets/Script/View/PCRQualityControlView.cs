using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class PCRQualityControlView : BaseView
{
    MachinePlanform machinePlanform;
    Toggle[] slots;

    public override void Init(params object[] _params)
    {
        base.Init(_params);
        sure_Button.onClick.AddListener(() => { Close(); });

        machinePlanform = GetComponentInChildren<MachinePlanform>();
        machinePlanform.ShowReagent(ReagentType.PCRQualityControl, true);

        slots = right.GetComponentsInChildren<Toggle>();
        for (int i = 0; i < slots.Length; i++)
        {
            int index = i;
            Toggle tg = slots[i];
            tg.onValueChanged.AddListener((bool _isOn) =>
            {
                int row = index / 4;
                for (int i = row * 4; i < row * 4 + 4; i++)
                {
                    slots[i].isOn = _isOn;
                }
            });
        }
    }
}
