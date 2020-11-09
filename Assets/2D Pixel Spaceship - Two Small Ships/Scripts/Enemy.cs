﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.4f;
    int numOfMovements = 0;
    float Speed = 0.25f;

    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(GameManager.playGame)
        {

        if(numOfMovements == 14)
        {
            transform.Translate(new Vector3(0, -1, 0));
            numOfMovements = -1;
            Speed = -Speed;
            timer = 0;
        }

        timer += Time.deltaTime;
        if(timer > timeToMove && numOfMovements< 14)
        {
            transform.Translate(new Vector3(Speed,0,0));
            timer = 0;
            numOfMovements++;
        }


        fireEnemyProjectile();
        
        }
    }

    void fireEnemyProjectile()
    {
        if(Random.Range(0f,500f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y + 0.6f, 0), enemy.transform.rotation) as GameObject;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.playGame = false;
            GameManager.lives = 0;
        }
    }
}
