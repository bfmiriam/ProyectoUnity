using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Colliders : MonoBehaviour
{

    public Text countText;
    private int count;

    // Use this for initialization
    void Start()
    {
        count = 0;  
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 10;
            countText.text = "Score: " + count.ToString();
        }

    }
}