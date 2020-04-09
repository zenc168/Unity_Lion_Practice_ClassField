using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("血量")]
    [Tooltip("怪物的血量"), Range(50, 500)]
    public int nBlood;

    [Header("魔力")]
    [Tooltip("怪物的魔力"), Range(10, 100)]
    public int nMagic = 100;

    [Header("能力值"), Range(10, 100)]
    public float fSpeed = 10.5f;
    
    [Range(20, 200)]
    public int nAttack = 50;

    [Range(0, 100)]
    public int nDefense;

    [Header("裝備")]
    public string sWeapon;
    
    public string sEquip = "皮衣";

    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙?")]
    public bool bKey = false;
    [Tooltip("怪物是否帶有寶物?")]
    public bool bDropAsset = false;


    
    
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
