using UnityEngine;

public partial class DailyMaintenance : BaseView
{
    void Start()
    {
        _LoadUI();
        sampleType_TMP_Dropdown.onValueChanged.AddListener((int _val) =>
        {
            startTime.SetActive(_val == 1);
        });
    }
}
