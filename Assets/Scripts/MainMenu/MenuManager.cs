using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    //public TextMeshProUGUI highScoreText;
    public string sceneName = "SceneName";

    private void Start()
    {
        //string getHighScore = PlayerPrefs.GetInt("HighScore").ToString();
        //highScoreText.text = getHighScore;
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
        //string getHighScore = PlayerPrefs.GetInt("HighScore").ToString();
        //highScoreText.text = getHighScore;
    }
}
