using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField]
    float backgroundMovementSpeed = 1f;
    Rigidbody2D background;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        background.velocity -= new Vector2(backgroundMovementSpeed, 0) * Time.deltaTime;
        if (transform.position.x == -12)
        {
            Instantiate(this, new Vector2(transform.position.x + 12, 0), Quaternion.identity);
        }
    }
}
