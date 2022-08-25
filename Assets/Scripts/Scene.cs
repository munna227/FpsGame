using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public Gui gui;
    public GameObject nextlevel;
    public GameObject retrylevel;


    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public  void Update()
    {
        
    }
    public  void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
    } 
    public void Next()
    {
        SceneManager.LoadScene("Main Menu");
        

    }
    public void GoBack()
    {
        SceneManager.LoadScene("Main Menu");

    }
}
