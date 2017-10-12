using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";
    }

    void Update ()
    { //this is where game code go


    }

    private void FixedUpdate()
    {//this is where our physics code will go

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText(); 
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 3)
        {
            winText.text = "You Win!";
        }
    }
}
