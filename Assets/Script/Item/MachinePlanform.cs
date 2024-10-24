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
    List<Toggle> Tips100 = new List<Toggle>();
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
            if (_tg.name.Contains("PCRÖÊ¿ØÆ·"))
                PCRQualityControl.Add(_tg);
            if (_tg.name.Contains("ºËÌáÊÔ¼Á´¬"))
                AXEProteinaseK.Add(_tg);
            if (_tg.name.Contains("ºËÌáÊÔ¼Á´¬"))
                AXEPrepare.Add(_tg);
            if (_tg.name.Contains("PCRÊÔ¼Á"))
                PCRSystem.Add(_tg);
            if (_tg.name.Contains("PCRÊÔ¼Á"))
                PCRCalibration.Add(_tg);
            if (_tg.name.Contains("´Å°ôÌ×ºÐ"))
                MagnetSleeve.Add(_tg);
            if (_tg.name.Contains("100ulÇ¹Í·ºÐ"))
                Tips100.Add(_tg);
            if (_tg.name.Contains("Ê¯À¯ÓÍ"))
                Paraffin.Add(_tg);
            if (_tg.name.Contains("16¿×°å"))
                PorePlate16.Add(_tg);
            if (_tg.name.Contains("Ä¤¼Ü"))
                MembraneSupport.Add(_tg);
            if (_tg.name.Contains("50ulÇ¹Í·ºÐ"))
                Tips50.Add(_tg);
            if (_tg.name.Contains("200ulÇ¹Í·ºÐ"))
                Tips200.Add(_tg);
            if (_tg.name.Contains("ºËÌáÊÔ¼ÁºÐ"))
                AxeKitBox.Add(_tg);
            allToggle.Add(_tg);
        }

        allToggle.ForEach((Toggle _tg) =>
        {
            _tg.interactable = false;
            _tg.image.raycastTarget = false;
            _tg.graphic.raycastTarget = false;
            if (_tg.name.Contains("PCRÖÊ¿ØÆ·") || _tg.name.Contains("ºËÌáÊÔ¼Á´¬") || _tg.name.Contains("PCRÊÔ¼Á"))
            {
                allReagent.Add(_tg);
            }
            else
            {
                allConsumable.Add(_tg);
            }
        });
        if (name == "ÊÔ¼Á")
        {
            allReagent.ForEach((Toggle _tg) =>
            {
                _tg.isOn = true;
            });
        }
        if (name == "ºÄ²Ä")
        {
            allConsumable.ForEach((Toggle _tg) =>
            {
                _tg.isOn = true;
            });
        }
    }

    public List<Toggle> GetReagent(Reagent _reagent)
    {
        switch (_reagent)
        {
            case Reagent.PCRQualityControl:
                break;
            case Reagent.AXEProteinaseK:
                break;
            case Reagent.AXEPrepare:
                break;
            case Reagent.PCRSystem:
                break;
            case Reagent.PCRCalibration:
                break;
        }
        return null;
    }

    public List<Toggle> GetConsumable(Consumable _consumable)
    {
        switch (_consumable)
        {
            case Consumable.MagnetSleeve:
                break;
            case Consumable.Tips100:
                break;
            case Consumable.Paraffin:
                break;
            case Consumable.PorePlate16:
                break;
            case Consumable.MembraneSupport:
                break;
            case Consumable.Tips50:
                break;
            case Consumable.Tips200:
                break;
            case Consumable.AxeKitBox:
                break;
        }
        return null;
    }

    public void SetReagentShow(Reagent _reagent, bool _show)
    {
        GetReagent(_reagent).ForEach((Toggle tg) => { tg.isOn = _show; });
    }

    public void GetConsumable(Consumable _consumable, bool _show)
    {
        GetConsumable(_consumable).ForEach((Toggle tg) => { tg.isOn = _show; });
    }
}
