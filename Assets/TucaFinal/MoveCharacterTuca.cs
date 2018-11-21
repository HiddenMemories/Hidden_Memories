using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterState1
{
    idle,
    walking,
    running,
    crounching,
    pushing,
    dead
}

public class MoveCharacterTuca : MonoBehaviour
{

    public CharacterState1 characterState1;
    Rigidbody _rigidbody;
    Animator anim;

    public Camera cam;

    [Tooltip("Character Speed")]
    float speed;
    public float speedSmoothTime = 0.5f;

    float moveHorizontal;
    float moveVertical;

    public float walkSpeed;
    public float runSpeed;

    Vector3 movement;

    public bool flashLight = false;
    public GameObject light;

    void Awake()
    {

        light.SetActive(false);
        _rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

        cam = Camera.main;

        speed = 0;
    }

    void Update()
    {

        #region COMENTADO
        /*
        #region Movement Character
        Vector3 right = cam.transform.right;
        Vector3 forward = Vector3.Cross(right, Vector3.up);

        //  float rotate = Input.GetAxis("Horizontal");

        // Vector3 movement = Vector3.zero;

        movement += right * (Input.GetAxis("Horizontal") * speed * Time.deltaTime);


        movement += this.transform.forward * (Input.GetAxis("Vertical") * speed * Time.deltaTime);
        #endregion       

        transform.Translate(movement * Time.deltaTime * speed);
        //_rigidbody.MovePosition(transform.position + movement * Time.deltaTime);

        // transform.Rotate(Vector3.up, rotate * 100 * Time.deltaTime);
        */
        #endregion

        if (movement == Vector3.zero)
        {
            speed = 0;
            characterState1 = CharacterState1.idle;
        }

        if (movement != Vector3.zero)
        {
            speed = walkSpeed;
            characterState1 = CharacterState1.walking;
        }

        if (Input.GetKey(KeyCode.LeftShift) && movement != Vector3.zero && moveVertical > 0)
        {
            speed = runSpeed;
            characterState1 = CharacterState1.running;
        }


        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        print(moveVertical);

        movement = new Vector3(0f, 0f, moveVertical);

        transform.Rotate(Vector3.up, moveHorizontal * 100 * Time.deltaTime);
        transform.Translate(movement * Time.deltaTime * speed);

        Animation(speed);

        if(Input.GetKeyDown(KeyCode.F))
        {
           if(flashLight==false)
            {
                flashLight = true;
                light.SetActive(true);
            }
            else
            {
                flashLight = false;
                light.SetActive(false);
            }
        }
    }

    void Animation(float velocidade)
    {
        anim.SetFloat("SpeedPercent", speed, speedSmoothTime, Time.deltaTime);

    }
   
}
