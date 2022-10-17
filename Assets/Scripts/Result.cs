using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public TMP_Text HighScore1;
    public TMP_Text HighScore2;
    public TMP_Text HighScore3;

    public Text isim1;
    public Text isim2;
    public Text isim3;
    private string[] characteListName = { "Yunus", "Taha", "Kerem", "Mete", "Yusuf","Zeynep","FatmaGül","Furkan","Kedi","Tahaa" };


    private GameObject[] characteList;
    public static int index;



    private void Start()
    {
        

        characteList = new GameObject[transform.childCount];

        //Fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
            characteList[i] = transform.GetChild(i).gameObject;

        //We toggle off their renderer
        foreach (GameObject go in characteList)
            go.SetActive(false);

        //We toggle on the selected character
        
        characteList[GameManager.scoreIndexx1].SetActive(true);

    }


    public void Update()
    {
        HighScore1.text = GameManager.HighScore11.ToString();
        HighScore2.text = GameManager.HighScore22.ToString();
        HighScore3.text = GameManager.HighScore33.ToString();

        isim1.text = characteListName[GameManager.scoreIndexx1];
        isim2.text = characteListName[GameManager.scoreIndexx2];
        isim3.text = characteListName[GameManager.scoreIndexx3];


    }

    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }

}
