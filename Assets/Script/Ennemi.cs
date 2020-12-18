using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    //Variable pour la vitesse
    private float speed = 10;
    //Variable pour le rigidbody de l'ennemi
    private Rigidbody enemyRb;
    //On crée un game objecT pour le player
    private GameObject player;
    //Créer une variavle qui se réfere au script du player
    private playerControler playerControlerScript;
   
    // Start is called before the first frame update
    void Start()
    {
        
        //Va chercher le rigidbody qui se trouve sur l'ennemi
        enemyRb = GetComponent<Rigidbody>();
        //Player, on va chercher le gameObject player
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //L'ennemi va toujours avancer en direction du player selon la position de celui-ci
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        
    }
}
