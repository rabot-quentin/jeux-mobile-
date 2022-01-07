using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject background;
    
    public Animator transition;

    public bool buttonRestartPressed = false;
    public bool buttonMenuPressed = false;

    public float transitionTime = 1f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        background.SetActive(true);

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

        if (buttonRestartPressed = true)
        {
            OnButtonRestart();
        }

        if (buttonMenuPressed = true)
        {
            OnButtonMenu();
        }
    }

    public void LoadRestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnButtonRestart()
    {
        LoadRestartLevel();
    }

    public void OnButtonMenu()
    {
        LoadMenuLevel();
    }
}
