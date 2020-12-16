using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    //Vitesse attribué au Up and Down
    private float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void Update()
    {
      //Le player va faire up/down en loop grace à la commande pinPong
      //le minimum est de 16.5 et le maximum est de 19.5
      //O conserve la position présente du player sur l'axe des X et l'axe des Z
        transform.position = new Vector3(transform.position.x, Mathf.Lerp(16.5f, 19.5f, Mathf.PingPong(Time.time * speed, 1)), transform.position.z);
    }
}
