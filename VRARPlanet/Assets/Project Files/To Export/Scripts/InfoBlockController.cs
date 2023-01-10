using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoBlockController : MonoBehaviour
{
    [SerializeField]
    private GameObject _rightText;

    [SerializeField]
    private GameObject _particRight;

    public int _inf = 0;


    public void AcceptingTexts()
    {
        if (_inf < 4)
        {
            _inf += 1;
            Debug.Log("???? " + _inf);
        }
        else
        {
            _particRight.SetActive(true);
            _rightText.SetActive(true);
            StartCoroutine("LoadGame");
        }
    }

    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
