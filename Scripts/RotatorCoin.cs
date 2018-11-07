using UnityEngine;
using System.Collections;

public class RotatorCoin : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(00, 80, 00) * Time.deltaTime);
    }
}