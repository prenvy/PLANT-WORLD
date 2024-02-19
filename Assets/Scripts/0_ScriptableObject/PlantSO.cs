using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant")]
public class PlantSO : ScriptableObject
{
    [Header("�۹����� �����ϱ� ���� ��ũ���ͺ������Ʈ")]

    [Header("���� ������")]
    public Sprite seedIcon;

    [Header("���� ������")]
    public Sprite seedlingIcon;

    [Header("����� ������")]
    public Sprite growingIcon;

    [Header("��Ȯ�� ������")]
    public Sprite harvestIcon;

    [Header("�۹� ������")]
    public Sprite plantIcon;

    [Header("���� / �κ��丮 ��� �������� �������� ���� ������")]
    public Sprite selectIcon;

    [Header("�۹��� ī�װ� 0:�Ѹ� �Ĺ� 1:�Ӿ� �Ĺ� 2:��ġ �Ĺ� 3:�շ�")]
    public int plantCategory;

    [Header("�۹��� �̸�")]
    public string plantName;

    [Header("�۹��� ǰ�� S A B C D E F")] // ����� Ű�� �۹��� ��� S
    public string plantQuality;

    [Header("�۹� �ż��� 0~100%")] // 100���� �����ϴ� ������ ���·� ���� ���� ����
    public int plantFresh;

    [Header("�۹��� ����")]
    [TextArea(1, 10)]
    public string plantDescription;

    [Header("�۹��� ���� ����")]
    public int havePlant;

    [Header("�۹��� ����")]
    public int plantPrice;

    // ���� �� �ʿ��� ������ ���� �� �ۼ�
    //[Header("������ ����")]
    //[TextArea(1, 20)] �ؽ�Ʈ ������, �ʿ� �� �ۼ�
    //public string plus; ���� Ÿ�԰� ������ ����

}
