using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationController : MonoBehaviour
{

    Animator animator;

    public void Start()
    {
        animator = transform.GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        if (animator != null)
        {
            //if (!Input.anyKeyDown)
            //{
            //  
            //    animator.SetBool("Idle", true);
            //    Debug.Log("Idle");
            //}
            //else
            //{
            //   
            //    animator.SetBool("Idle", false);
            //}

            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.LeftShift))
            {
               
                animator.SetTrigger("Walking");
                //animator.SetTrigger("Running");
                
               

            }
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
            {
                animator.SetTrigger("Running");
            }


            if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("StrafeLeft", true);

            }


            if (Input.GetKey(KeyCode.Space))
            {
                animator.SetTrigger("Jumping");

            }
            // if (!Input.anyKeyDown)
            // {
            //     animator.SetTrigger("Idling");
            // }


            if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("StrafeRight", true);

            }
          


        }

        /*
          || Input.GetKey(KeyCode.D)
         || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)
         */
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    animator.SetBool("isStriking", true);
        //    Debug.Log("striking");
        //    //sound.Play();
        //}
        //else
        //{
        //    animator.SetBool("isStriking", false);
        //}

        // if (Input.GetKeyDown(KeyCode.LeftAlt))
        // {
        //     if (animator.GetBool("isCombatReady"))
        //     {
        //         animator.SetBool("isCombatReady", false);
        //     }
        //     else
        //     {
        //         animator.SetBool("isCombatReady", true);
        //     }
        //     Debug.Log(animator.GetBool("isCombatReady"));
        // }
    }
}
