using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplet : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f) //when the droplet goes to -6y it gets destroyed
        {
            Destroy(gameObject);
        }
    }
}
