using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera-Control/MouseLook")]
public class MouseLook : MonoBehaviour
{
    //выподающий список настроек осей
    public enum RorarionAxes { MouseXandY = 0, MouseX = 1, MouseY = 2 };
    public RorarionAxes axes = RorarionAxes.MouseXandY;
    // чувствительность мышки 
    public float sensivityX = 2f;
    public float sensivityY = 2f;

    //переменные мин-мах угла вращения по оси х
    public float minX = -360f;
    public float maxX = 360f;
    //переменные мин-мах угла вращения по оси у
    public float minY = -360f;
    public float maxY = 360f;

    //переменные определяющие текущий угол вращения
    float rotationX = 0f;
    float rotationY = 0f;

    // pepremennaja Q
    Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
           
        }
        originalRotation = transform.localRotation;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360f) angle += 360f;
        if (angle > 360f) angle -= 360f;
        return Mathf.Clamp(angle, min, max);
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RorarionAxes.MouseXandY)
        {
            rotationX += Input.GetAxis("Mouse X") * sensivityX;
            rotationY += Input.GetAxis("Mouse Y") * sensivityY;

            rotationX = ClampAngle(rotationX, minX, maxX);
            rotationY = ClampAngle(rotationY, minY, maxY);

            Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
            Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);

            transform.localRotation = originalRotation * xQuaternion * yQuaternion;
        }
        else if (axes == RorarionAxes.MouseX)
        {
            rotationX += Input.GetAxis("Mouse X") * sensivityX;
            rotationX = ClampAngle(rotationX, minX, maxX);
            Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
            transform.localRotation = originalRotation * xQuaternion;
        }
        else if (axes == RorarionAxes.MouseY)
        {
            rotationY += Input.GetAxis("Mouse Y") * sensivityY;
            rotationY = ClampAngle(rotationY, minY, maxY);
            Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);
            transform.localRotation = originalRotation * yQuaternion;

        }
    }
}
