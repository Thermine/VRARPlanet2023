using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField]
    private GameObject[] levels;

    [Space(3)]

    [Header("Time Texts")]
    [SerializeField]
    private GameObject[] numbers;
    [SerializeField]
    private GameObject finalPanel;
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private int scoreHeight = 1;
    [SerializeField]
    private int moneyHeight = 100;

    private int score = 0;
    private int moneyCount = 0;

    private int levelNumber = 0;

    public void Start()
    {
        StartCoroutine("Pausing");
    }

    public void TrueAnswer()
    {
        score += 1;
        moneyCount += moneyHeight;
        Destroy(levels[levelNumber]);
        if(levelNumber < 4)
        {
            levelNumber += 1;
        }
        else
        {
            finalPanel.SetActive(true);
            scoreText.text = "Выполнено правильно: " + score + " / 5, Монет: " + moneyCount;
        }
        levels[levelNumber].SetActive(true);
    }

    public void FalseAnswer()
    {
        if(score > 0)
        {
            score -= 1;
        }
        if(moneyCount > 0)
        {
            moneyCount -= moneyHeight;
        }
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    IEnumerator Pausing()
    {
        yield return new WaitForSeconds(1f);
        numbers[0].SetActive(true);
        yield return new WaitForSeconds(1f);
        numbers[0].SetActive(false);
        numbers[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        numbers[1].SetActive(false);
        numbers[2].SetActive(true);
        yield return new WaitForSeconds(1f);
        numbers[2].SetActive(false);
        numbers[3].SetActive(true);
        yield return new WaitForSeconds(1f);
        numbers[3].SetActive(false);
        SliderController.Instance._activeSlider = true;
    }


}
