using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour
{

    float fallSpeed;
    float rotSpeed;

    void Start()
    {
        this.fallSpeed = 0.004f + 0.005f * Random.value;
        this.rotSpeed = 10f + 20f * Random.value;
    }

    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}