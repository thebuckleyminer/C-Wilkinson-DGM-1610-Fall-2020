using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Button RestartButton;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    private int score;
    public bool isGameActive;
    public GameObject titleScreen;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    public void GameOver()
    {
        RestartButton.gameObject.SetActive(true);
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void StartGame(int difficulty)
    {
        titleScreen.gameObject.SetActive(false);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        spawnRate /= difficulty;
        score = 0;
        UpdateScore(0);
    }
}
