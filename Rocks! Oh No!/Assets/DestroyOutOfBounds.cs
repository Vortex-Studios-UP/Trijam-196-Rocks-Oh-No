using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float sideBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > sideBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -topBound)
        {
            Destroy(gameObject);
        }
    }
}