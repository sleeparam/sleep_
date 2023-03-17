using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        int answer2;
        answer2 = n1 = n2;
        Debug.Log(answer);

        int answer3 = 10;
        answer3 += 5;
        Debug.Log(answer3);
        answer3++;
        Debug.Log(answer3);

        string str = "Happy ";
        string str2 = "birthday";

        str += str2;
        Debug.Log(str);

        string messege = str + answer3;
        Debug.Log(messege);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
