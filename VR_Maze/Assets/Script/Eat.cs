using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Eat : MonoBehaviour {

    public Canvas cv;
    public GameObject txt;
    

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Exit")
        {
            Debug.Log("Finish");
            ew();

        }
        else if (col.tag == "Coin")
        {
            Debug.Log("Eat!");
            Destroy(col.gameObject);
            Tcount.timeCount += 5;
            StartCoroutine(bt());
        }
        if (col.tag == "Enemy")
        {
            Debug.Log("AI!");
            Destroy(col.gameObject);
            Tcount.timeCount -= 3;
            StartCoroutine(bt());
        }

    }

    void ew()
    {
        Time.timeScale = 0;
        cv.gameObject.SetActive(true);
    }

    IEnumerator bt()
    {
        for(int i = 0; i < 3; i++)
        {
            txt.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            txt.SetActive(true);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
