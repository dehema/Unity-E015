using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Լ�
public enum Reagent
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
public enum Consumable
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
    public string getReagentName(Reagent _reagent)
    {
        switch (_reagent)
        {
            case Reagent.PCRQualityControl:
                return "PCR�ʿ�Ʒ";
            case Reagent.AXEProteinaseK:
                return "���ᵰ��øK";
            case Reagent.AXEPrepare:
                return "�����Ʊ�";
            case Reagent.PCRSystem:
                return "PCR������ϵ";
            case Reagent.PCRCalibration:
                return "PCR����";
            default:
                return "";
        }
    }

    public string getConsumableName(Consumable _consumable)
    {
        switch (_consumable)
        {
            case Consumable.MagnetSleeve:
                return "��ת�Ű���";
            case Consumable.Tips100:
                return "100ulǹͷ��";
            case Consumable.Paraffin:
                return "ʯ����";
            case Consumable.PorePlate16:
                return "16�װ�";
            case Consumable.MembraneSupport:
                return "Ĥ��";
            case Consumable.Tips50:
                return "50ulǹͷ��";
            case Consumable.Tips200:
                return "200ulǹͷ��";
            case Consumable.AxeKitBox:
                return "�����Լ���";
            default:
                return "";
        }
    }
}
