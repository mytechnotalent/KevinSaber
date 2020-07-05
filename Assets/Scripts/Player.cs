//
// KevinSaber
// **********
// 
// Created by Kevin Thomas 01/04/20.
// Modified by Kevin Thomas 01/04/20.
//
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

public class Player : MonoBehaviour
{
    public LayerMask layer;
    public int score;
    public AudioSource hitSound;
    
    private Vector3 previousPos;
   
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate our sound object
        hitSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // We create RaycastHit object to generate a raycast
        // from our controllers which when they come
        // into contact with a respective cube they 
        // will return back the cube's information
        // 
        RaycastHit hit;

        // We check every frame to see if we are in
        // fact getting a connection to the cube
        // with our raycast a length of one
        if
        (
           Physics.Raycast
           (
                transform.position,
                transform.forward,
                out hit,
                1,
                layer
            )
        )
        {
            // We check velocity of the saber's 'transform.position'
            // less its 'previousPos' where the cube's transform 
            // is up and if our saber come in contact with our cube's
            // smaller internal box we have successful struck 
            // our target as that angle is 130 degrees
            if
            (
                Vector3.Angle
                (
                    transform.position - previousPos,
                    hit.transform.up
                )
                > 130
            )
            {
                // We play our sound effect and then remove the 
                // object from memory
                hitSound.Play();

                // Remove the object
                Destroy(hit.transform.gameObject);

                // Increment score
                score++;
            }

            // Finally we put our transform into our previous position
            previousPos = transform.position;
        }
    }
}
