using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour {

    float sp = 2f;
    float rotsp = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.localScale = new Vector3(0.3f, 1f, 0.3f);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate(Vector3.back * sp * Time.deltaTime);
            this.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * sp * Time.deltaTime);
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime * 2, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * sp * Time.deltaTime);
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime * 2, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * sp * Time.deltaTime);
        }
    }
}
