﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnMan;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");
        spawnMan = GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>();
        speed = spawnMan.waveCount * 25;
        Debug.Log(spawnMan.waveCount);
    }

    // Update is called once per frame
    void Update()
    {
      
        
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(speed * Time.deltaTime * lookDirection);
        

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
            
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
            ;
        }

    }

}
