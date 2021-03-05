using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject thePlatform; //declare game object
    public Transform generationPoint; //declare titik yang nanti akan dibuat untuk spawn platform
    public float distanceBetween; //declare jarak per platform
    
    private float platformWidth; //declare ukuran platform

    public float distanceBetweenMin;
    public float distanceBetweenMax;
    //declare jarak maksimum dan minimum

    // Start is called before the first frame update
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x; //membaca ukuran platform
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(thePlatform,transform.position,transform.rotation);
        }//jika letak generator berada di sebelah kiri generation point, maka program akan terus menduplikat platform sesuai ukuran dan jarak yang diharapkan
    }
}
