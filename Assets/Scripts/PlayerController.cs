using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool Jump;
    public bool GameOver;
    void Start()
    {
        Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && Jump==false && !GameOver)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 9, 0);
            Jump = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
