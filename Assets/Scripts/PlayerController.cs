using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public float health;

    public FixedJoystick joyMoviment;

    public bool isJumping;
    public bool doubleJump;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        

        if(health == 0)
        {
            SceneManager.LoadScene("DeadScene");
        }

        // Debug
        if(Input.GetKeyDown(KeyCode.F))
        {
            health = 0;
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3(joyMoviment.Horizontal, 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

    public void Jump()
    {
        if (!isJumping)
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            doubleJump = true;
        }
        else
        {
            if (doubleJump)
            {
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }
}