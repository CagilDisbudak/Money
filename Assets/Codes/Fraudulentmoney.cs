
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fraudulentmoney : MonoBehaviour
{
    public GameObject check;


    private void OnTriggerEnter(Collider other)
    {
        int i = check.GetComponent<MoneyChecker>().check();
        if (i == 1)
            {
                SceneManager.LoadScene("Win");
            }
            else
                SceneManager.LoadScene("Failed");
        
    }
}
