using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{   

    // �������� ����������� ������
    public float camSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        // �������� ������ ������
        if (Input.GetKey(KeyCode.W))
            {
                pos.z += camSpeed * Time.deltaTime;
            }
        
        // �������� ������ �����
        if (Input.GetKey(KeyCode.S))
            {
                pos.z -= camSpeed * Time.deltaTime;
            }

        // �������� ������ ������
        if (Input.GetKey(KeyCode.D))
            {
                pos.x += camSpeed * Time.deltaTime;
            }

        // �������� ������ �����
        if (Input.GetKey(KeyCode.A))
            {
                pos.x -= camSpeed * Time.deltaTime;
            }
        
        // ������ ������ 
        if (Input.GetKey(KeyCode.RightShift))
        {
            pos.y += camSpeed * Time.deltaTime;
        }

        // �������� ������
        if (Input.GetKey(KeyCode.RightControl))
        {
            pos.y -= camSpeed * Time.deltaTime; 
        }

        // �������� ������
        transform.position = pos;

    }
}
