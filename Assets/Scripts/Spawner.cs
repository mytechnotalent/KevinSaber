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

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float pulse;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We instantiate our cubes if our timer variable is greater
        // than our pulse variable set in Unity where we randomly
        // place either a red or blue cube
        if(timer > pulse)
        {
            GameObject cube =
                Instantiate
                (
                    cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]
                );

            // Now that we have our random position we want to keep
            // the cube at its local position with a zero Vector3
            cube.transform.localPosition = Vector3.zero;

            // Add rotation which is random to generate our up,
            // down, left or right positions when instantiated
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            
            // Update timer once per frame
            timer -= pulse;
        }

        // If less than pulse we increase our value once per frame
        timer += Time.deltaTime;
    }
}
