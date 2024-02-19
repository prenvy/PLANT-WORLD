using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Potion", menuName = "Potion")]
public class PotionSO : ScriptableObject
{
    [Header("포션들을 생성하기 위한 스크립터블오브젝트")]

    [Header("포션 아이콘")]
    public Sprite potionIcon;

    [Header("상점 / 인벤토리 등에서 아이템을 선택했을 때의 아이콘")]
    public Sprite selectIcon;

    [Header("포션의 이름")]
    public string potionName;

    [Header("포션의 카테고리")]
    // ex) 0, 1, 2 등으로 정해서 각각 기사, 마법사, 궁수 타입의 모험가들이 선호하도록.
    // 코드 작성 예시 : if 문으로 potionCategory == 0 포션이 있을 때, 기사 타입의 모험가 위에 파란색 말풍선 출력, 가격 지불 스크립트 작성 등
    public int potionCategory;

    [Header("포션의 등급 S A B C D E F")]
    public string potionGrade;

    [Header("포션의 설명")]
    [TextArea(1, 10)]
    public string potionDescription;

    [Header("포션의 소지 갯수")]
    public int havePotion;

    [Header("포션의 가격")]
    public int potionPrice;

    // 이후 더 필요한 변수가 있을 시 작성
    //[Header("변수의 설명")]
    //[TextArea(1, 20)] 텍스트 에리어, 필요 시 작성
    //public string plus; 변수 타입과 변수명 설정

}
