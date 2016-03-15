using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision enter)
    {
        Debug.Log("hit");
        if (enter.gameObject.tag == "Ball")
        {
            Debug.Log("gameover");
        }
    }
}
