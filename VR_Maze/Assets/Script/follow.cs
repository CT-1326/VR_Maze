using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform player;
    public float dist;
    public float smoothRotate = 5.0f;
    private Transform tr;

	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () {

        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, player.eulerAngles.y, smoothRotate * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);
        
        tr.position = player.position - (rot * Vector3.forward * dist);


        tr.LookAt(player);
        
	}
}
