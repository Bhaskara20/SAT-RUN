using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed; //declare kecepatan
    public float jumpForce; //declare gaya dorong kaki ke atas

    private Rigidbody2D myRigidbody; //declare rigidbody

    public bool grounded; //declare pengecekan sentuhan
    public LayerMask whatIsGround; //menentukan layer dari objek ground

    private Collider2D myCollider; //declare collider;

    private Animator myAnimator; //declare animator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>(); //program akan mencari komponen rigidbody dari object terkait
        myCollider = GetComponent<Collider2D>(); //program akan mencari komponen collider dari object terkait
        myAnimator = GetComponent<Animator>(); //program akan mencari komponen animator dari object terkait
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround); //jika myCollider menyentuh layer ground, maka nilai value dari bool grounded
        //adalah true

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y); //memberikan gaya dorong dan percepatan untuk objek
        //Vector2 mengandung value x dan y

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if(grounded){
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }//jika nilai bool grounded adalah true, maka program mengizinkan akses untuk pemberian gaya
        }
        //artinya jika kita menekan keyboard space atau menekan tombol mouse kiri, maka program akan memberikan gaya dorong untuk lompat keatas
        //tombol mouse memiliki 3 value(0 untuk kiri, 1 untuk kanan, 2 untuk tengah)

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x); //memberikan valu kepada float speed, agar bisa dibaca komponen animator
        myAnimator.SetBool("Grounded", grounded); //memberikan value kepada bool grounded, agar bisa dibaca oleh komponen animator
    }
}
