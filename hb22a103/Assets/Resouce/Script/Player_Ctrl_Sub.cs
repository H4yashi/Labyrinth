using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ctrl_Sub : MonoBehaviour
{
    public float speed=1.0f;
    private Vector3 MousePostmp,MousePos,MyPos;
    public bool isMove=false;
    Plane plane = new Plane();
	float distance = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MyPos=this.gameObject.transform.position;
        // カメラとマウスの位置を元にRayを準備
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		// プレイヤーの高さにPlaneを更新して、カメラの情報を元に地面判定して距離を取得
		plane.SetNormalAndPosition (Vector3.up, transform.localPosition);
		if (plane.Raycast (ray, out distance)) {

			// 距離を元に交点を算出して、交点の方を向く
		    var lookPoint = ray.GetPoint(distance);
            MousePostmp=lookPoint;
			transform.LookAt (lookPoint);
		}


        if(Input.GetMouseButton(1))
        {
            MousePos=MousePostmp;
            isMove=true;
            
            //Debug.Log(MyPos+"からの"+MousePos);
        }

        if((MyPos.x<=MousePos.x+0.1f&&MyPos.x>=MousePos.x
        ||MyPos.x>=MousePos.x-0.1f&&MyPos.x<=MousePos.x)
        &&(MyPos.z<=MousePos.z+0.1f&&MyPos.z>=MousePos.z
        ||MyPos.z<=MousePos.z+0.1f&&MyPos.z>=MousePos.z))
        {
            //Debug.Log("○んこ");
            this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            isMove=false;
        }
        if(isMove)
        {
            if(MyPos.x<MousePos.x)
            {
                //Vector3 velocitys = gameObject.transform.rotation * new Vector3(speed, 0, 0);
                gameObject.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            }
            if(MyPos.x>MousePos.x)
            {
                //Vector3 velocitys = gameObject.transform.rotation * new Vector3(-speed, 0, 0);
                gameObject.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            }
            if(MyPos.z<MousePos.z)
            {
                //Vector3 velocitys = gameObject.transform.rotation * new Vector3(0, 0, speed);
                gameObject.transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
            }
            if(MyPos.z>MousePos.z)
            {
                //Vector3 velocitys = gameObject.transform.rotation * new Vector3(0, 0, -speed);
                gameObject.transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
            }
        }
    }
}
