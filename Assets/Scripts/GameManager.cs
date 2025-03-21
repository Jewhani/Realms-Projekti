using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{

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
