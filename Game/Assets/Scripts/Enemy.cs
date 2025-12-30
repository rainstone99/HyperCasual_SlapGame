using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, ISlapSystem
{
    public EnemyList enemyList;
    public int HP { get; private set; }
    public string Name { get; private set; }
    public int Level { get; private set; }
    public Image enemyImage;
    void EnemySelect(int _level)
    {
        HP = enemyList.HP;
        Name = enemyList.name;
        Level = enemyList.Level;
        enemyImage.sprite = enemyList.enemyImage;
    }

    void EnemyHit()
    {
        
    }
    public void Hit()
    {
        enemyImage.sprite = enemyList.enemyHitImage; // 피격이미지 말고 색 점등으로 대체 가능
        HP -= 1;
    }

    public void Slap(ISlapSystem target)
    {
        int enemyattack = Random.Range(1, 2); //적 레벨에 따라서 시간이 바뀌게 해야함
        if(enemyattack > 61 && enemyattack < 81) // 확률에 따라서 공격 성공 시
        {
            target.Hit();
        }
    }
}
