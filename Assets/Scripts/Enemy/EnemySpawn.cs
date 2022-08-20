using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    private int xpos;
    private int zpos;
    private int enemycount;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {

        while (enemycount < StaticObject.Enemy)
        {
            xpos = Random.Range(-40, 40);
            zpos = Random.Range(-40, 40);
            Instantiate(enemy, new Vector3(xpos, 0.5f, zpos), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            enemycount++;

        }
        

    }
}

