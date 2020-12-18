using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    //gameobject contenant le prefab de la baleine
    public GameObject whalePrefab;

    //varicle de la source audio et du son de la baleine
    public AudioClip whaleSound;
    private AudioSource whaleAudio;

    //Variable pur aller chercher le script du player
    private playerControler playerControlerScript;

    //la varible spawned est de base à faux
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        //Dans le gameObject player, va chercher le script playerControler
        playerControlerScript = GameObject.Find("Player").GetComponent<playerControler>();
       
        //Va chercher l'audio source
        whaleAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si la position du player sur l'axe de z (qui est récupérer par le script)
        //est plus grande que 20  ET que le spawned est toujours à faux, éxécute la fonction
        if (playerControlerScript.transform.position.z > 20 && spawned == false)
        {
            //SPAWNED TOME À TRUE   
            spawned = true;
                SpawnWhale();
                Debug.Log("ATTENTION IL Y A UNE BALEINE");
        }
       

    }

    void SpawnWhale()
    {
        //Instantie le prefab de la baleine avec la position demandé tout en gardant sa rotation
        Instantiate(whalePrefab, new Vector3(96, 80, 185), whalePrefab.transform.rotation);
        //On joue le son de la baleine
        whaleAudio.PlayOneShot(whaleSound, 1.0f);
       
    }





}
