using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 600f;
    private Rigidbody2D player;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown (0)) {
            if (player != null) {
                player.AddForce(Vector2.up * speed);
            }
        }


        if (Input.GetMouseButtonDown (1)) {
        }


        if (Input.GetMouseButtonDown (2)) {
        }

    }
}
