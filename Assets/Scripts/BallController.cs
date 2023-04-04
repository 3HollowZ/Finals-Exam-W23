using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Diamond;
    void Start()
    {
        
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Diamond")
        {
            
            Activate(collision.gameObject);
        }
    }

    public virtual void Activate(GameObject player)//
    {
        DestroyImmediate(Diamond, true);
    }
}
