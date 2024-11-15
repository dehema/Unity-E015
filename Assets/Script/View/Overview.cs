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
        tgRuning_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            if (!_ison)
                return;
            hideAllPage();
            pageRunningDetectProject.SetActive(true);
        });
        tgFinish_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            if (!_ison)
                return;
            hideAllPage();
            pageFinishDetectProject.SetActive(true);
        });
        tgWait_Toggle.onValueChanged.AddListener((bool _ison) =>
        {
            if (!_ison)
                return;
            hideAllPage();
            pageWaitDetectProject.SetActive(true);
        });
        for (int i = 1; i < 10; i++)
        {
            GameObject item;
            item = Instantiate(runingSampleTableItem, runingSampleTableItem.transform.parent);
            item.transform.Find("hor/1").GetComponent<TMP_Text>().text = (1164835456 + i).ToString();
            item = Instantiate(waitSampleTableItem, waitSampleTableItem.transform.parent);
            item.transform.Find("hor/1").GetComponent<TMP_Text>().text = (1164835456 + i).ToString();
            item = Instantiate(finishSampleTableItem, finishSampleTableItem.transform.parent);
            item.transform.Find("hor/1").GetComponent<TMP_Text>().text = (1164835456 + i).ToString();
        }
    }

    void hideAllPage()
    {
        pageRunningDetectProject.SetActive(false);
        pageWaitDetectProject.SetActive(false);
        pageFinishDetectProject.SetActive(false);
    }
}
