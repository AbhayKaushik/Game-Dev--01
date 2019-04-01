using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public bool gameOver = false;
    public float scrollSpeed = -500f;
    public GameObject GameOverText;
    public Animator anima;

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

    }

    public void HeroDied()
    {
        GameOverText.SetActive(true);
        //GameController.instance.gameOver = true;
        anima.SetTrigger("player_hurt");
    }

}
