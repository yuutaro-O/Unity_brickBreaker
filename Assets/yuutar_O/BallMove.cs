using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    //bit演算、LEFT,RIGHT,UP,DOWN
    int mxdirec_r = 0;
    int mydirec_d = -1;
    const float spd =0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(mxdirec_r * spd, mydirec_d * spd, 0));
	}
    void OnCollisionEnter(Collision enter)
    {

        
        if (enter.gameObject.tag == "Fliper")
        {
            mydirec_d = 1;
            if(mxdirec_r == 0)
            {
                mxdirec_r = -1;
            }
            
        }
        else if(enter.gameObject.tag == "ceal")
        {
            Debug.Log("hit_wall");
            mydirec_d = -1;
        }

        if(enter.gameObject.tag == "wall_r")
        {
            Debug.Log("hit_wall");
            mxdirec_r = -1;
        }
        else if(enter.gameObject.tag == "wall_l")
        {
            Debug.Log("hit_wall");
            mxdirec_r = 1;
        }

        if(enter.gameObject.tag == "brick")
        {
            Destroy(enter.gameObject);
        }
        
        transform.Translate(new Vector3(mxdirec_r * spd, mydirec_d * spd, 0));
    }
}
