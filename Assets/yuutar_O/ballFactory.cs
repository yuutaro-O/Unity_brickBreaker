using UnityEngine;
using System.Collections;

public class ballFactory : MonoBehaviour
{
    [SerializeField]
    GameObject ball;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Factory());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Factory(){

        while (true)
        {
            Instantiate(ball, new Vector3(Random.Range(-5,5),10, -2),transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
}

