using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [HideInInspector]
    public bool isGameStart = false;
    [HideInInspector]
    public bool isPlayerTurn = false;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        isGameStart = false;
    }
    void SlapCharging()
    {
        if(isPlayerTurn == true)
        {
            //플레이어 파워바 활성화 및 동작
        }
        else
        {
            //적 파워바 활성화 및 동작
        }
    }
}
