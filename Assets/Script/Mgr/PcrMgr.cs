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
    /// 核提裂解液
    /// </summary>
    AXELieJie,
    /// <summary>
    /// 核提洗液
    /// </summary>
    AXEXiYe,
    /// <summary>
    /// 核提洗脱液
    /// </summary>
    AXEXiTuoYe,
    /// <summary>
    /// 核提磁珠混悬液
    /// </summary>
    AXECiZhuHunXuanYe,
    /// <summary>
    /// 核提制备
    /// </summary>
    AXEPrepare,
    /// <summary>
    /// PCR扩增体系
    /// </summary>
    PCRFanYing,
    /// <summary>
    /// PCR酶
    /// </summary>
    PCRMei,
    /// <summary>
    /// PCR核酸释放剂
    /// </summary>
    PCRShiFang,
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
            case ReagentType.AXELieJie:
                return "核提裂解液";
            case ReagentType.AXEXiYe:
                return "核提洗液";
            case ReagentType.AXEXiTuoYe:
                return "核提洗脱液";
            case ReagentType.AXECiZhuHunXuanYe:
                return "核提磁珠混悬液";
            case ReagentType.AXEPrepare:
                return "核提制备";
            case ReagentType.PCRFanYing:
                return "PCR反应液";
            case ReagentType.PCRMei:
                return "PCR酶";
            case ReagentType.PCRShiFang:
                return "PCR核酸释放剂";
            case ReagentType.PCRCalibration:
                return "PCR定标";
            default:
                return "";
        }
    }

    public string getReagentType(ReagentType _reagent)
    {
        string name;
        if (_reagent == ReagentType.AXECiZhuHunXuanYe || _reagent == ReagentType.AXELieJie || _reagent == ReagentType.AXEPrepare || _reagent == ReagentType.AXEXiTuoYe || _reagent == ReagentType.AXEXiYe)
        {
            return "核提制备体系";
        }
        else if (_reagent == ReagentType.PCRMei || _reagent == ReagentType.PCRFanYing || _reagent == ReagentType.PCRShiFang)
        {
            return "PCR扩提体系";
        }
        else
        {
            name = getReagentName(_reagent);
        }
        return name;
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
