using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Ctrl : MonoBehaviour
{
    public float x=0;
    public int i=1;
    public bool isCountUp=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x=i*0.001f;
        this.transform.Rotate(0.0f,x,0.0f);
        if(isCountUp){
            if(i<=5000)
            {
                i+=1;
            }
            else
            {
                isCountUp=false;
            }
        }
        else
        {
            if(i>=0)
            {
                i-=1;
            }
            else
            {
                isCountUp=true;
                Debug.Log("会いたい上大");
            }

        }
        
    }
}
