using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [Header("�̵� �ӵ�")]
    [SerializeField]
    private float speed = 10f;

    private void Start()
    {
        // TODO : GameManager�� ����������.
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    // TODO: �Ѿ��� ��迵������ ����� ������� �ۼ��� ������.
    // 1) ��迵���� GameManager�� �ִ� ���� ����ؾ� �մϴ�.
}
