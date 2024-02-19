using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Potion", menuName = "Potion")]
public class PotionSO : ScriptableObject
{
    [Header("���ǵ��� �����ϱ� ���� ��ũ���ͺ������Ʈ")]

    [Header("���� ������")]
    public Sprite potionIcon;

    [Header("���� / �κ��丮 ��� �������� �������� ���� ������")]
    public Sprite selectIcon;

    [Header("������ �̸�")]
    public string potionName;

    [Header("������ ī�װ�")]
    // ex) 0, 1, 2 ������ ���ؼ� ���� ���, ������, �ü� Ÿ���� ���谡���� ��ȣ�ϵ���.
    // �ڵ� �ۼ� ���� : if ������ potionCategory == 0 ������ ���� ��, ��� Ÿ���� ���谡 ���� �Ķ��� ��ǳ�� ���, ���� ���� ��ũ��Ʈ �ۼ� ��
    public int potionCategory;

    [Header("������ ��� S A B C D E F")]
    public string potionGrade;

    [Header("������ ����")]
    [TextArea(1, 10)]
    public string potionDescription;

    [Header("������ ���� ����")]
    public int havePotion;

    [Header("������ ����")]
    public int potionPrice;

    // ���� �� �ʿ��� ������ ���� �� �ۼ�
    //[Header("������ ����")]
    //[TextArea(1, 20)] �ؽ�Ʈ ������, �ʿ� �� �ۼ�
    //public string plus; ���� Ÿ�԰� ������ ����

}
