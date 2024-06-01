using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColLight_Button : MonoBehaviour
{
    public bool isPressButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        //isPressButton=true;
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            isPressButton=true;
        }
    }
}
