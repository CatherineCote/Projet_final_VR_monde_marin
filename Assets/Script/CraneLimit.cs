﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneLimit : MonoBehaviour
{
    //Limite sur l'axe des y
    private float yLimit = 9;
    //audio du crane
    public AudioClip craneSound;
    private AudioSource craneAudio;
    // Start is called before the first frame update
    void Start()
    {
        craneAudio = GetComponent<AudioSource>();
        craneAudio.PlayOneShot(craneSound, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yLimit)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(transform.position.x, yLimit, transform.position.z);
            Debug.Log("bcjasbcj");
        }
    }
}
