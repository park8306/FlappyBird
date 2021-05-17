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
        // 마우스 클릭, 혹은 스페이스 바
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Vector2 force;
            force.x = 0;
            force.y = forceY;
            rigidbody2D.AddForce(force);

            animator.Play("Flap", 0, 0);
            // 날개 펄럭이는 애니메이션

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 새 죽음
        // 죽는 애니메이션 하자.
        animator.Play("Die", 0, 0);

        // 게임 오버 UI표시
        GameManager.instance.SetGameOver();

        // 스크롤화면 멈춤
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.AddScore();
    }
}
