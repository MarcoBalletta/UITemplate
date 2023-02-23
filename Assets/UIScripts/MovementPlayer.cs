using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed;
    public CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.SimpleMove(((transform.forward * Input.GetAxis("Vertical") + (transform.right * Input.GetAxis("Horizontal")) * speed * Time.deltaTime)));   
    }
}
