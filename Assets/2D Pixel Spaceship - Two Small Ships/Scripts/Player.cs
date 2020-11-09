using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   public GameObject player;
   public GameObject projectile;
   public GameObject projectileClone;

   public GameObject DeathMenu;
   public GameObject explosion;
  
    // Start is called before the first frame update
    void Start()
    {
        GameManager.lives = 3;
        GameManager.playGame = true;
        ScoreText.scoreValue = 0;
        ScoreText2.scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.lives > 0)
        {
        movement();
        fireProjectile();
        }

        if(GameManager.lives == 0)
        {
            Destroy(this.gameObject);
            GameManager.playGame = false;
            DeathMenu.SetActive(true);
            Instantiate(explosion, transform.position , Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("explosion");
        }
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }

        
    }

    void fireProjectile()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& projectileClone == null)
        {
            FindObjectOfType<AudioManager>().Play("shoot");
           projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), player.transform.rotation) as GameObject;
        }
    }
}
