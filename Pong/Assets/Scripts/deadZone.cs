using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deadZone : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision) {
    //     Debug.Log("collision");
    // }
    public Text scorePlayer;
    public Text scoreEnemy;
    int escorePlayerQuantity;
    int escoreEnemyQuantity;
    public sceneChanger SceneChanger;
    public AudioSource Point;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Point.Play();
        if (gameObject.tag == "Izq")
        {
            escoreEnemyQuantity ++;
            updateScoreLabel(scoreEnemy, escoreEnemyQuantity);

        } else if(gameObject.CompareTag("Der")) 
        {
            escorePlayerQuantity ++;
            updateScoreLabel(scorePlayer, escorePlayerQuantity);
        }
        collision.GetComponent<ballBehavior>().gameStarted = false;
        checkScore();
    }
    void checkScore()
    {
        if(escorePlayerQuantity >= 3)
        {
            SceneChanger.changeSceneTo("winScene");
        } else if(escoreEnemyQuantity >= 3)
        {
            SceneChanger.changeSceneTo("loseScene");
        }
    }
    void updateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}
