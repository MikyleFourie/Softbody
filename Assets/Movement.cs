using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject bone1;
    [SerializeField] private GameObject bone2;
    [SerializeField] private float moveSpeed = 100;
    [SerializeField] private float horizontalMovement;

    [SerializeField] private Rigidbody2D b1RB;
    [SerializeField] private Rigidbody2D b2RB;
    // Start is called before the first frame update
    void Start()
    {
        b1RB = bone1.GetComponent<Rigidbody2D>();
        b2RB = bone1.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        //bone1.transform.Translate(new Vector3(horizontalMovement, 0, 0) * moveSpeed * Time.deltaTime);
        //bone2.transform.Translate(new Vector3(horizontalMovement, 0, 0) * moveSpeed * Time.deltaTime);

        b1RB.AddForce(transform.right * horizontalMovement * moveSpeed);
        b2RB.AddForce(transform.right * horizontalMovement * moveSpeed);

    }
}
