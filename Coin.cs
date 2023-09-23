using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    ScoreBoard point;
    [SerializeField] int scorepoint = 0;

    MeshRenderer renderer;
    Rigidbody rigidbody;
    void start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = true;

    }

   
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "coin")
        {
        renderer.enabled = false;
        Debug.Log("You have  " + point + " points.");
        }


    }



}

