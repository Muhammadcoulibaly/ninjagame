using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    float timeElapsed = 3f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MoveObject();
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 3f)
        {
            Debug.Log(timeElapsed + " seconds has elapsed");
            timeElapsed = 0f;
        }
    }

    void MoveObject()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Mathf.Abs(xValue) > 0 || Mathf.Abs(zValue) > 0)
        {
            transform.Translate(xValue, 0, zValue);
        }
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }
}
