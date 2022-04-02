using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyChecker : MonoBehaviour
{
    public GameObject money;
    public GameObject Uv;
    public int rand;
    GameObject FakeMoney;
    GameObject UvMoney;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        rand=  random.Next(1, 3);
        FakeMoney = GameObject.Find("Fakemoney");
        UvMoney = GameObject.Find("UvMoney");
        FakeMoney.SetActive(false);
        UvMoney.SetActive(false);

    }

   
    void Update()
    {
      
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Uv") {
            if (rand == 1)
            {
                money.SetActive(false);
                FakeMoney.SetActive(true);
            }
            else
            {
                money.SetActive(false);
                UvMoney.SetActive(true);
            }
       }

    }
    private void OnTriggerExit(Collider other)
    {
        money.SetActive(true);
        FakeMoney.SetActive(false);
        UvMoney.SetActive(false);
    }
    public int check()
    {
        return rand;
    }
}
