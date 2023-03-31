using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    void Sayhello()
    {
        Debug.Log("=======");
        Debug.Log("hello");
        Debug.Log("=======");
    }

    void Callname(string name)
    {
        Debug.Log("hello" + name);

    }

    int add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    void Start()
    {
        Callname("Tom");
        Callname("Matty");
        Callname("Loar");

        int answer;
        answer = add(2, 3);
        Debug.Log(answer);
        Debug.Log(add(7, 9));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
