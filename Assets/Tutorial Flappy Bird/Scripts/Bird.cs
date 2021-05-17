using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public float forceY = 100;
    // Update is called once per frame
    void Update()
    {
        // ���콺 Ŭ��, Ȥ�� �����̽� ��
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Vector2 force;
            force.x = 0;
            force.y = forceY;
            rigidbody2D.AddForce(force);

            animator.Play("Flap", 0, 0);
            // ���� �޷��̴� �ִϸ��̼�

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �� ����
        // �״� �ִϸ��̼� ����.
        animator.Play("Die", 0, 0);

        // ���� ���� UIǥ��
        GameManager.instance.SetGameOver();

        // ��ũ��ȭ�� ����
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.AddScore();
    }
}
