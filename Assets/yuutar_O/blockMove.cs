using UnityEngine;
using System.Collections;

public class blockMove : MonoBehaviour
{
    int score = 0;
    // Use this for initialization
    void Start()
    {

    }

    [SerializeField]
    float speed = 0.3f;
    // Update is called once per frame

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed,0, 0));
    }

    void OnCollisionEnter(Collision enter)
    {

        Debug.Log("score" + score);
        if (enter.gameObject.tag == "Ball") {
            //Destroy(enter.gameObject);
            
            score++;
        }
    }
}

