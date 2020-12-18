using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    //Variable qui va chercher l'axe vertical
    public float verticaleInput;
    //Variable pour la vitesse
    private float speed = 5;
    //Limite sur l'axe des x
    private float xLimit = 36;
    //Limite sur l'axe des y
    private float yLimit = 15.5f;
    //Limite sur l'axe des y
    private float yLimitTop = 18.5f;
    //Limite sur l'axe des z
    private float zLimit = 150;
    //variable pour le son de bulles
    public AudioClip bubbleSound;
    //source qui se trouve dans le player
    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        //Va chercher l'audio source
        playerAudio = GetComponent<AudioSource>();
        //on joue le son de bulles
        playerAudio.PlayOneShot(bubbleSound, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Va chercher L,axe vertical
        verticaleInput = Input.GetAxis("Vertical");
        //transfom le translate dans la direction back fois la temps la vitesse et l'axe horizontal
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticaleInput);
        
        // si la position x depasse la limit déclarer plus haut le player ne peu plus avancer
        if (transform.position.x > xLimit)
        {
            //On désigne la position selon la limite des 3 axes
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }
        // si la position -x depasse la limit déclarer plus haut le player ne peu plus avancer)
        else if (transform.position.x < -xLimit)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
        // si la position y depasse la limit déclarer plus haut le player ne peu plus avancer
        else if (transform.position.y < yLimit)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(transform.position.x, yLimit, transform.position.z);
        }
        // si la position y depasse la limit déclarer plus haut le player ne peu plus avancer
        else if (transform.position.y > yLimitTop)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(transform.position.x, yLimitTop, transform.position.z);
        }
        // si la position z depasse la limit déclarer plus haut le player ne peu plus avancer
        else if (transform.position.z > zLimit)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(transform.position.x, transform.position.y, zLimit);
        }
        // si la position -z depasse la limit déclarer plus haut le player ne peu plus avancer
        else if (transform.position.z < -zLimit)
        {
            //On désigne la position selon la limite des 3 axes dans le negatif
            transform.position = new Vector3(transform.position.x, transform.position.y, -zLimit);
        }
    }
}
