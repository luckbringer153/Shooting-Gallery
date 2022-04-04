using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D Player;
    float Xdir;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Xdir = Input.GetAxisRaw("Horizontal");
        Player.velocity = new Vector2(Xdir * 5f, Player.velocity.y);

    }
}
