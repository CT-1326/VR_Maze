using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS : MonoBehaviour
{

    public float rotSpd = 150f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpd * Time.deltaTime);
    }

}
