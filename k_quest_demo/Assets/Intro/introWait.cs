using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introWait : MonoBehaviour
{
    public float waitTime;
    void Start()
    {
        StartCoroutine(WaitForLevel());
    }
    IEnumerator WaitForLevel()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
    }
}
