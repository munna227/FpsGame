using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{


    public GameObject bloodOverlay;


    void Start()
    {
        StaticObject.isGameOver = false;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (StaticObject.isGameOver)
        {
            SceneManager.LoadScene("Main Menu");
        }
     
    }

    public IEnumerator TakeDamage()
    {
        bloodOverlay.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        bloodOverlay.SetActive(false);

    }
}
