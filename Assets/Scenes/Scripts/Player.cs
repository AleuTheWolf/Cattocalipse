using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
 
public class Player : MonoBehaviour
{
    public float MoveSpeed; //player speed
    Rigidbody2D rb; //player
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>(); //get player
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //if the game gets movement inputs
        {
            Vector3 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //this manages the inputs
            if (touchpos.x < 0) //if input left of player
            {
                rb.AddForce(Vector2.left * MoveSpeed); //go left
            }
            else
            {
                rb.AddForce(Vector2.right * MoveSpeed); //go right
            }
        }
        else
        {
            rb.velocity = Vector2.zero; //if input on player do not move
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //if player collides
    {
        if (collision.gameObject.tag == "Droplet") //with a droplet
        {
            
            GameOverScreen.SetupGO(); //invoke gameover screen
           
        }
    }
}
