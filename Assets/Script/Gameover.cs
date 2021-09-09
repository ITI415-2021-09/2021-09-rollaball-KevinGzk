using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{

    public GameObject gameoverUI;
    public GameObject player;

    void Update()
    {
        if(player.transform.position.y <= 0)
        {
            Destroy(player);
            GameoverUI();
        }
    }
    
    void GameoverUI()
    {
        gameoverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
