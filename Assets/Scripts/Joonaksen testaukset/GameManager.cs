using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool loputonPeli;
    public Transform player;


    public static bool gameRunning;
    Vector2 playerStartPos;
    public List<GameObject> levelObjects;
    // Start is called before the first frame update
    private void Start()
    {
            playerStartPos = player.transform.position;
            gameRunning = true;
    }
    // Update is called once per frame




    void MoveToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    private static GameManager instance;

    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        else
        {
            instance = this;
        }
    }
}
