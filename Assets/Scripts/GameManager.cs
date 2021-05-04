using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    
    public Vector2 MinPosition { get; private set; }
    public Vector2 MaxPosition { get; private set; }

    [SerializeField]
    private GameObject enemyPrefab;

    private void Start()
    {
        MinPosition = new Vector2(-3f, -1.5f);
        MaxPosition = new Vector2(3f, 1.5f);        
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1f);
    }

    // TODO: GameManager에 적을 생성하는 스크립트를 만드세요.
    // 1) enemyPrefab에 들어갈 프리팹을 먼저 만들어야 합니다.
    // 2) enemyPrefab 변수를 Inspector에서 채워줘야 합니다.
    // 3) 적의 위치는 x 위치를 5f로 고정, y 위치는 랜덤으로 생성합니다.
}
