using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Droplet; //droplet
    public float maxX; //max spawn point of droplet
    public Transform SpawnPoint; //this spawn the droplets
    public float SpawnRate; //this manages the rate a6t which droplets spawn

    bool start = false;//bool to control if the game started yet
    public TextMeshProUGUI scoretxt; //score manager
    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !start) {//if you get an input and the game isn't already started
            BeginSpawn();//spawn the droplets
            start = true;//set the bool to true
            
        }
    }
        private void BeginSpawn()
        {
            InvokeRepeating("spawnDroplet", 0.5f, SpawnRate); //spawn droplet at a rate of 1 every 2 seconds
        }


        public void spawnDroplet()
        {
            Vector3 spawnPos = SpawnPoint.position; //spawn point 
            spawnPos.x = Random.Range(-maxX, maxX);//randomly choose a spawnpoint in the acceptable range
            Instantiate(Droplet, spawnPos, Quaternion.identity);
            score++;//add points to score
            scoretxt.text=score.ToString();//converts score to string to display on screen
        }
   
    }

