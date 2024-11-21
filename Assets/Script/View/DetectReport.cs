using UnityEngine;

public partial class DetectReport : BaseUI
{
    private void Start()
    {
        _LoadUI();

        sample_Button.onClick.AddListener(() =>
        {
            pageSample.SetActive(true);
            pageDetect.SetActive(false);
        });
        detect_Button.onClick.AddListener(() =>
        {
            pageSample.SetActive(false);
            pageDetect.SetActive(true);
        });
        sample_Button.onClick.Invoke();
    }
}
