using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public int herbNum = 1;
    // Start is called before the first frame update
    void Start()
    {

        if (herbNum == 1)
        {
            Debug.Log("체력을 50 회복");
        }
        else
        {
            Debug.Log("체력을 -50 ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
