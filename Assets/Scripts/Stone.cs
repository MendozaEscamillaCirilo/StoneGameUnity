using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // public GameObject explosion;

    private const float yDie = -70.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yDie)
            Destroy(gameObject);
    }
    void OnMouseDown()
    {
        // Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
        Destroy(gameObject);
        GameManager.currentNumberDestroyedStones++;
    }
}
