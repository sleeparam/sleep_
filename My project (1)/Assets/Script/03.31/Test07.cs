using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player
{
    private int hp = 100;
    private int Power = 50;

    public void Attack()
    {
        Debug.Log("데미지를 입었다.");
    }

    public void Damage(int damage)
    {
        int -= Damage;
        Debug.Log("데미지를 잃었다.");
    }

    public void Gethp()
    {
        
    }


}

public class Test07 : MonoBehaviour
{
    public Text platerHp;
    Player mPlater = new Player();
    // Start is called before the first frame update
    void Start()
    {
        //mPlater.Attack();
        //mPlater.Damage(30);
        //Debug.Log(mPlater.Gethp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
