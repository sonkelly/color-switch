using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_controller : MonoBehaviour
{
    public GameObject circle_main, circle_main_2, circle_main_3;
    public float rotSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        circle_main.transform.Rotate(new Vector3(0, 0, 1 * rotSpeed));
        circle_main_2.transform.Rotate(new Vector3(0, 0, -1 * rotSpeed));
        circle_main_3.transform.Rotate(new Vector3(0, 0, 1 * rotSpeed));
    }
    public void startGame() {
        SceneManager.LoadScene(1);
    }
}
