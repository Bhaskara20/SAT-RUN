using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject destroyer; //declare destruction
    // Start is called before the first frame update
    void Start()
    {
        destroyer = GameObject.Find("PlatformDestructionPoint"); //mencari PlatformDestructionPoint didalam unity
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyer.transform.position.x)
        {
            Destroy(gameObject);
        }
        //jika platform berada di sebelah kiri destroyer, destroyer aka secara otomatis mendeteksi platform dan menghapus data platform
    }
}
