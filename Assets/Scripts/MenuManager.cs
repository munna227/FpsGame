using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject levelObject;
    // Start is called before the first frame update
   /* void Start()
    {
        
    }
   */
    // Update is called once per frame
    void Update()
    {
        Exit();
    }
   public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Level()
    {
        
        levelObject.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
