using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    AudioSource boom;
    // Start is called before the first frame update
    void Start()
    {
        boom = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "bullet")
        {
           // boom.Play();
            GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            
        }
    }
}
