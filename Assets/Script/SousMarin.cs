using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SousMarin : MonoBehaviour
{
    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;
    //variable pour le son de bulles
    public AudioClip sousMarinSound;
    //source qui se trouve dans le player
    private AudioSource sousMarinAudio;
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        sousMarinAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlerScript.transform.position.z > 45 && spawned == false)
        {
            sousMarinAudio.PlayOneShot(sousMarinSound, 1.0f);
           spawned = true;
}
        
    }
}
