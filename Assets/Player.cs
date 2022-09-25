using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float JumpSpeed;
    Rigidbody2D Rb;
    bool jump;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jump)
        {
            jump = false;
            Rb.AddForce(new Vector2(0, JumpSpeed),ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            jump = true;
        }
        if(collision.gameObject.CompareTag("enemy"))
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}

