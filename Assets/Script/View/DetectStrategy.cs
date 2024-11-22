using UnityEngine;

public partial class DetectStrategy : BaseUI
{
    void Start()
    {
        _LoadUI();
        detectPriority_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageDetectPriority); });
        qcStrategy_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageQcStrategy); });

        showPage(pageDetectPriority);
    }

    void showPage(GameObject _page)
    {
        pageDetectPriority.SetActive(false);
        pageQcStrategy.SetActive(false);
        _page.SetActive(true);
    }
}
