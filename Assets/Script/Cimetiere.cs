using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cimetiere : MonoBehaviour
{
    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;
    //prefab du crane pour le faire apparaitre
    public GameObject cranePrefab;
    //audio du crane
    public AudioClip craneSound;
    //variable pour le son de bulles
    public AudioClip cimetiereSound;
    //source qui se trouve dans le player
    private AudioSource cimetiereAudio;
    //Variable pour la systeme de particule pour splash/bulles
    public ParticleSystem bubbleParticle;
    public ParticleSystem splashParticle;
    private bool spawned = false;
   
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        cimetiereAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlerScript.transform.position.z > 60 && spawned == false)
        {
            cimetiereAudio.PlayOneShot(cimetiereSound, 1.0f);
            spawned = true;
            SpawnCrane();
        }
        
        void SpawnCrane()
        {
            Instantiate(cranePrefab, new Vector3(6, 47, 98), cranePrefab.transform.rotation);
            cimetiereAudio.PlayOneShot(craneSound, 1.0f);
            //On joue les particules des bulles et du splash
            bubbleParticle.Play();
            splashParticle.Play();

        }
    }
}
