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
            Instantiate(cranePrefab, new Vector3(40, 33, 81), cranePrefab.transform.rotation);
            Debug.Log("aaaaaaaaaaaaaah");
        }
    }
}
