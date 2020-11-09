using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3( 0, -12 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().Play("Enemy_died");
            ScoreText.scoreValue += 10;
            ScoreText2.scoreValue += 10;
            Destroy(collision.gameObject);
            Destroy(projectile);
            GameManager.playGame = true;
        }

        if(collision.gameObject.tag == "BulletBounds")
        {
            Destroy(projectile);
            GameManager.playGame = true;
        }
    }
}
