using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class SampleTableItem : BaseUI
{
    public bool isLocked = false;
    public void Init(SampleTableItemData _data)
    {
        _LoadUI();
        Toggle tg = GetComponent<Toggle>();
        tg.SetIsOnWithoutNotify(false);
        colID_TextMeshProUGUI.text = (_data.col + 1).ToString();
        slotID_TextMeshProUGUI.text = (_data.index + 1).ToString();
        sampleID_TMP_InputField.text = _data.sampleID;
        SetLock(!string.IsNullOrEmpty(_data.sampleID));
        lockSampleID_Button.onClick.AddListener(() => { SetLock(false); });
        unlockSampleID_Button.onClick.AddListener(() => { SetLock(true); });
        if (_data.detectProject.Length == 0)
        {
            detectProject_TextMeshProUGUI.text = "нч";
        }
        else
        {
            string str = "";
            for (int i = 0; i < _data.detectProject.Length; i++)
            {
                str += _data.detectProject[i];
                if (i != _data.detectProject.Length - 1)
                {
                    str += ",";
                }
            }
            detectProject_TextMeshProUGUI.text = str;
        }
        detectProject_Button.SetButton(() =>
        {
            Action action = () => SaveDetectProjectToAll();
            UIMgr.Ins.OpenView<SelectDetectProjectDialog>(
                new object[2] { detectProject_TextMeshProUGUI, action }
            );
        });
        patientInfo_Button.SetButton(() => { UIMgr.Ins.OpenView<PatientInfoDialog>(); });
    }

    public void SetToggle(bool _ison)
    {
        GetComponent<Toggle>().isOn = _ison;
    }

    public void SetLock(bool _isLocked)
    {
        isLocked = _isLocked;

        lockSampleID.SetActive(isLocked);

        unlockSampleID.SetActive(!isLocked);
        sortSampleID.SetActive(!isLocked);
        sampleID_TMP_InputField.interactable = !isLocked;
    }

    public void SaveDetectProjectToAll()
    {
        GetComponentInParent<SampleManage>().SaveDetectProjectToAll(detectProject_TextMeshProUGUI.text);
    }
}

public class SampleTableItemData
{
    public int col;
    public int index;
    public string sampleID;
    public string[] detectProject = { };
}