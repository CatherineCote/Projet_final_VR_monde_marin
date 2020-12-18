using System.Collections;
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
        //On va chercher la source audio du crane
        craneAudio = GetComponent<AudioSource>();
        //On joue le son du crane dès le début
        craneAudio.PlayOneShot(craneSound, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //on limite le position du Y du crane pour ne pas qu'il tome sous le sol
        if (transform.position.y < yLimit)
        {
            //On désigne la position selon la limite des Y tout en gardant le X et Z
            transform.position = new Vector3(transform.position.x, yLimit, transform.position.z);
            
        }
    }
}
