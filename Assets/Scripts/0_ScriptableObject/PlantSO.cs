using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant")]
public class PlantSO : ScriptableObject
{
    [Header("작물들을 생성하기 위한 스크립터블오브젝트")]

    [Header("씨앗 아이콘")]
    public Sprite seedIcon;

    [Header("모종 아이콘")]
    public Sprite seedlingIcon;

    [Header("성장기 아이콘")]
    public Sprite growingIcon;

    [Header("수확기 아이콘")]
    public Sprite harvestIcon;

    [Header("작물 아이콘")]
    public Sprite plantIcon;

    [Header("상점 / 인벤토리 등에서 아이템을 선택했을 때의 아이콘")]
    public Sprite selectIcon;

    [Header("작물의 카테고리 0:뿌리 식물 1:속씨 식물 2:양치 식물 3:균류")]
    public int plantCategory;

    [Header("작물의 이름")]
    public string plantName;

    [Header("작물의 품질 S A B C D E F")] // 제대로 키운 작물일 경우 S
    public string plantQuality;

    [Header("작물 신선도 0~100%")] // 100부터 시작하는 게이지 형태로 만들어서 점점 감소
    public int plantFresh;

    [Header("작물의 설명")]
    [TextArea(1, 10)]
    public string plantDescription;

    [Header("작물의 소지 갯수")]
    public int havePlant;

    [Header("작물의 가격")]
    public int plantPrice;

    // 이후 더 필요한 변수가 있을 시 작성
    //[Header("변수의 설명")]
    //[TextArea(1, 20)] 텍스트 에리어, 필요 시 작성
    //public string plus; 변수 타입과 변수명 설정

}
