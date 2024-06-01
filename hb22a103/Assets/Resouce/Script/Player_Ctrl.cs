using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ctrl : MonoBehaviour
{
    public float speed=1.0f;
    Plane plane = new Plane();
	float distance = 0;
    private Rigidbody PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb=this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerRb=this.gameObject.GetComponent<Rigidbody>();
        // カメラとマウスの位置を元にRayを準備
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		// プレイヤーの高さにPlaneを更新して、カメラの情報を元に地面判定して距離を取得
		plane.SetNormalAndPosition (Vector3.up, transform.localPosition);
		if (plane.Raycast (ray, out distance)) {

			// 距離を元に交点を算出して、交点の方を向く
			var lookPoint = ray.GetPoint(distance);
			transform.LookAt (lookPoint);
		}
        if(!Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.A)&&
            !Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.D))
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            }
        if(Input.GetKey(KeyCode.W))
        {
           Vector3 velocitys = new Vector3(0, 0, speed);
           PlayerRb.GetComponent<Rigidbody>().velocity = velocitys * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            Vector3 velocitys = new Vector3(-speed, 0, 0);
            PlayerRb.GetComponent<Rigidbody>().velocity = velocitys * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            Vector3 velocitys = new Vector3(0, 0, -speed);
            PlayerRb.GetComponent<Rigidbody>().velocity = velocitys * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 velocitys = new Vector3(speed, 0, 0);
            PlayerRb.GetComponent<Rigidbody>().velocity = velocitys * Time.deltaTime;
        }
        
    }
}
