using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Hasta la proxima");
    }
    public void PlayerVSPlayer()
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

        }
public void PlayerVSIA()
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
             print("Todavía no hace nada.");

        }
}
