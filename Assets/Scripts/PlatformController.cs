using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    int heal = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<CharachterController>().JumpControl();
                heal--;
                this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

                if (heal<=-0)
                {
                    Destroy(this.gameObject);
                }
            }

        }
    }
}
