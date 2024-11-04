using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class ConsumableLegendDialog : BaseView
{
    public override void Init(params object[] _params)
    {
        base.Init(_params);
    }

    public override void OnOpen(params object[] _params)
    {
        base.OnOpen(_params);
        planform_MachinePlanform.setAll(false);
        bool isReagent = (bool)_params[0];
        int val = (int)_params[1];
        if (isReagent)
        {
            planform_MachinePlanform.ShowReagent((ReagentType)val, true);
        }
        else
        {
            planform_MachinePlanform.ShowConsumable((ConsumableType)val, true);
        }
    }
}
