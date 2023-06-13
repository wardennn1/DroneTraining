using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    // ������� ����� ��� ������
    public GameObject enemyDrone;
    
    // ����� �������� ��� ������������ ����������� ��������� ������
    Vector3[] whereToSpawn = new Vector3[6] {   
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 5f), 
                                                new Vector3(-30f, 0f, 5f), 
                                                new Vector3(-20f, 0f, 5f), 
                                                new Vector3(-25f, 0f, 13f), 
                                                new Vector3(-30f, 0f, 13f) 
                                            };
    
    // ����������� ���������� ��������� ������
    private float minDroneCount = 3;
    
    // ���������� ��������� ������
    private float totalEnemyDroneCount = infoHandler.EnemyDroneCount; 

    public GameObject parentDrone; //������������ ����

    // Start is called before the first frame update
    void Start()
    {   
        // ������ ������������ ����������� ������
        switch (totalEnemyDroneCount)
        {
            case 3:
                break;

            case 4:
                spawn(4);
                break;

            case 5:
                spawn(5);
                break;

            case 6:
                spawn(6);
                break;

            default: 
                break;
        }
    }

    // ��������� ����������� ������
    public void spawn (float droneCount)
    {   
        
            for (int i = 0; i <  totalEnemyDroneCount - minDroneCount; i++)
                
                {   
                    // ������������ ������������ ���������� �����
                    GameObject AllyDrone = Instantiate(enemyDrone, whereToSpawn[i+1], Quaternion.identity);
                }

    }

    // �������� �������� ��������� ������
    private void destroyDrone(float totalDrone, float droneCur)
    {
        
        for (int i = 0; i < totalDrone - droneCur; i++)

        {
            GameObject missingDrone = GameObject.FindWithTag("EnemyDrone");
            if (missingDrone != null)
                Destroy(missingDrone);

        }

    }
}
