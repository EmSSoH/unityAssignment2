using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinpickup : MonoBehaviour
{

    public int count;
    public AudioSource ping;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ping = GetComponent<AudioSource>();
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            ping.Play();
            countText.GetComponent<TweenTransforms>().Begin();

        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
