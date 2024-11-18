using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PCRQualityControlView : BaseView
{
    public override void Init(params object[] _params)
    {
        base.Init(_params);
        sure_Button.onClick.AddListener(() => { Close(); });
    }
}
