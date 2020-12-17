using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    
    //Limite du bas de l'écran
    private float lowerBound = -30;
    private float topBound = 250;
    private float leftBound = -90;
    private float rightBound = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Lorsqu'un GameObject dépense la limite du haut l'objet est détruit
      
        if (transform.position.x < leftBound)
        {
            // Destroy me
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            // Destroy me
            Destroy(gameObject);
        }
        //Lorsqu'un GameObject dépense la limite du bas l'objet est détruit
        else if (transform.position.z < lowerBound)
        {
            // Destroy me
            Destroy(gameObject);

        }
        else if (transform.position.z > topBound)
        {
            // Destroy me
            Destroy(gameObject);

        }

    }
}
