using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    #region SINGLETON PATTERN
    private static audioManager _instance;
    public static audioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<audioManager>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("GameManager");
                    _instance = container.AddComponent<audioManager>();
                    container.tag = "GameManager";
                }
            }

            return _instance;
        }
    }
    #endregion

    public AudioClip[] musique;
    public AudioSource audioSource;
    public AudioSource audioClique;
    public int MusiqueJouer; 
    
    void Start()
    {
        audioSource.clip = musique[0];
        audioSource.Play(); 
    }

    
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            MusiqueSuivant();
        }
    }
    public void MusiqueSuivant()
    {
        MusiqueJouer = (MusiqueJouer + 1) % musique.Length;
        audioSource.clip = musique[MusiqueJouer];
        audioSource.Play();

    }
    public void  son()
    {
        audioClique.Play(); 
    }
   

}
