using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Consumable : MonoBehaviour
{
    //�Լ�
    public Toggle tgReagent;
    //�Ĳ�
    public Toggle tgConsumable;
    //�Լ�
    public GameObject tbReagent;
    //�Ĳ�
    public GameObject tbConsumable;

    public MachinePlanform planform;

    public void Start()
    {
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

    void RefreshTbReagent()
    {
        Transform content = tbReagent.transform.Find("Viewport/Content");
        for (int i = 0; i < content.childCount; i++)
        {
            if (i >= 3)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
        Array values = Enum.GetValues(typeof(ReagentType));
        foreach (ReagentType item in values)
        {
            addReagentItem(item);
        }
    }

    void addReagentItem(ReagentType _type)
    {
        Transform content = tbReagent.transform.Find("Viewport/Content");
        GameObject item = Instantiate(content.Find("item").gameObject, content);
        item.SetActive(true);
        item.transform.Find("Toggle").GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
        {
            planform.ShowReagent(_type, _isOn);
        });
        item.transform.Find("����").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getReagentName(_type);
        item.transform.Find("ʣ������").GetComponent<TextMeshProUGUI>().text = Random.Range(1, 100).ToString();
        item.transform.Find("ʧЧ����").GetComponent<TextMeshProUGUI>().text = DateTime.Now.AddDays(Random.Range(1, 100)).ToString("d");
        item.transform.Find("����").GetComponent<TextMeshProUGUI>().text = "24040910T" + (369 + Random.Range(1, 100)).ToString();

        Instantiate(content.Find("line").gameObject, content).SetActive(true);
    }

    void RefreshTbConsumable()
    {
        Transform content = tbConsumable.transform.Find("Viewport/Content");
        for (int i = 0; i < content.childCount; i++)
        {
            if (i >= 3)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
        Array values = Enum.GetValues(typeof(ConsumableType));
        foreach (ConsumableType item in values)
        {
            addConsumableItem(item);
        }
    }

    void addConsumableItem(ConsumableType _type)
    {
        Transform content = tbConsumable.transform.Find("Viewport/Content");
        GameObject item = Instantiate(content.Find("item").gameObject, content);
        item.SetActive(true);
        item.transform.Find("Toggle").GetComponent<Toggle>().onValueChanged.AddListener((bool _isOn) =>
        {
            planform.ShowConsumable(_type, _isOn);
        });
        item.transform.Find("����").GetComponent<TextMeshProUGUI>().text = PcrMgr.Ins.getConsumableName(_type);
        item.transform.Find("ʣ������").GetComponent<TextMeshProUGUI>().text = Random.Range(1, 100).ToString();
        item.transform.Find("ʧЧ����").GetComponent<TextMeshProUGUI>().text = DateTime.Now.AddDays(Random.Range(1, 100)).ToString("d");
        item.transform.Find("����").GetComponent<TextMeshProUGUI>().text = "24040910T" + (369 + Random.Range(1, 100)).ToString();

        Instantiate(content.Find("line").gameObject, content).SetActive(true);
    }
}
