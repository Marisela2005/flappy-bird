using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLenght;

    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        groundHorizontalLenght = groundCollider.size.x;
    }
    private void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontalLenght * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizontalLenght)
        {
            RepositionBackground();
        }
    }
}
