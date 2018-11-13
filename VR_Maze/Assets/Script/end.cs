using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {

    public Canvas cv;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {

        if (col.transform.tag == "Exit")
        {
            Debug.Log("Finish");
            ew();

        }
        else if (col.transform.tag == "Coin")
        {
            Debug.Log("eat!");
            Destroy(col.gameObject);
        }


    }


    void ew()
    {
        Time.timeScale = 0;
        cv.gameObject.SetActive(true);
    }
}
