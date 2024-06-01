using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColLight_Arm : MonoBehaviour
{
    public bool isSetLight=false,isLoadFallEffect=false;
    public GameObject ButtonObj;
    private float RotCount=0;
    public GameObject LanthanSetObj;
    public GameObject LanthanObj;
    // Start is called before the first frame update
    void Start()
    {
        LanthanSetObj.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isSetLight=ButtonObj.GetComponent<OnColLight_Button>().isPressButton;
        if(isSetLight)
        {
            if(RotCount<160.0f)
            {
                this.gameObject.transform.rotation = Quaternion.Euler(RotCount, 0, 0);
                RotCount+=2.5f;
            }else if(!isLoadFallEffect)
            {
                isLoadFallEffect=true;
                //LanthanObj.transform.position+=new Vector3(0,0,0);
                Vector3 velocitys = new Vector3(30, -30, -20);
                LanthanObj.GetComponent<Rigidbody>().velocity = velocitys;
                LanthanSetObj.SetActive(true);
            }
        }
    }
}
