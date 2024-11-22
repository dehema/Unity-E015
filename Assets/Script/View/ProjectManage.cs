using UnityEngine;

public partial class ProjectManage : BaseUI
{
    void Start()
    {
        _LoadUI();
        autoProcess_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageAutoProcess); });
        axeProcess_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageAxeProcess); });
        detectManage_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageDetectManage); });
        fluoSetting_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageFluoSetting); });
        reactionProgram_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageReactionProgram); });
        qualityControl_Toggle.onValueChanged.AddListener((bool _ison) => { showPage(pageQualityControl); });

        showPage(pageAutoProcess);
    }

    void showPage(GameObject _page)
    {
        pageAutoProcess.SetActive(false);
        pageAxeProcess.SetActive(false);
        pageDetectManage.SetActive(false);
        pageFluoSetting.SetActive(false);
        pageReactionProgram.SetActive(false);
        pageQualityControl.SetActive(false);
        _page.SetActive(true);
    }
}
