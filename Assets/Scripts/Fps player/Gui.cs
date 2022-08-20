using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gui : MonoBehaviour
{
    public Text enemytext = null;
    public Image playerhelthimage;
    public int playerHelth = 100;
    public int totalEnemy;


    public GameObject nextlevel;
    public GameObject retrylevel;

    public FpsCamera fpscamScript;
    public FpsPlayer fpsPlayerScript;

    
    
    public GameObject Gun;
    public static float damage; 
   


   

    // Start is called before the first frame update
    void Start()
    {
        playerhelthimage.fillAmount = 1f;
        // lavel = GetComponent<level>();
        totalEnemy = StaticObject.Enemy;
        Time.timeScale = 1;



    }

    // Update is called once per frame
    void Update()
    {
        PLayerHealth();
        EnemyDieCount();
        GameOver();

        Debug.Log("damage:" + damage);
    }
    void EnemyDieCount()
    {
        enemytext.text = Enemy.enemyCount.ToString() + "/" + (1 + StaticObject.Enemy).ToString();
    }
    void PLayerHealth()

    {
        damage = (1f - StaticObject.playerdamageAmount);
        playerhelthimage.fillAmount = damage;


    }
    void GameOver()
    {

        if (Enemy.enemyCount == (totalEnemy + 1) && damage > 0)
        {

            nextlevel.gameObject.SetActive(true);
           
            Time.timeScale = 0;
            Cursor.visible = true;


        }


        if (Enemy.enemyCount < (totalEnemy + 1) && damage < 0)
        {
            retrylevel.gameObject.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }

    }
  
  
        }
    
