using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy BirdScript;

    public GameObject borular;

    public float height;


    private float time = 2f;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {

            Instantiate(borular, new Vector3(1, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

            if (time>1f) {
                time = time - 0.025f;
            }
        }
        
    }
}
