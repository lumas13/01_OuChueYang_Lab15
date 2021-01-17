using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] bgmClip;
    private AudioSource audioSource;

    float volume = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            int rand = Random.Range(0, bgmClip.Length);
            audioSource.PlayOneShot(bgmClip[rand]);

            if (audioSource.clip = bgmClip[0])
            {
                audioSource.Stop();
                audioSource.PlayOneShot(bgmClip[rand]);
            }
            if (audioSource.clip = bgmClip[1])
            {
                audioSource.Stop();
                audioSource.PlayOneShot(bgmClip[rand]);
            }
            if (audioSource.clip = bgmClip[2])
            {
                audioSource.Stop();
                audioSource.PlayOneShot(bgmClip[rand]);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<AudioSource>().volume += volume * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<AudioSource>().volume -= volume * Time.deltaTime;
        }
    }
}
