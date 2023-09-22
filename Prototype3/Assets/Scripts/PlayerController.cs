﻿// Patrick Hetland 
// Prototype 3
// Controls player



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    // Start is called before the first frame update

    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;



    void Start()
    {



        //set a reference to our rigidbody component
        rb = GetComponent<Rigidbody>();
        //set a reference to our Animator component
        playerAnimator = GetComponent<Animator>();
        //set reference to audio source component
        playerAudio = GetComponent<AudioSource>();

        //start running animation on start
        playerAnimator.SetFloat("Speed_f", 1.0f);
    
        forceMode = ForceMode.Impulse;

        //modify gravity
        if (Physics.gravity.y > -10)
        {

            Physics.gravity *= gravityModifier;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //jumping when the player presses space
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            //set the trigger to play the jump animation
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt particle on jump
            dirtParticle.Stop();

            //play jump sound effect
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            isOnGround = true;
            //start playing dirt particle when the player hits the ground
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
        Debug.Log("Game Over!");
        gameOver = true;

            //Play deatth animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //Play explosion particle
            explosionParticle.Play();

            //play crash sound effect
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }




}






