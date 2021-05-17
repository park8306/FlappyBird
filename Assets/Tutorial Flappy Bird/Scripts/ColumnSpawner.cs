using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{

    public GameObject column;
    public float delay = 3;
    public float random = 1.5f;
    public float spawnX = 4;
    public float spawnYmax = 1;
    public float spawnYmin = -2;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        // 3초 간격으로 배치, 
        // 배치 할 때 y값은 랜덤으로
        // 스폰시키는 x값은 고정값.
        while (true)
        {
            Vector3 pos;
            pos.z = 0;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax);
            Instantiate(column, pos, column.transform.rotation);

            yield return new WaitForSeconds(delay + Random.Range(-random, random));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
