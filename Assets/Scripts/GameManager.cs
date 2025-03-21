using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;  
    public TMP_Text scoreText; 

  
    //T‰ss‰ "t‰hti" pisteitten keruu. GameManager Inspectorissa lis‰‰ Text(TMP)
    public void AddStar()
    {
        if (score < 10) 
        {
            score++;
            UpdateScore();
        }
    }


    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Stars:" + score.ToString() + "/10";
        }
    }


    //T‰ss‰ Respawn jutskaa
    public void Delay(float delayTime)
    {

        StartCoroutine(ReloadSceneAfterDelay(delayTime));

    }


    private IEnumerator ReloadSceneAfterDelay(float delayTime)
    {

        yield return new WaitForSeconds(delayTime);


        string JaakkoTesti = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(JaakkoTesti);
    }
}
