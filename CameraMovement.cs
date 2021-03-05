using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public PlayerMovement thePlayer; //declare script player movement

    private Vector3 lastPlayerPosition; //declare vector untuk posisi terakhir player
    private float distanceToMove; //decalre untuk syarat jarak kamera agar bisa bergerak 
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovement>(); //mencari script player movement
        lastPlayerPosition = thePlayer.transform.position; //memberi informasi ke program mengenai koordinat player 
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = thePlayer.transform.position.x-lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
    }
}
