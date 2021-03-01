using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int score;

    public Text scoreText;

    public GameObject menuUI;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {

        // Deactivate MenuUI 
        menuUI.SetActive(false);

        // Activate ScoreText
        scoreText.gameObject.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Score()
    {
        
        score++;

        scoreText.text = score.ToString();

    }

}
