using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{
   
    //Scene kontrolu yaparak ana oyuna geri donus saglanir.

    public void NextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
