using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MouseAimCamera : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);

  

        transform.LookAt(target.transform);
    }

}



//void FixedUpdate()
// {
// float rotateHorizontal = Input.GetAxis("Mouse X");
//float rotateVertical = Input.GetAxis("Mouse Y");
//transform.RotateAround(target.transform.position, -Vector3.up, rotateHorizontal * rotateSpeed);
//transform.RotateAround(Vector3.zero, transform.right, -rotateVertical * rotateSpeed);

//called every frame (defaults is 50 frames per second)

//private Camera mainCamera;
//void Start()
//{
//mainCamera = transform.Find("MainCamera").GetComponent<Camera>();
//}


// Update is called once per frame
//void Update()
//{
//float x = Input.GetAxisRaw("Mouse X") * speed;
//float y = Input.GetAxisRaw("Mouse Y") * speed;
//The offset of the mouse's x-axis, directly used to rotate the y-axis of the character
//transform.Rotate(new Vector3(0, x, 0), Space.Self);
//Mouse y-axis offset, used to rotate the camera around the character's x-axis  
//

//}
//private void LateUpdate()
//{
//float horizontal = Input.GetAxis("Mouse X") * speed;
//float vertical = Input.GetAxis("Mouse Y") * speed;

//follow.transform.Rotate(new Vector3(0, horizontal, 0), Space.Self);
//follow.transform.RotateAround(transform.position, transform.right, -vertical);
//}
// void Start()
//  {
//     offset = target.transform.position - transform.position;


// void LateUpdate()
// {
//    float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
//   target.transform.Rotate(0, horizontal, 0);

//  float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
//  target.transform.Rotate(-vertical, 0, 0);

//  transform.LookAt(target.transform);
// }