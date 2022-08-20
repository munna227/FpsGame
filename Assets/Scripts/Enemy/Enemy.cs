using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public GameObject projectile;
    public Transform projectilePoint;

    public static int enemyCount = 0;

    public float enemyHP = 1f;
    public int playerdamageAmount;

    public Animator animator;
    public GameObject gameObjects;
   
   

    public void Shoot()
    {
        

        Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 80f, ForceMode.Impulse);
        rb.AddForce(transform.up * 7, ForceMode.Impulse);
        Destroy(projectile,0.001f);
    }

    
    
    
    
    public void TakeDamage(float damageAmount)
      {
          enemyHP -= damageAmount;
          if (enemyHP <= (0.00f))
          {
              animator.SetTrigger("Die");
             GetComponent<CapsuleCollider>().enabled = false;
            SoundManager.Instance.PlaySound(SoundManager.Instance.enemyDown);
           


            Destroy(gameObjects, 1.5f);
            enemyCount++;
           StaticObject. DieEnemy--;
        }
          else
          {
             animator.SetTrigger("Damage");

        }
      }
   
}