using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject jumpText;
    public AudioClip[] audioClip;
    private AudioSource audioSource;

    float jumpPower = 5f;
    int jumpCounter = 0;

    bool isOnGround = true;

    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerRB.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            jumpCounter++;
            isOnGround = false;
            jumpText.GetComponent<Text>().text = "Jumped: " + jumpCounter;

            int rand = Random.Range(0, audioClip.Length);
            audioSource.PlayOneShot(audioClip[rand]);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
