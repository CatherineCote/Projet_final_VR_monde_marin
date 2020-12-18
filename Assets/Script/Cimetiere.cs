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
    //source audio qui se trouve sur le cimetiere
    private AudioSource cimetiereAudio;
    //Variable pour la systeme de particule pour splash/bulles
    public ParticleSystem bubbleParticle;
    public ParticleSystem splashParticle;
    //Crée un gameObject pour l,ensemble des particules de lumière
    //(un prefab a été créer préalablement)
    public GameObject lightPrefab;
    //Dr base le spawn est a faux
    private bool spawned = false;
   
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        //On va chercher la source audio du gameOject cimetiere
        cimetiereAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si la position du player sur l'axe de z (qui est récupérer par le script)
        //est plus grande que 60  ET que le spawned est toujours à faux, éxécute la fonction
        if (playerControlerScript.transform.position.z > 60 && spawned == false)
        {
            //On joue l'audio du cimetiere
            cimetiereAudio.PlayOneShot(cimetiereSound, 1.0f);
            //spawded devient vrai
            spawned = true;
            //On appel la fonction SpawnCrane()
            SpawnCrane();
            
        }
        
        void SpawnCrane()
        {
            //On instantie le prefabs du crane avec la position demander tout en gardant sa rotation
            Instantiate(cranePrefab, new Vector3(6, 47, 98), cranePrefab.transform.rotation);
            //On instantie le prefabs de lumiere avec la position demander tout en gardant sa rotation
            Instantiate(lightPrefab, new Vector3(17, 0, 93), lightPrefab.transform.rotation);
            //On joue les particules des bulles et du splash
            bubbleParticle.Play();
            splashParticle.Play();

        }
    }
}
