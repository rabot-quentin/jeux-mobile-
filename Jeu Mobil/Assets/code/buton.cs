using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buton : MonoBehaviour
{
    public string Niv1;
    public string Niv2;
    public string Niv3;
    public string LancerPartie;
    public string niveaux;
  
    public void niveaux1()
    {
        Debug.Log("1");
        audioManager.Instance.son();
        SceneManager.LoadScene(Niv1);
        
    }
    public void niveaux2()
    {
        Debug.Log("2");
        audioManager.Instance.son();
        SceneManager.LoadScene(Niv2);        
    }
    public void niveaux3()
    {
        Debug.Log("3");
        audioManager.Instance.son();
        SceneManager.LoadScene(Niv3);
        
    }
    public void QuitGame()
    {
        Debug.Log("quiter");
        audioManager.Instance.son();
        Application.Quit();
        

    }
    public void lancerPartie()
    {
        Debug.Log("go");
        audioManager.Instance.son();
        SceneManager.LoadScene(LancerPartie);
        
    }
    public void Niveaux()
    {
        Debug.Log("niveaux");
        audioManager.Instance.son();
        SceneManager.LoadScene(niveaux);
        

    }
   
}
