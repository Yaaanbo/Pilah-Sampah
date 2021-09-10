using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampahSpawner : MonoBehaviour
{
    public float delay = 0.8f;
    float timer;
    public GameObject[] Sampah;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            int random = Random.Range(0, Sampah.Length);
            Instantiate(Sampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
