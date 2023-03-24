using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  for (int I = 0; I < 5; I++)
        //  {
        //    Debug.Log(I);
        //  }
        // for (int I = 0; I < 10; I += 2)
        //  {
        //    Debug.Log(I);
        //  }
        //for (int i = 0; i < 10; i--)
        //  {
        // Debug.Log(i);
        //  }

        for (int i = 0; i < 10; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log(i);
            }
        }

        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += i;
            Debug.Log(sum);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i + j).ToString());
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
