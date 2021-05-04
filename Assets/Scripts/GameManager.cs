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

    // TODO: GameManager�� ���� �����ϴ� ��ũ��Ʈ�� ���弼��.
    // 1) enemyPrefab�� �� �������� ���� ������ �մϴ�.
    // 2) enemyPrefab ������ Inspector���� ä����� �մϴ�.
    // 3) ���� ��ġ�� x ��ġ�� 5f�� ����, y ��ġ�� �������� �����մϴ�.
}
