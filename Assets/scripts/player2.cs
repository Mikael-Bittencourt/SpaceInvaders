using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{
   public GameObject player;
   public GameObject projectile;
   public GameObject projectileClone;

   public GameObject DeathMenu;


  
    // Start is called before the first frame update
    void Start()
    {
        
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
            DeathMenu.SetActive(true);
        }
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }

        
    }

    void fireProjectile()
    {
        if(Input.GetKeyDown(KeyCode.P)&& projectileClone == null)
        {
           projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f, 0), player.transform.rotation) as GameObject;
        }
    }

}
