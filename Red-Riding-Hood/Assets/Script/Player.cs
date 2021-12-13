using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool jDown;
    bool isJump;
    
    Vector3 moveVec;

    Animator anim;

    Rigidbody rigid;

    public int flower;
    public int maxFlower;

    public GameObject[] flowers;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
    }

    void GetInput() 
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        jDown = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
       
        anim.SetBool("isWalking", moveVec != Vector3.zero);
    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

    void Jump()
    {
        if (jDown && !isJump)
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isFalling", true);
            rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
            isJump = true;
        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Floor")
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", false);
            isJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            Item item = other.GetComponent<Item>();
            switch (item.type) {
                case Item.Type.Flower :
                    flowers[flower].SetActive(true);
                    flower += item.value;
                    if(flower > maxFlower)
                        flower = maxFlower;
                    break;
            }
            Destroy(other.gameObject);
        }      
    }
    
}

