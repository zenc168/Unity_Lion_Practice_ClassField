using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物一號")]
    public Enemy enemy1;
    
    [Header("怪物二號")]
    public Enemy enemy2;

    // Start is called before the first frame update
    void Start()
    {
        print(enemy1.nMagic);
        print(enemy2.sEquip);

        enemy1.nBlood = 100;
        enemy2.nBlood = 300;
        enemy1.nDefense = 50;
        enemy1.sWeapon = "木棍";
        enemy2.sWeapon = "短刀";
        enemy1.bKey= true;
        enemy2.bDropAsset = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
