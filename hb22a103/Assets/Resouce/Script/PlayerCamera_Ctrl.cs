using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera_Ctrl : MonoBehaviour
{
    private Vector3 BasePos; 
    private float MousePosX,MousePosY;
    public GameObject Player;
    private Vector3 Postmp; 
    // Start is called before the first frame update
    void Start()
    {
        Postmp=Player.gameObject.transform.position-this.gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        BasePos=Player.gameObject.transform.position-Postmp; 
        MousePosX=Input.mousePosition.x;
        MousePosY=Input.mousePosition.y;

        if(MousePosX<=100||MousePosX>=1820||
        MousePosY<=30||MousePosY>=1050)
        {
            if(MousePosX<=960)
            {
                this.gameObject.transform.position+=new Vector3((960-MousePosX)*-0.0001f,0,0);
            }
            if(MousePosX>=960)
            {
                this.gameObject.transform.position+=new Vector3((960-MousePosX)*-0.0001f,0,0);
            }
            if(MousePosY<=540)
            {
                this.gameObject.transform.position+=new Vector3(0,0,(540-MousePosY)*-0.0001f);
            }
            if(MousePosY>=540)
            {
                this.gameObject.transform.position+=new Vector3(0,0,(540-MousePosY)*-0.0001f);
            }
        }

        //if(Input.GetKey(KeyCode.Space))
        //{
            this.gameObject.transform.position=BasePos;
        //}
    }
}
