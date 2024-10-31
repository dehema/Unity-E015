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
    /// ���ᵰ��øK
    /// </summary>
    AXEProteinaseK,
    /// <summary>
    /// �����Ʊ�
    /// </summary>
    AXEPrepare,
    /// <summary>
    /// PCR������ϵ
    /// </summary>
    PCRSystem,
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
            case ReagentType.AXEProteinaseK:
                return "���ᵰ��øK";
            case ReagentType.AXEPrepare:
                return "�����Ʊ�";
            case ReagentType.PCRSystem:
                return "PCR������ϵ";
            case ReagentType.PCRCalibration:
                return "PCR����";
            default:
                return "";
        }
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
