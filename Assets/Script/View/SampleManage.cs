using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SampleManage : MonoBehaviour
{
    public GameObject sampleCol;
    public GameObject tbSample;
    List<Toggle> tgSampleCols = new List<Toggle>();
    List<SampleTableItem> sampleTableItemList = new List<SampleTableItem>();

    private void Start()
    {
        //样本条
        for (int i = 0; i < 6; i++)
        {
            GameObject item = Instantiate<GameObject>(sampleCol, sampleCol.transform.parent);
            TextMeshProUGUI text = item.transform.Find("index").GetComponent<TextMeshProUGUI>();
            ToggleGroup toggleGroup = sampleCol.transform.parent.GetComponent<ToggleGroup>();
            Toggle tgSampleCol = item.transform.Find("ver").GetComponent<Toggle>();
            tgSampleCols.Add(tgSampleCol);
            int _index = i;
            tgSampleCol.onValueChanged.AddListener((bool _isOn) =>
            {
                if (_isOn)
                {
                    OnSampleColSelect(_index);
                }
            });
            tgSampleCol.group = toggleGroup;
            text.text = (i + 1).ToString();
            int _samepleItemIndex = 0;
            foreach (Transform samepleItem in tgSampleCol.transform)
            {
                Toggle _tg = samepleItem.GetComponent<Toggle>();
                _tg.group = toggleGroup;
                _samepleItemIndex++;
                int __samepleItemIndex = _samepleItemIndex;
                _tg.onValueChanged.AddListener((bool _ison) =>
                {
                    if (_ison)
                    {
                        OnSampleColSelect(_index);
                        sampleTableItemList[__samepleItemIndex].SetToggle(true);
                    }
                });
            }
        }
        sampleCol.SetActive(false);
        tgSampleCols[0].isOn = true;
    }

    void OnSampleColSelect(int _index)
    {
        Transform content = tbSample.transform;
        for (int i = 0; i < content.childCount; i++)
        {
            if (i >= 3)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
        GameObject originRow = content.Find("sampleTableItem").gameObject;
        sampleTableItemList.Clear();
        for (int i = 0; i < 16; i++)
        {
            GameObject item = Instantiate(originRow, content);
            item.SetActive(true);
            SampleTableItem sampleTableItem = item.GetComponent<SampleTableItem>();
            SampleTableItemData data = new SampleTableItemData();
            data.col = _index;
            data.index = i;
            if (i == 0)
            {
                data.sampleID = "1146824";
                data.detectProject = new string[] { "HPV" };
            }
            if (i == 3)
            {
                data.sampleID = "1146825";
                data.detectProject = new string[] { "HBV" };
            }
            if (i == 4)
            {
                data.sampleID = "1146826";
                data.detectProject = new string[] { "呼吸道" };
            }
            sampleTableItem.Init(data);
            sampleTableItemList.Add(sampleTableItem);

            Button btSort = sampleTableItem.sortSampleID_Button;
            int index = i;
            btSort.onClick.AddListener(() => { onclickSort(index); });

            Button btSampleType = sampleTableItem.applySampleType_Button;
            btSampleType.onClick.AddListener(() =>
            {
                int _value = sampleTableItemList[index].sampleType_TMP_Dropdown.value;
                for (int i = index + 1; i < sampleTableItemList.Count; i++)
                {
                    SampleTableItem item = sampleTableItemList[i];
                    item.sampleType_TMP_Dropdown.value = _value;
                }
            });
            //
            Instantiate(content.Find("line").gameObject, content).SetActive(true);
        }
        originRow.SetActive(false);
    }

    //排序下箭头
    void onclickSort(int _index)
    {
        TMP_InputField input = sampleTableItemList[_index].sampleID_TMP_InputField;
        if (string.IsNullOrEmpty(input.text))
        {
            return;
        }
        int id = int.Parse(input.text);
        int add = 1;
        for (int i = _index + 1; i < sampleTableItemList.Count; i++)
        {
            if (!sampleTableItemList[i].isLocked)
                sampleTableItemList[i].sampleID_TMP_InputField.text = (id + add++).ToString();
        }
    }

    public void SaveDetectProjectToAll(string _str)
    {
        foreach (SampleTableItem item in sampleTableItemList)
        {
            item.detectProject_TextMeshProUGUI.text = _str;
        }
    }
}
