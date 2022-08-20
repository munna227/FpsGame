using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject retrylevel;
    public void Level_1() 
    {
        StaticObject.playerdamageAmount = 0f;
        Enemy.enemyCount = 0;
        StaticObject.Enemy = 4;
      
        SceneManager.LoadScene("MainScene");
    }

    public void Level_2()
    {
        StaticObject.playerdamageAmount = 0f;
        Enemy.enemyCount = 0;
        StaticObject.Enemy = 8;
        SceneManager.LoadScene("MainScene");
    }

    public void Level_3()
    {
        StaticObject.playerdamageAmount = 0f;
        Enemy.enemyCount = 0;
        StaticObject.Enemy = 10;
        SceneManager.LoadScene("MainScene");
    }

    public void Level_4()
    {
        StaticObject.playerdamageAmount = 0f;
        Enemy.enemyCount = 0;
        StaticObject.Enemy = 12;
        SceneManager.LoadScene("MainScene");
    }

    public void Level_5()
    {
        StaticObject.playerdamageAmount = 0f;
        Enemy.enemyCount = 0;
        StaticObject.Enemy = 15;
        SceneManager.LoadScene("MainScene");
    }



}
