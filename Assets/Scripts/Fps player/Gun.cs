using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public Transform fpsCam;
    public GameObject impactEffect;
    public ParticleSystem muzzleFlash;
    public float reloadTime = 2f;
    public float range = 20;
    public bool isanimator=false;
    protected float EnemydamageAmount = 0.1f;
    
    RaycastHit hit;

   



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           

            Fire();

        }
      


    }
    private void Fire()
    {

        SoundManager.Instance.PlaySound(SoundManager.Instance.Shoot);
        

        muzzleFlash.Play();

       
        if (Physics.Raycast(fpsCam.position + fpsCam.forward, fpsCam.forward, out hit, range))
        {
            if (hit.collider != null) { 
                  
                Quaternion impactRotation1 = Quaternion.LookRotation(hit.normal);
                GameObject impact1 = Instantiate(impactEffect, hit.point, impactRotation1);
                impact1.transform.parent = hit.transform;
                Destroy(impact1, 0.1f);
               
            }
        }

        Enemy enemy = hit.transform.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(EnemydamageAmount);
            return;
        }
      
    }

  
}
