using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    
    private Transform player; // The game object

    public Transform fireTrans; // A particle system agent object

    private bool isFire; // Whether to start the particle system

    private ParticleSystem PSFire; // Receive the particle system object

    void Start () {

        // Get the game
        player = gameObject.GetComponent<Transform>();

        // Acquisition of particle system
        PSFire = fireTrans.GetComponent<ParticleSystem>();

        // The default particle system starts
        PSFire.Play();
        isFire = true;
    }

    // Keyboard input controls the game object
    void Update () {

        // If isFire = = ture starts the particle system, otherwise it's not.
        if (isFire)
        {
            PSFire.Play();
        }
        else
        {
            PSFire.Stop();
        }

        // The W key controls the game object moving forward
        if (Input.GetKey(KeyCode.W)) {
            player.Translate(Vector3.forward * 0.1f , Space.World);
        }

        // The S key controls the game object to move backwards
        if (Input.GetKey(KeyCode.S))
        {
            player.Translate(Vector3.back * 0.1f, Space.World);
        }

        // The A key controls the object to move to the left
        if (Input.GetKey(KeyCode.A))
        {
            player.Translate(Vector3.left * 0.1f, Space.World);
        }

        // The D key controls the game object moving to the right
        if (Input.GetKey(KeyCode.D))
        {
            player.Translate(Vector3.right * 0.1f, Space.World);
        }

        // The R key controls the game object moving up
        if (Input.GetKey(KeyCode.R)) {
            player.Translate(Vector3.up * 0.1f, Space.World);
        }

    }

    // Collision started
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Wall")
        {

            isFire = false;
            
        }
    }

    // End of the collision
    void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.name == "Wall")
        {

            isFire = true;

        }
    }

    // Impact on
    void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.name == "Wall")
        {

            isFire = false;

        }
    }
}
