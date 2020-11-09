using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    Vector3 respawn = new Vector3( 0, -4, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3( 0, -6 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = respawn;
            Destroy(enemyProjectile);
            GameManager.lives--;
            GameManager.playGame = false;
        }

         if(collision.gameObject.tag == "EnemyBulletBounds")
        {
            Destroy(enemyProjectile);
        }

    }
}
