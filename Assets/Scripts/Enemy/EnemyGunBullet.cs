using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunBullet : MonoBehaviour
{
    public GameObject impactEffect;
    public float radius = 2f;




    private void OnCollisionEnter(Collision collision)
    {
        SoundManager.Instance.PlaySound(SoundManager.Instance.enemyShoot);
        GameObject impact = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(impact, 0.05f);
        StaticObject.playerdamageAmount += 0.01f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            if (nearbyObject.tag == "Player")
            {
                StartCoroutine(FindObjectOfType<PlayerManager>().TakeDamage());
            }
        }
        this.enabled = false;
        

    }





}
