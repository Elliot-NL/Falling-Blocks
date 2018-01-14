using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float slowFactor = 10f;

    public void EndGame()
    {
        //Testing:
        //Debug.Log("Ending Game");
        StartCoroutine(RestartLevel());

    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowFactor;
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  
    }

}
