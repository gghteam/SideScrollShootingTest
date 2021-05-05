using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    #region DontTouchThis
    [Header("이동 속도")]
    [SerializeField]
    private float speed = 2f;
    [Header("총알 프리팹")]
    [SerializeField]
    private GameObject bulletPrefab = null;
    [Header("총알 발사간격")]
    [SerializeField]
    private float bulletDelay = 0.5f;    
    private Animator animator = null;

    private void SetAnimation(Vector2 targetPosition) {
        if(transform.position.x > targetPosition.x) {
            animator.Play("Player_Left");
        }
        else if(transform.position.x < targetPosition.x) {
            animator.Play("Player_Right");
        }
        else {
            animator.Play("Player_Idle");
        }
    }
    #endregion

    private Vector2 targetPosition = Vector2.zero;

    private void Start()
    {
        animator = GetComponent<Animator>();
        // TODO: GameManager를 가져오세요.
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SetAnimation(targetPosition);
            // TODO: 경계 영역을 GameManager에서 가져오세요.
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

    private IEnumerator Fire()
    {
        // TODO: 총알 발사 스크립트를 작성해 주세요.
        yield return new WaitForSeconds(bulletDelay);
    }
}
