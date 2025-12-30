using UnityEngine;

public class Player : MonoBehaviour, ISlapSystem
{
    public int HP { get; private set; } = 5;

    //피격 구현
    public void Hit()
    {
        HP -= 1;
        if (HP == 0)
        {
            Destroy(gameObject);
            //게임오버 씬 로드
        }
    }
    public void Slap(ISlapSystem target)
    {
        // 파워바 판정에 따른 공격
    }
    void OnDestroy()
    {
        //점수 환산
    }


}
