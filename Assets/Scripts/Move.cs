using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 6);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
