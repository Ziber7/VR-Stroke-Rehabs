using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinUI : MonoBehaviour
{
    public GameObject Win;

    public AudioSource audioSource;
    public AudioClip winsfx;

    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            audioSource.PlayOneShot(winsfx, 0.5f);
            Win.SetActive(true);
        }
    }

}
