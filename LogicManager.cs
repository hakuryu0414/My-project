using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    // LogicManager 변수 선언
    public int PlayerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //스코어 함수
    [ContextMenu("increase Score")]
        public void addScore(int scoreToAdd){
            PlayerScore = PlayerScore+scoreToAdd;
            ScoreText.text =PlayerScore.ToString();
            }
    
    //리스타트게임 함수
    public void reStartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    //게임오버시 게임오버스크린 뜨는 함수
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
