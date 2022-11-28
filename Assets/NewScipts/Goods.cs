using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goods : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print   (collision.name);
        if (collision.tag == "player"){
            collision.gameObject.GetComponent<PlayerBag>().playerSpr.Add(GetComponent<SpriteRenderer>().sprite);
        }
    }
}
