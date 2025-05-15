using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int camelCase;
    public int PascalCase;
    public float timer = 30; //Timer variable. Used for tracking the time
    public float volume = 100.0f;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public TextMeshProUGUI timerText;
    


    //Update is called once per frame
    void Update() //Unity tells you how long since the last Update() -- Time.deltaTime. If subtracted by the float (timer in this case) in the Update, the float will go down per sec
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F2");
        if (timer <= 0) // Basic if statement. 
        {
            audioSource.PlayOneShot(audioClip); //Code that's suppose to run when the time is up
            timer = 30;
        }
    }
}