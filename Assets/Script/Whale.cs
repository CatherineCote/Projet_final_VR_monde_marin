using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    //Ajouter un tableau pour y insérer des éléments
    public GameObject whalePrefab;


    //private PlayerController playerGo;

    public AudioClip whaleSound;
    private AudioSource whaleAudio;

    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;

    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
       
        
        whaleAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (playerControlerScript.transform.position.z > 20 && spawned == false)
        {
            spawned = true;
                SpawnWhale();
                Debug.Log("BALEINE");
        }
        
    }

    void SpawnWhale()
    {
        Instantiate(whalePrefab, new Vector3(96, 62, 185), whalePrefab.transform.rotation);
        whaleAudio.PlayOneShot(whaleSound, 1.0f);
    }





}
