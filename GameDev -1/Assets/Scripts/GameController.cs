using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool gameOver = false;
    public float scrollSpeed = -500f;
    public GameObject GameOverText;
    public Animator anima;

    public Text Scoretext;

    private int score = 0;

    // Use this for intialization
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //Score();

    }

    public void HeroDied()
    {
        GameOverText.SetActive(true);
        //GameController.instance.gameOver = true;
        anima.SetTrigger("player_hurt");
    }

    private void Score() {
        if (GameController.instance.gameOver)
        {
            return;
        }
        score++;
        Scoretext.text = "Score: " + score.ToString();
    }

}
