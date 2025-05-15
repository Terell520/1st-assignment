using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public static Score instance;

    private void Awake()
    {
        instance = this; 
    }

    //Keep track of the points added
    int score = 0;
        
    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }

    public void Addscore()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }

}
