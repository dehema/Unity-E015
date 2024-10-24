using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuItem2 : MonoBehaviour
{
    Toggle toggle;
    TextMeshProUGUI label;
    void Awake()
    {
        toggle = GetComponent<Toggle>();
        label = transform.Find("Label").GetComponent<TextMeshProUGUI>();
        toggle.onValueChanged.AddListener((bool _ison) =>
        {
            label.color = _ison ? new Color(0.1607843f, 0.5529412f, 1) : Color.black;
        });

    }

    void Update()
    {

    }
}
