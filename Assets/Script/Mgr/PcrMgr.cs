using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//试剂
public enum Reagent
{
    /// <summary>
    /// PCR质控品
    /// </summary>
    PCRQualityControl,
    /// <summary>
    /// 核提蛋白酶K
    /// </summary>
    AXEProteinaseK,
    /// <summary>
    /// 核提制备
    /// </summary>
    AXEPrepare,
    /// <summary>
    /// PCR扩增体系
    /// </summary>
    PCRSystem,
    /// <summary>
    /// PCR定标
    /// </summary>
    PCRCalibration,
}

//耗材
public enum Consumable
{
    /// <summary>
    /// 磁棒套
    /// </summary>
    MagnetSleeve,
    /// <summary>
    /// 100ul枪头盒
    /// </summary>
    Tips100,
    /// <summary>
    /// 石蜡油
    /// </summary>
    Paraffin,
    /// <summary>
    /// 16孔板
    /// </summary>
    PorePlate16,
    /// <summary>
    /// 膜架
    /// </summary>
    MembraneSupport,
    /// <summary>
    /// 50ul枪头盒
    /// </summary>
    Tips50,
    /// <summary>
    /// 200ul枪头盒
    /// </summary>
    Tips200,
    /// <summary>
    /// 核提试剂盒
    /// </summary>
    AxeKitBox,
}

public class PcrMgr : MonoSingleton<PcrMgr>
{
    public string getReagentName(Reagent _reagent)
    {
        switch (_reagent)
        {
            case Reagent.PCRQualityControl:
                return "PCR质控品";
            case Reagent.AXEProteinaseK:
                return "核提蛋白酶K";
            case Reagent.AXEPrepare:
                return "核提制备";
            case Reagent.PCRSystem:
                return "PCR扩增体系";
            case Reagent.PCRCalibration:
                return "PCR定标";
            default:
                return "";
        }
    }

    public string getConsumableName(Consumable _consumable)
    {
        switch (_consumable)
        {
            case Consumable.MagnetSleeve:
                return "旋转磁棒套";
            case Consumable.Tips100:
                return "100ul枪头盒";
            case Consumable.Paraffin:
                return "石蜡油";
            case Consumable.PorePlate16:
                return "16孔板";
            case Consumable.MembraneSupport:
                return "膜架";
            case Consumable.Tips50:
                return "50ul枪头盒";
            case Consumable.Tips200:
                return "200ul枪头盒";
            case Consumable.AxeKitBox:
                return "核提试剂盒";
            default:
                return "";
        }
    }
}
