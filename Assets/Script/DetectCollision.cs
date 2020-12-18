using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //variable pour le son de bulles
    public AudioClip bubbleSound;
    //source qui se trouve dans le player
    private AudioSource playerAudio;
    //Variable pour la systeme de particule des bulles et du splash
    public ParticleSystem bubbleParticle;
    public ParticleSystem splashParticle;
    // Start is called before the first frame update
    void Start()
    {
        //Va chercher l'audio source
        playerAudio = GetComponent<AudioSource>();
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    //Si le collider rentre en contacte avec other 
    //other est le tag enemi placer sur le poisson enemi
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemi")
        {
           
            //On joue les particules des bulles et du splash
            bubbleParticle.Play();
            splashParticle.Play();
            
            //On joue l'audio des bulles une seule fois
            playerAudio.PlayOneShot(bubbleSound, 1.0f);
            
            //On détruit le gameObject avec le tag enemi
            Destroy(other.gameObject);
            //On écrit ce message dans la console
            Debug.Log("ATTENTION UN POISSON VOUS A FONCEZ DESSUS");

         
        }

    }
}
