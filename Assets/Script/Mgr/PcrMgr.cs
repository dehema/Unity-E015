using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Լ�
public enum ReagentType
{
    /// <summary>
    /// PCR�ʿ�Ʒ
    /// </summary>
    PCRQualityControl,
    /// <summary>
    /// �����ѽ�Һ
    /// </summary>
    AXELieJie,
    /// <summary>
    /// ����ϴҺ
    /// </summary>
    AXEXiYe,
    /// <summary>
    /// ����ϴ��Һ
    /// </summary>
    AXEXiTuoYe,
    /// <summary>
    /// ����������Һ
    /// </summary>
    AXECiZhuHunXuanYe,
    /// <summary>
    /// �����Ʊ�
    /// </summary>
    AXEPrepare,
    /// <summary>
    /// PCR������ϵ
    /// </summary>
    PCRFanYing,
    /// <summary>
    /// PCRø
    /// </summary>
    PCRMei,
    /// <summary>
    /// PCR�����ͷż�
    /// </summary>
    PCRShiFang,
    /// <summary>
    /// PCR����
    /// </summary>
    PCRCalibration,
}

//�Ĳ�
public enum ConsumableType
{
    /// <summary>
    /// �Ű���
    /// </summary>
    MagnetSleeve,
    /// <summary>
    /// 100ulǹͷ��
    /// </summary>
    Tips100,
    /// <summary>
    /// ʯ����
    /// </summary>
    Paraffin,
    /// <summary>
    /// 16�װ�
    /// </summary>
    PorePlate16,
    /// <summary>
    /// Ĥ��
    /// </summary>
    MembraneSupport,
    /// <summary>
    /// 50ulǹͷ��
    /// </summary>
    Tips50,
    /// <summary>
    /// 200ulǹͷ��
    /// </summary>
    Tips200,
    /// <summary>
    /// �����Լ���
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
                return "PCR�ʿ�Ʒ";
            case ReagentType.AXELieJie:
                return "�����ѽ�Һ";
            case ReagentType.AXEXiYe:
                return "����ϴҺ";
            case ReagentType.AXEXiTuoYe:
                return "����ϴ��Һ";
            case ReagentType.AXECiZhuHunXuanYe:
                return "����������Һ";
            case ReagentType.AXEPrepare:
                return "�����Ʊ�";
            case ReagentType.PCRFanYing:
                return "PCR��ӦҺ";
            case ReagentType.PCRMei:
                return "PCRø";
            case ReagentType.PCRShiFang:
                return "PCR�����ͷż�";
            case ReagentType.PCRCalibration:
                return "PCR����";
            default:
                return "";
        }
    }

    public string getReagentType(ReagentType _reagent)
    {
        string name;
        if (_reagent == ReagentType.AXECiZhuHunXuanYe || _reagent == ReagentType.AXELieJie || _reagent == ReagentType.AXEPrepare || _reagent == ReagentType.AXEXiTuoYe || _reagent == ReagentType.AXEXiYe)
        {
            return "�����Ʊ���ϵ";
        }
        else if (_reagent == ReagentType.PCRMei || _reagent == ReagentType.PCRFanYing || _reagent == ReagentType.PCRShiFang)
        {
            return "PCR������ϵ";
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
                return "��ת�Ű���";
            case ConsumableType.Tips100:
                return "100ulǹͷ��";
            case ConsumableType.Paraffin:
                return "ʯ����";
            case ConsumableType.PorePlate16:
                return "16�װ�";
            case ConsumableType.MembraneSupport:
                return "Ĥ��";
            case ConsumableType.Tips50:
                return "50ulǹͷ��";
            case ConsumableType.Tips200:
                return "200ulǹͷ��";
            case ConsumableType.AxeKitBox:
                return "�����Լ���";
            default:
                return "";
        }
    }
}
