using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    Text gametitleText, gamestartText;


    // Start is called before the first frame update
    void Start()
    {
        gametitleText = GameObject.Find("GameTitle").GetComponent<Text>();
        gamestartText = GameObject.Find("GameStartText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }
}

