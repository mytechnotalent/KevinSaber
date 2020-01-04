//
// KevinSaber
// **********
// 
// Created by Kevin Thomas 01/04/20.
// Modified by Kevin Thomas 01/04/20.
// Apache License, Version 2.0
// 
// KevinSaber is a Oculus Rift and Oculus Quest game that is a 
// BeatSaber clone where you strike the boxes as they fly past you
// in a fierce frenzy.  The pace of this game is fast and if you 
// are looking to get your exercise on, this is your game!
//
// Music: Epic Sport Rock - AShamaluevMusicPro
//


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player leftHandPlayer;
    public Player rightHandPlayer;
    public TextMesh infoText;
    public float gameTimer = 173f;

    private float resetTimer = 1f;
    private int totalScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We countdown our timer once per frame
        gameTimer -= Time.deltaTime;

        totalScore = leftHandPlayer.score + rightHandPlayer.score;

        // If our 'gameTimer' is running
        if (gameTimer > 0f)
        {
            infoText.text =
                "Time: "
                + Mathf.Floor(gameTimer)
                + "\nScore: "
                + totalScore;
        }
        else
        // Our game is over so we show
        // score and reset the scene
        {
            infoText.text =
                "Game Over!"
                + "\nScore: "
                + totalScore; ;

            resetTimer -= Time.deltaTime;

            if (resetTimer <= 0f)
            {
                SceneManager.LoadScene
                (
                    SceneManager.GetActiveScene().name
                );
            }
        }
    }
}
