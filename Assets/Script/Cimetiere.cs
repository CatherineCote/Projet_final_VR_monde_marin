using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cimetiere : MonoBehaviour
{
    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;
    //prefab du crane pour le faire apparaitre
    public GameObject cranePrefab;
    
    //variable pour le son de bulles
    public AudioClip cimetiereSound;
    //source qui se trouve dans le player
    private AudioSource cimetiereAudio;
    //Variable pour la systeme de particule pour splash/bulles
    public ParticleSystem bubbleParticle;
    public ParticleSystem splashParticle;
    public GameObject lightPrefab;
    //public ParticleSystem lightParticle;
    private bool spawned = false;
   
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        cimetiereAudio = GetComponent<AudioSource>();
        //lightParticle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlerScript.transform.position.z > 60 && spawned == false)
        {
            cimetiereAudio.PlayOneShot(cimetiereSound, 1.0f);
            spawned = true;
            SpawnCrane();
            //lightParticle.Play();
        }
        
        void SpawnCrane()
        {
            Instantiate(cranePrefab, new Vector3(6, 47, 98), cranePrefab.transform.rotation);
            Instantiate(lightPrefab, new Vector3(17, 0, 93), lightPrefab.transform.rotation);
            //On joue les particules des bulles et du splash
            bubbleParticle.Play();
            splashParticle.Play();

        }
    }
}
