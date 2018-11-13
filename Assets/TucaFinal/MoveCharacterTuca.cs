using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterTuca : MonoBehaviour
{
    Rigidbody _rigidbody;
    Animator anim;

    public Camera cam;

    [Tooltip("Character Speed")]
    float speed;

    public float walkSpeed;
    public float runSpeed;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        cam = Camera.main;

        speed = walkSpeed;
    }

    void Update()
    {
        #region Movement Character
        Vector3 right = cam.transform.right;
        Vector3 forward = Vector3.Cross(right, Vector3.up);

        float rotate = Input.GetAxis("Horizontal");

        Vector3 movement = Vector3.zero;

        movement += right * (Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        
        //movement += this.transform.forward * (Input.GetAxis("Vertical") * speed * Time.deltaTime);
        #endregion

        _rigidbody.MovePosition(transform.position + movement * Time.deltaTime);

        transform.Rotate(Vector3.up, rotate * 100 * Time.deltaTime);

        // Animation(movement);
    }

    void Animation(Vector3 velocidade)
    {
        anim.SetFloat("SpeedPercent", velocidade.magnitude);

    }
}
