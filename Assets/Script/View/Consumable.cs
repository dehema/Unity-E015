using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public partial class Consumable : BaseUI
{
    //试剂
    public Toggle tgReagent;
    //耗材
    public Toggle tgConsumable;
    //试剂
    public GameObject tbReagent;
    //耗材
    public GameObject tbConsumable;
    //试剂
    public GameObject rowReagent;
    //耗材
    public GameObject rowConsumable;

    public void Start()
    {
        _LoadUI();
        legend_Button.onClick.AddListener(() => { UIMgr.Ins.OpenView<ConsumableManageLegendDialog>(); });
        tbReagent.SetActive(true);
        tbConsumable.SetActive(false);
        rowReagent.SetActive(false);
        rowConsumable.SetActive(false);
        tgReagent.onValueChanged.AddListener((bool _isOn) =>
        {
            tbReagent.SetActive(_isOn);
            tbConsumable.SetActive(!_isOn);
            if (_isOn)
                RefreshTbReagent();
        });
        tgConsumable.onValueChanged.AddListener((bool _isOn) =>
        {
            if (!_isOn)
            {
                return;
            }
            tbReagent.SetActive(!_isOn);
            tbConsumable.SetActive(_isOn);
            if (_isOn)
                RefreshTbConsumable();
        });
        tgReagent.isOn = true;
        RefreshTbReagent();
    }


    void ClearTb()
    {
        Transform content = tbReagent.transform.parent;
        for (int i = 0; i < content.childCount; i++)
        {
            if (i >= 4)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
    }

    void RefreshTbReagent()
    {
        ClearTb();
        Array values = Enum.GetValues(typeof(ReagentType));
        List<GameObject> itemList = new List<GameObject>();
        foreach (ReagentType item in values)
        {
            itemList.Add(addReagentItem(item));
        }
        GameObject lastItem = itemList.Last();
        lastItem.transform.Find("line").gameObject.SetActive(false);
    }

    GameObject addReagentItem(ReagentType _type)
    {
        GameObject item = Instantiate(rowReagent, rowReagent.transform.parent);
        item.SetActive(true);
        //item.transform.Find("Toggle").GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
        //{
        //planform.ShowReagent(_type, _isOn);
        //});
        ReagentType type = _type;
        item.transform.Find("hor/名称").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getReagentName(_type) + DateTime.Now.ToString("MMdd");
        item.transform.Find("hor/类型").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getReagentType(_type);
        item.transform.Find("hor/剩余数量").GetComponent<TextMeshProUGUI>().text = Random.Range(1, 100).ToString();
        item.transform.Find("hor/失效日期").GetComponent<TextMeshProUGUI>().text = DateTime.Now.AddDays(Random.Range(1, 100)).ToString("d");
        item.transform.Find("hor/批号").GetComponent<TextMeshProUGUI>().text = "24040910T" + (369 + Random.Range(1, 100)).ToString();
        item.transform.Find("hor/查看位置").GetComponent<Button>().onClick.AddListener(() => { UIMgr.Ins.OpenView<ConsumableLegendDialog>(new object[2] { true, (int)type }); });

        return item;
    }

    void RefreshTbConsumable()
    {
        ClearTb();
        Array values = Enum.GetValues(typeof(ConsumableType));
        List<GameObject> itemList = new List<GameObject>();
        foreach (ConsumableType item in values)
        {
            itemList.Add(addConsumableItem(item));
        }
        GameObject lastItem = itemList.Last();
        lastItem.transform.Find("line").gameObject.SetActive(false);
    }

    GameObject addConsumableItem(ConsumableType _type)
    {
        GameObject item = Instantiate(rowConsumable, rowConsumable.transform.parent);
        item.SetActive(true);
        //item.transform.Find("Toggle").GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
        //{
        //planform.ShowConsumable(_type, _isOn);
        //});
        ConsumableType type = _type;
        item.transform.Find("hor/名称").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getConsumableName(_type) + DateTime.Now.ToString("MMdd");
        item.transform.Find("hor/类型").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getConsumableName(_type);
        item.transform.Find("hor/剩余数量").GetComponent<TextMeshProUGUI>().text = Random.Range(1, 100).ToString();
        item.transform.Find("hor/失效日期").GetComponent<TextMeshProUGUI>().text = DateTime.Now.AddDays(Random.Range(1, 100)).ToString("d");
        item.transform.Find("hor/批号").GetComponent<TextMeshProUGUI>().text = "24040910T" + (369 + Random.Range(1, 100)).ToString();
        item.transform.Find("hor/查看位置").GetComponent<Button>().onClick.AddListener(() => { UIMgr.Ins.OpenView<ConsumableLegendDialog>(new object[2] { false, (int)type }); });
        return item;
    }
}
