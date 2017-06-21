using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour {

    // Animation system
    private Animator animator;

    // Use this for initialization
    void Start () {

        // Animation system object initialization
        animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {

        /* Press the keyboard */

        // Jab
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Jab", true);
        }

        // Out of the foot
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Hikick", true);
        }

        // Spin kicks
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Spinkick", true);
        }

        // Rising fist
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("Rising_P", true);
        }

        // After turning somersault
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Headspring", true);
        }

        // Lower leg press
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Land", true);
        }

        // Runing
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("Run", true);
        }

        // Make your feet before the air
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetBool("ScrewK", true);
        }

        // Empty after lying
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetBool("DamageDown", true);
        }

        // A back flip
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("SAMK", true);
        }

        /* The release of the keyboard */
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Jab", false);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Hikick", false);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("Spinkick", false);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            animator.SetBool("Rising_P", false);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Headspring", false);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Land", false);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            animator.SetBool("ScrewK", false);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            animator.SetBool("DamageDown", false);
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            animator.SetBool("SAMK", false);
        }
    }
}
