using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterController : MonoBehaviour
{
    [SerializeField] float MovementSpeed;
    [SerializeField] float JumpForce;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb2d;
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float Horizontalaxis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(Horizontalaxis * MovementSpeed * Time.deltaTime, 0, 0);

        FlipControl(Horizontalaxis);

    }


    public void JumpControl()
    {
        rb2d.AddForce(Vector2.up * JumpForce);
    }

    


    public void FlipControl(float Horizontalaxis)
    {
        if (Horizontalaxis < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (Horizontalaxis > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (Horizontalaxis == 0)
        {
            spriteRenderer.flipX = spriteRenderer.flipX;
        }
    }


}
