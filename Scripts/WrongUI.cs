using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongUI : MonoBehaviour
{
    public Transform Head;
    public Transform Ball;
    public GameObject WrongCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WrongCanvas.transform.position = Ball.position + new Vector3(0,0.1f,0);
        

        WrongCanvas.transform.LookAt(new Vector3 (Head.position.x, WrongCanvas.transform.position.y, Head.position.z));
        WrongCanvas.transform.forward *= -1;
    }
}
