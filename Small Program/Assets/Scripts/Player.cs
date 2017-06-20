using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    // The display panel
    public Transform mainCanvas;
    public Transform gameCanvas;

    // Gameobject
    public Transform gamePlay;

    // Start the game
    public void StartPlay() {

        // Display panel control
        mainCanvas.gameObject.SetActive(false);
        gameCanvas.gameObject.SetActive(true);

    }

    // Quit the game
    public void ExitPlay()
    {
        // Display panel control
        mainCanvas.gameObject.SetActive(true);
        gameCanvas.gameObject.SetActive(false);
    }

    // Stop the game
    public void StopPlay() {

        gamePlay.transform.position = gamePlay.transform.position;

    }

    // upward
    public void UpPlay()
    {

        gamePlay.transform.Translate(Vector3.up * 0.5f, Space.Self); 

    }

    // down
    public void DownPlay()
    {
        if (gamePlay.transform.position.y > 0.5)
        {
            gamePlay.transform.Translate(Vector3.down * 0.5f, Space.Self);
        }
    }

    // To the left
    public void LeftPlay()
    {

        gamePlay.transform.Translate(Vector3.left * 0.5f, Space.Self);

    }

    // To the right
    public void RightPlay()
    {

        gamePlay.transform.Translate(Vector3.right * 0.5f, Space.Self);

    }

    // forward
    public void QueenPlay()
    {

        gamePlay.transform.Translate(Vector3.back * 0.5f, Space.Self);
    }

    // backward
    public void FrontPlay()
    {

        gamePlay.transform.Translate(Vector3.forward * 0.5f, Space.Self);

    }
}
