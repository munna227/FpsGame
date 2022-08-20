using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Image health;
    public Camera cameras;
   // public static float enemys;
    // Start is called before the first frame update
   /* private void Start()
    {
         health.fillAmount = 1f;
        //Instantiate prefab 
      //  GameObject obj = Instantiate(Enemy);

       

    }*/

    // Update is called once per frame
    void Update()
    {
        transform.forward = cameras.transform.forward;
        //health.fillAmount =Enemy.enemyHP;

    }
}
