/*Julian Avila
 * Prototype 3
 * Makes player jump
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;
    public ParticleSystem explosionParicle,dirtSplatter;
    public AudioClip jumpSound, crashSound;
    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        //Set reference to rigidbody
        rb = GetComponent<Rigidbody>();

        //set reference to animator component
        playerAnimator = GetComponent<Animator>();

        //start running animation on start
        playerAnimator.SetFloat("Speed_f", 1.0f);

        playerAudio = GetComponent<AudioSource>();

        forceMode = ForceMode.Impulse;

        //Modify gravity
        if(Physics.gravity.y > -10)
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
       
        //jumping when the player presses space
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;
            //When the player presses space, set the trigger for the jump animation
            playerAnimator.SetTrigger("Jump_trig");
            //Stop playing dirt particle when player jumps
            dirtSplatter.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
      
            
    }

   void OnCollisionEnter(Collision collision)
   {
        if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
            //play dirt particle
            dirtSplatter.Play();
        }

        if (collision.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            //Play death animation
            playerAnimator.SetBool("Death_b",true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //Play particle
            explosionParicle.Play();

            //Stop dirt splatter 
            dirtSplatter.Stop();

            //Play crash sound
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
           
   }

    public void StopRunning()
    {

    }

}
