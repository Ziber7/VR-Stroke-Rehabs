using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlueBall : MonoBehaviour
{
    // Untuk Reset Posisi
    [SerializeField] Transform originPosition;
    [SerializeField] Transform obj;

    Collider BucketCollider;
    Rigidbody Rb;
    public GameObject UICheckMark;
    public GameObject WrongMark;
    public int BallCode;
    public int BallGetCount;
    public string BallCount;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip clipWrong;



    // Start is called before the first frame update
    void Start()
    {
        BucketCollider = GetComponent<Collider>();
        Rb = GetComponent<Rigidbody>();

        obj = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FloorTag")
        {
            obj.transform.position = originPosition.position;
            obj.transform.rotation = originPosition.rotation;
        }

        if (BallCode == 1)
        {
            if (other.gameObject.tag == "BucketBlue")
            {
                BallCounterIncrease();
                BallGetCount = PlayerPrefs.GetInt("BallCount") + 1;
                PlayerPrefs.SetInt("BallCount", BallGetCount);
            }
            else 
            {
                WrongBall();
            }
        }

        if (BallCode == 2)
        {
            if (other.gameObject.tag == "BucketRed")
            {
                BallCounterIncrease();
                BallGetCount = PlayerPrefs.GetInt("BallCount") + 1;
                PlayerPrefs.SetInt("BallCount", BallGetCount);
            }
            else 
            {
                WrongBall();
            }
        }

        if (BallCode == 3)
        {
            if (other.gameObject.tag == "BucketGreen")
            {
                BallCounterIncrease();
                BallGetCount = PlayerPrefs.GetInt("BallCount") + 1;
                PlayerPrefs.SetInt("BallCount", BallGetCount);
            }
            else 
            {
                WrongBall();
            }
        }

    }

    void OnTriggerExit(Collider other) 
    {
        if (BallCode == 1)
        {
            if (other.gameObject.tag != "BucketBlue")
            {
                WrongMark.SetActive(false);
            }
        }

        if (BallCode == 2)
        {
            if (other.gameObject.tag != "BucketRed")
            {
                WrongMark.SetActive(false);
            }
        }

        if (BallCode == 3)
        {
            if (other.gameObject.tag != "BucketGreen")
            {
                WrongMark.SetActive(false);
            }
        }
    }

    public void BallCounterIncrease()
    {
        audioSource.PlayOneShot(clip, 0.8f);
        BucketCollider.enabled  = false;
        Rb.constraints = RigidbodyConstraints.FreezePosition;
        UICheckMark.SetActive(true);
    }

    public void WrongBall()
    {
        audioSource.PlayOneShot(clipWrong, 0.8f);
        WrongMark.SetActive(true);
    }


}
