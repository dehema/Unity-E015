using UnityEngine;

public partial class ResultReport : BaseUI
{
    private void Start()
    {
        _LoadUI();
        detectReport_Button.onClick.AddListener(() =>
        {
            //UIMgr.Ins.GetView<MainView>().menuToggleList2[1].isOn = true;
            UIMgr.Ins.GetView<MainView>().showContentPage("DetectReport");
        });
        detailResult_Button.onClick.AddListener(() =>
        {
            UIMgr.Ins.GetView<MainView>().showContentPage("ResultReportDetail");
        });
    }
}
