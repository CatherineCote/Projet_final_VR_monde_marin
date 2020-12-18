using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Créer des gameObject pour les prefabs
    public GameObject ObstaclePrefabs;
    public GameObject ObstaclePrefabs02;
    public GameObject ObstaclePrefabs03;
    public GameObject ObstaclePrefabs04;
    public GameObject EnnemiPrefabs;
    //variable limitant la position du spawn à la pateforme du jeu
    private float spawnPosZ = 36;
    private float spawnPosX = 60;
    private float spawnPosY = 25;
    private float spawnPosYTop = 40;


    //variable limitant la position du spawn de l'ennemi à la pateforme du jeu 
    private float spawnEnnemiRangeX = 18;
    
    //Variable pour le delais du spawn ainsi que l'interval pour les possions normal
    private float startDelay = 0.5f;
    private float spawnInterval = 2f;

    //Variable pour le delais du spawn 
    private float startDelayE = 5;
    //private float spawnIntervalE = 5f;

 
    // Start is called before the first frame update
    void Start()
    {
        
        //Appel la fonction personnalisé (nomFonction, Temps delais, L'interval d'apparition)
        //Ces fonctions sont appelé constament
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
        InvokeRepeating("SpawnObstacle02", startDelay, spawnInterval);
        InvokeRepeating("SpawnObstacle03", startDelay, spawnInterval);
        InvokeRepeating("SpawnObstacle04", startDelay, spawnInterval);
        //spawn une seule fois le poisson "ennemi" 
        Invoke("SpawnEnnemi", startDelayE);

    }

    void SpawnObstacle()

    {
        //Si le gameover est a faux exécute le code
       
            //génère une position au hasard selon le range qu'on lui permet
            Vector3 spawnPos = new Vector3(100, 18, Random.Range(-spawnPosZ, spawnPosZ));

            //Instantiate le prefabs obstacle selon le range établie
            Instantiate(ObstaclePrefabs, spawnPos, ObstaclePrefabs.transform.rotation);

    }
    void SpawnObstacle02()

    {
        //Si le gameover est a faux exécute le code

        //génère une position au hasard selon le range qu'on lui permet
        Vector3 spawnPos = new Vector3(-80, Random.Range(spawnPosY, spawnPosYTop), Random.Range(-spawnPosZ, spawnPosZ));

        //Instantiate le prefabs obstacle selon le range établie
        Instantiate(ObstaclePrefabs02, spawnPos, ObstaclePrefabs02.transform.rotation);

    }
    void SpawnObstacle03()

    {
        //Si le gameover est a faux exécute le code

        //génère une position au hasard selon le range qu'on lui permet
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), Random.Range(-spawnPosY, spawnPosY), 100);

        //Instantiate le prefabs obstacle selon le range établie
        Instantiate(ObstaclePrefabs03, spawnPos, ObstaclePrefabs03.transform.rotation);

    }
    void SpawnObstacle04()

    {
        //Si le gameover est a faux exécute le code

        //génère une position au hasard selon le range qu'on lui permet
        Vector3 spawnPos = new Vector3(-100, Random.Range(spawnPosY, spawnPosYTop), 100);

        //Instantiate le prefabs obstacle selon le range établie
        Instantiate(ObstaclePrefabs04, spawnPos, ObstaclePrefabs04.transform.rotation);

    }
    //Fonction qui contient le spawn des ennemi
    void SpawnEnnemi()
    {

        //génère une position au hasard selon le range qu'on lui permet pour l'ennemi
        Vector3 spawnPos = new Vector3(Random.Range(-spawnEnnemiRangeX, spawnEnnemiRangeX), 50, 210);

        //Instantiate le prefabs obstacle selon le range établie
        Instantiate(EnnemiPrefabs, spawnPos, EnnemiPrefabs.transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
