using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;

    public Text scoretext;

    private void Awake()
    {
        inst = this;    
    }

    public void Incrementscore()
    {
        score++;
        scoretext.text = "score : " + score;
    }

}
