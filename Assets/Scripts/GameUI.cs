using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

      public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(2);
    }
   
   public void Quit()
   {
    Application.Quit();
   }
}
