using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MachinePlanform : MonoBehaviour
{
    List<Toggle> PCRQualityControl = new List<Toggle>();
    List<Toggle> AXEProteinaseK = new List<Toggle>();
    List<Toggle> AXEPrepare = new List<Toggle>();
    List<Toggle> PCRSystem = new List<Toggle>();
    List<Toggle> PCRCalibration = new List<Toggle>();
    List<Toggle> MagnetSleeve = new List<Toggle>();
    List<Toggle> Tips1000 = new List<Toggle>();
    List<Toggle> Paraffin = new List<Toggle>();
    List<Toggle> PorePlate16 = new List<Toggle>();
    List<Toggle> MembraneSupport = new List<Toggle>();
    List<Toggle> Tips50 = new List<Toggle>();
    List<Toggle> Tips200 = new List<Toggle>();
    List<Toggle> AxeKitBox = new List<Toggle>();

    List<Toggle> allToggle = new List<Toggle>();

    List<Toggle> allReagent = new List<Toggle>();
    List<Toggle> allConsumable = new List<Toggle>();

    private void Awake()
    {
        foreach (var _tg in GetComponentsInChildren<Toggle>())
        {
            if (_tg.name.Contains("PCR�ʿ�Ʒ"))
                PCRQualityControl.Add(_tg);
            if (_tg.name.Contains("�����Լ���"))
                AXEProteinaseK.Add(_tg);
            if (_tg.name.Contains("�����Լ���"))
                AXEPrepare.Add(_tg);
            if (_tg.name.Contains("PCR�Լ�"))
                PCRSystem.Add(_tg);
            if (_tg.name.Contains("PCR�Լ�"))
                PCRCalibration.Add(_tg);
            if (_tg.name.Contains("�Ű��׺�"))
                MagnetSleeve.Add(_tg);
            if (_tg.name.Contains("100ulǹͷ��"))
                Tips1000.Add(_tg);
            if (_tg.name.Contains("ʯ����"))
                Paraffin.Add(_tg);
            if (_tg.name.Contains("16�װ�"))
                PorePlate16.Add(_tg);
            if (_tg.name.Contains("Ĥ��"))
                MembraneSupport.Add(_tg);
            if (_tg.name.Contains("50ulǹͷ��"))
                Tips50.Add(_tg);
            if (_tg.name.Contains("200ulǹͷ��"))
                Tips200.Add(_tg);
            if (_tg.name.Contains("�����Լ���"))
                AxeKitBox.Add(_tg);
            allToggle.Add(_tg);
        }

        allToggle.ForEach((Toggle _tg) =>
        {
            _tg.interactable = false;
            _tg.image.raycastTarget = false;
            _tg.graphic.raycastTarget = false;
            if (_tg.name.Contains("PCR�ʿ�Ʒ") || _tg.name.Contains("�����Լ���") || _tg.name.Contains("PCR�Լ�"))
            {
                allReagent.Add(_tg);
            }
            else
            {
                allConsumable.Add(_tg);
            }
        });
        if (name == "�Լ�")
        {
            allReagent.ForEach((Toggle _tg) =>
            {
                _tg.isOn = true;
            });
        }
        if (name == "�Ĳ�")
        {
            allConsumable.ForEach((Toggle _tg) =>
            {
                _tg.isOn = true;
            });
        }
    }

    public List<Toggle> GetReagent(ReagentType _reagent)
    {
        switch (_reagent)
        {
            case ReagentType.PCRQualityControl:
                return PCRQualityControl;
            case ReagentType.AXELieJie:
            case ReagentType.AXEXiYe:
            case ReagentType.AXEXiTuoYe:
            case ReagentType.AXECiZhuHunXuanYe:
                return AXEProteinaseK;
            case ReagentType.AXEPrepare:
                return AXEPrepare;
            case ReagentType.PCRFanYing:
            case ReagentType.PCRMei:
            case ReagentType.PCRShiFang:
                return PCRSystem;
            case ReagentType.PCRCalibration:
                return PCRCalibration;
        }
        return null;
    }

    public List<Toggle> GetConsumable(ConsumableType _consumable)
    {
        switch (_consumable)
        {
            case ConsumableType.MagnetSleeve:
                return MagnetSleeve;
            case ConsumableType.Tips1000:
                return Tips1000;
            case ConsumableType.Paraffin:
                return Paraffin;
            case ConsumableType.PorePlate16:
                return PorePlate16;
            case ConsumableType.MembraneSupport:
                return MembraneSupport;
            case ConsumableType.Tips50:
                return Tips50;
            case ConsumableType.Tips200:
                return Tips200;
            case ConsumableType.AxeKitBox:
                return AxeKitBox;
        }
        return null;
    }

    public void ShowReagent(ReagentType _reagent, bool _show)
    {
        allReagent.ForEach((Toggle tg) => { tg.interactable = true; });
        allConsumable.ForEach((Toggle tg) => { tg.interactable = false; });
        GetReagent(_reagent)?.ForEach((Toggle tg) => { tg.isOn = _show; });
    }

    public void ShowConsumable(ConsumableType _consumable, bool _show)
    {
        allReagent.ForEach((Toggle tg) => { tg.interactable = false; });
        allConsumable.ForEach((Toggle tg) => { tg.interactable = true; });
        GetConsumable(_consumable)?.ForEach((Toggle tg) => { tg.isOn = _show; });
    }

    public void setAll(bool _ison)
    {

        allToggle.ForEach((Toggle _tg) =>
        {
            _tg.isOn = _ison;
        });
    }

    public void setReagentEnable(bool _enable)
    {
        allReagent.ForEach((Toggle tg) => { tg.interactable = _enable; });
    }

    public void setConsumableEnable(bool _enable)
    {
        allConsumable.ForEach((Toggle tg) => { tg.interactable = _enable; });
    }
}
