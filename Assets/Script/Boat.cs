using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{

    //Ajouter un tableau pour y insérer des éléments
    public GameObject boatPrefab;


    //private PlayerController playerGo;

    public AudioClip boatSound;
    public AudioSource boatAudio;

   

    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;

    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        

        boatAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerControlerScript.transform.position.z > 0 && spawned == false)
        {
            spawned = true;
            SpawnBoat();
            Debug.Log("BATEAU");
        }
        

    }

    void SpawnBoat()
    {
        Instantiate(boatPrefab, new Vector3(-100, 150, 61), boatPrefab.transform.rotation);
        boatAudio.PlayOneShot(boatSound, 1.0f);
      
    }
}
