using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PatientInfoDialog : BaseView
{
    public override void Init(params global::System.Object[] _params)
    {
        base.Init(_params);
        save_Button.SetButton(Close);
    }
}