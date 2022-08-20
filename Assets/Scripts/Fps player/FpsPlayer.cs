
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FpsPlayer : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15;
    private Vector3 move;

    public float gravity = -10f;
    public float jumpHeight = 2;
    private Vector3 velocity;

    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;

    //public AudioSource audioSource;
   public AudioSource audioSource;

    public bool IsMoving;
    public Animator animator;






    public float EnemyDistance=5f;
   

    // Update is called once per frame
    void Update()
    {


           
            if (controller.isGrounded &&( Input.GetAxis("Vertical") < 0 || Input.GetAxis("Vertical") >0 || Input.GetAxis("Horizontal")>0|| Input.GetAxis("Horizontal")<0)) IsMoving = true; 
            else IsMoving = false;

        if (IsMoving && !audioSource.isPlaying)
        {
            //animator.SetBool("playerRun", true);
            audioSource.pitch = Random.Range(1.0f, 1.5f);
            audioSource.volume = Random.Range(0.5f, 1.0f);
            audioSource.Play(); 
        }
            if (!IsMoving) audioSource.Stop();
            Run();
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.5f, groundLayer);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -1f;
        }

        if (isGrounded)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))   {Jump();}
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }

        controller.Move(velocity * Time.deltaTime);
    }


    private void Run()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        animator.SetFloat("Run", Mathf.Abs(x) + Mathf.Abs(z));
        move = transform.right * x + transform.forward * z;
        controller.Move((move * speed) * Time.deltaTime);
    }





    private void Jump()
    {
        SoundManager.Instance.PlaySound(SoundManager.Instance.jump);
        velocity.y = Mathf.Sqrt(jumpHeight * 2 * -gravity);
    }
}