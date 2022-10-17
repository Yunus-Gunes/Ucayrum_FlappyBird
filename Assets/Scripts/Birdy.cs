using UnityEngine;

public class Birdy : MonoBehaviour
{
    
    
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;

    public GameObject DeathScreen;

    public AudioSource sescontrol;
    public AudioClip u�ma;


    private void Start()
    {
        AdManager.hp = true;
        sescontrol = GetComponent<AudioSource>();
        Time.timeScale = 1;
        DeathScreen.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (isDead == false) { 
        //T�klan�rsa
        if (Input.GetMouseButtonDown(0))
        {
            //S��ra
            rb2D.velocity = Vector2.up * velocity;
            sescontrol.PlayOneShot(u�ma);
        }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            AdManager.hp = false;
            isDead = true;
            Time.timeScale = 0;
            
            DeathScreen.SetActive(true);


        }
    }

}
