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

public class Cube : MonoBehaviour
{
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Here we simply instantiate a randomized speed variable which  
        // when we later generate our cube objects with a randomized 
        // velocity between 1 and 50 meters per second
        speed = Random.Range(1f, 50f);

        // We move the cube forward using deltaTime and our randomized 
        // speed variable
        transform.position += Time.deltaTime * -transform.forward * speed;
    }
}
