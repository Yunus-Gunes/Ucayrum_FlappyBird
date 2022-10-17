using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{

    public int score;

    public TMP_Text ScoreText;

    public TMP_Text HighScore;

    public static int HighScore11;
    public static int HighScore22;
    public static int HighScore33;


    public static int scoreIndexx1;
    public static int scoreIndexx2;
    public static int scoreIndexx3;


    public int index;

    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
        ScoreText.text = score.ToString();
        
        
        HighScore.text = PlayerPrefs.GetInt("highScore").ToString();


        HighScore11 = PlayerPrefs.GetInt("HighScore11");
        HighScore22 = PlayerPrefs.GetInt("HighScore22");
        HighScore33 = PlayerPrefs.GetInt("HighScore33");

        

        index = CharacterSelection.index;
        
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if (score > PlayerPrefs.GetInt("highScore")) { 
            PlayerPrefs.SetInt("highScore", score);
        }

        scoreIndexx1 = PlayerPrefs.GetInt("scoreIndexx1");
        scoreIndexx2 = PlayerPrefs.GetInt("scoreIndexx2");
        scoreIndexx3 = PlayerPrefs.GetInt("scoreIndexx3");

    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void RestartGame()
    {

        if (score > PlayerPrefs.GetInt("HighScore11"))
        {

            PlayerPrefs.SetInt("HighScore33", PlayerPrefs.GetInt("HighScore22"));
            PlayerPrefs.SetInt("HighScore22", PlayerPrefs.GetInt("HighScore11"));
            PlayerPrefs.SetInt("HighScore11", score);

            PlayerPrefs.SetInt("scoreIndexx3", PlayerPrefs.GetInt("scoreIndexx2"));
            PlayerPrefs.SetInt("scoreIndexx2", PlayerPrefs.GetInt("scoreIndexx1"));
            PlayerPrefs.SetInt("scoreIndexx1", index);
            

            HighScore11 = PlayerPrefs.GetInt("HighScore11");
            HighScore22 = PlayerPrefs.GetInt("HighScore22");
            HighScore33 = PlayerPrefs.GetInt("HighScore33");

            
        }
        else if (score > PlayerPrefs.GetInt("HighScore22"))
        {
            PlayerPrefs.SetInt("HighScore33", PlayerPrefs.GetInt("HighScore22"));
            PlayerPrefs.SetInt("HighScore22", score);

            PlayerPrefs.SetInt("scoreIndexx3", PlayerPrefs.GetInt("scoreIndexx2"));
            PlayerPrefs.SetInt("scoreIndexx2", index);


            HighScore22 = PlayerPrefs.GetInt("HighScore22");
            HighScore33 = PlayerPrefs.GetInt("HighScore33");

        }
        else if (score > PlayerPrefs.GetInt("HighScore33"))
        {
            PlayerPrefs.SetInt("HighScore33", score);

            PlayerPrefs.SetInt("scoreIndexx3", index);

            HighScore33 = PlayerPrefs.GetInt("HighScore33");


        }

        SceneManager.LoadScene(2);
    }

    public void goMenu()
    {

        if (score > PlayerPrefs.GetInt("HighScore11"))
        {

            PlayerPrefs.SetInt("HighScore33", PlayerPrefs.GetInt("HighScore22"));
            PlayerPrefs.SetInt("HighScore22", PlayerPrefs.GetInt("HighScore11"));
            PlayerPrefs.SetInt("HighScore11", score);

            PlayerPrefs.SetInt("scoreIndexx3", PlayerPrefs.GetInt("scoreIndexx2"));
            PlayerPrefs.SetInt("scoreIndexx2", PlayerPrefs.GetInt("scoreIndexx1"));
            PlayerPrefs.SetInt("scoreIndexx1", index);
            

            HighScore11 = PlayerPrefs.GetInt("HighScore11");
            HighScore22 = PlayerPrefs.GetInt("HighScore22");
            HighScore33 = PlayerPrefs.GetInt("HighScore33");
            
            
        }
        else if (score > PlayerPrefs.GetInt("HighScore22"))
        {
            PlayerPrefs.SetInt("HighScore33", PlayerPrefs.GetInt("HighScore22"));
            PlayerPrefs.SetInt("HighScore22", score);

            PlayerPrefs.SetInt("scoreIndexx3", PlayerPrefs.GetInt("scoreIndexx2"));
            PlayerPrefs.SetInt("scoreIndexx2", index);


            HighScore22 = PlayerPrefs.GetInt("HighScore22");
            HighScore33 = PlayerPrefs.GetInt("HighScore33");

        }
        else if (score > PlayerPrefs.GetInt("HighScore33"))
        {
            PlayerPrefs.SetInt("HighScore33", score);

            PlayerPrefs.SetInt("scoreIndexx3", index);

            HighScore33 = PlayerPrefs.GetInt("HighScore33");


        }

        SceneManager.LoadScene(0);
    }



}
