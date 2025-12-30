using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObject/EnemyData", order = int.MaxValue)]
public class EnemyList : ScriptableObject {
    public string enemyName;
    public int HP { get; private set;}
    public Sprite enemyImage;
    public Sprite enemyHitImage; // 피격이미지 넣지 말고 색 점등으로 바꿔도 됨
    public int Level { get; private set; }

}