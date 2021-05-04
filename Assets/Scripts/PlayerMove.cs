using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region DontTouchThis
    [Header("�̵� �ӵ�")]
    [SerializeField]
    private float speed = 2f;
    [Header("�Ѿ� ������")]
    [SerializeField]
    private GameObject bulletPrefab = null;
    [Header("�Ѿ� �߻簣��")]
    [SerializeField]
    private float bulletDelay = 0.5f;    
    private Animator animator = null;

    private void SetAnimation()
    {

    }
    #endregion

    private Vector2 targetPosition = Vector2.zero;

    private void Start()
    {
        animator = GetComponent<Animator>();
        // TODO: GameManager�� ����������.
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            // TODO: ��� ������ GameManager���� ����������.
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private IEnumerator Fire()
    {
        // �Ѿ� �߻� ��ũ��Ʈ�� �ۼ��� �ּ���.
        yield return new WaitForSeconds(bulletDelay);
    }
}
