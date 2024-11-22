using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class Overview : BaseUI
{
    private void Start()
    {
        _LoadUI();
        btConsumable_Button.onClick.AddListener(() =>
        {
            pageConsumable.SetActive(true);
            pageReagent.SetActive(false);
        });
        btReagent_Button.onClick.AddListener(() =>
        {
            pageConsumable.SetActive(false);
            pageReagent.SetActive(true);
        });

        //
        btConsumable_Button.onClick.Invoke();
    }
}
