using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Notfraudulentmoney : MonoBehaviour
{
    public GameObject check;
 
    private void OnTriggerEnter(Collider other)
    {
      
        int i= check.GetComponent<MoneyChecker>().check();
            if (i != 1)
            {
                SceneManager.LoadScene("Win");
            }
            else
                SceneManager.LoadScene("Failed");
    
    }
}
