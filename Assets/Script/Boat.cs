using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{

    //Ajouter un game object pour le prefab du bateau
    public GameObject boatPrefab;

    //Aujouter un audio pour la son du bateau avec une source audio
    public AudioClip boatSound;
    public AudioSource boatAudio;

   

    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;
    
    //De base le spawned est à faux, car les élément ne sont pas encore présent sur la scène
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        
        //On va chercher la source audio du bateau
        boatAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si la position du player sur l'axe de z (qui est récupérer par le script)
        //est plus grande que 0  ET que le spawned est toujours à faux, éxécute la fonction
        if (playerControlerScript.transform.position.z > 0 && spawned == false)
        {
            //Spawned tombe à vrai, on appel la fonction spawnBoatd();
            spawned = true;
            SpawnBoat();
            Debug.Log("REGARDEZ LÀ-HAUT!");
        }
       


    }

    void SpawnBoat()
    {
        //on instantie le prefab du bateau à la position demander tout en gardant sa rotation
        Instantiate(boatPrefab, new Vector3(-90, 150, 61), boatPrefab.transform.rotation);
        //On joue le son des cloches du bateau lorsque cette fonction est éxécuté
        boatAudio.PlayOneShot(boatSound, 1.0f);
        

    }
}
