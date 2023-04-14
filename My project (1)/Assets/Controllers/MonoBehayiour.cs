using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehayiour : MonoBehaviour
{
    public float moyespeed = 1.0f;
    public GameObject playerPivot;
    Camera viewcamera;
    Vector3 velociry;
    // Start is called before the first frame update
    void Start()
    {
        viewcamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
