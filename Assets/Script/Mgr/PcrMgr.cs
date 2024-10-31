using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//试剂
public enum ReagentType
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
public enum ConsumableType
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
    public string getReagentName(ReagentType _reagent)
    {
        switch (_reagent)
        {
            case ReagentType.PCRQualityControl:
                return "PCR质控品";
            case ReagentType.AXEProteinaseK:
                return "核提蛋白酶K";
            case ReagentType.AXEPrepare:
                return "核提制备";
            case ReagentType.PCRSystem:
                return "PCR扩增体系";
            case ReagentType.PCRCalibration:
                return "PCR定标";
            default:
                return "";
        }
    }

    public string getConsumableName(ConsumableType _consumable)
    {
        switch (_consumable)
        {
            case ConsumableType.MagnetSleeve:
                return "旋转磁棒套";
            case ConsumableType.Tips100:
                return "100ul枪头盒";
            case ConsumableType.Paraffin:
                return "石蜡油";
            case ConsumableType.PorePlate16:
                return "16孔板";
            case ConsumableType.MembraneSupport:
                return "膜架";
            case ConsumableType.Tips50:
                return "50ul枪头盒";
            case ConsumableType.Tips200:
                return "200ul枪头盒";
            case ConsumableType.AxeKitBox:
                return "核提试剂盒";
            default:
                return "";
        }
    }
}
