using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test04 : MonoBehaviour
{
    public int hp = 100;
    public Text textUI;
    public Text hpTextUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }
        if (hp < 50)
        {
            textUI.text = "����";
            //Debug.Log("����")
        }

        else if (hp > 200)
        {
            textUI.text = "����";
            //Debug.Log("����")
        }
        else
        {
            textUI.text = "���";
            //Debug.Log("���")

        }
        hpTextUI.text = "HP : " + hp.ToString();
    }
}
