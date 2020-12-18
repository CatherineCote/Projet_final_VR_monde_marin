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
    //La variable spawn est de base à faux
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
        //On va chercher la source audio u sous-marin
        sousMarinAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si la position du player sur l'axe de z (qui est récupérer par le script)
        //est plus grande que 45  ET que le spawned est toujours à faux, éxécute la fonction
        if (playerControlerScript.transform.position.z > 45 && spawned == false)
        {
            //On joue l'audio du sous-marin et la variable spawn tombe a true
            sousMarinAudio.PlayOneShot(sousMarinSound, 1.0f);
           spawned = true;
         }
        
    }
}
