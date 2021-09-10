using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampahDetector : MonoBehaviour
{
    public string nameTag;
    public AudioClip benar;
    public AudioClip salah;
        AudioSource audioBenar;
        AudioSource audioSalah;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        audioBenar = gameObject.AddComponent<AudioSource>();
        audioBenar.clip = benar;

        audioSalah = gameObject.AddComponent<AudioSource>();
        audioSalah.clip = salah;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Data.score += 25;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            audioBenar.Play();
        }
        else
        {
            Data.score -= 5;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            audioSalah.Play();
        }
    }
}
