using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [Header("��ũ�� ���ǵ�")]
    [SerializeField]
    private float speed = 0.5f;

    private Vector2 offset = Vector2.zero;
    private MeshRenderer meshRenderer = null;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        offset.x += speed * Time.deltaTime;
        meshRenderer.material.SetTextureOffset("_MainTex", offset);
    }
}