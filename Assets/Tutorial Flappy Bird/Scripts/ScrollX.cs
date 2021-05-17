using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollX : MonoBehaviour
{

    public float minX = -21;
    public float speedX = -1;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < minX)
        {
            // 오른쪽으로 가로 크기 * 2 만큼 보내자.
            // 가로 크기 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }
        transform.Translate(speedX * Time.deltaTime, 0, 0);


    }
}
