using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characteList;
    public static int index;


    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        characteList = new GameObject[transform.childCount];

        //Fill the array with our models
        for( int i = 0;i < transform.childCount; i++)
            characteList[i] = transform.GetChild(i).gameObject;

        //We toggle off their renderer
        foreach(GameObject go in characteList)
            go.SetActive(false);

        //We toggle on the selected character
        if (characteList[index])
            characteList[index].SetActive(true);

    }


    public void ToggleLeft()
    {
        characteList[index].SetActive(false);

        index--;
        if (index < 0)
            index = characteList.Length - 1;

        characteList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        characteList[index].SetActive(false);

        index++; 
        if (index == characteList.Length)
            index = 0;

        characteList[index].SetActive(true);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);

        SceneManager.LoadScene(0);
    }
}
