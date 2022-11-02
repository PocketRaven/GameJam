using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IJ;
    void Start()
    {
        IJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && IJ==false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 8, 0);
            IJ = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Finish")
        {
            IJ = false;
        }
    }
}
