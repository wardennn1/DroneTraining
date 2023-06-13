using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackDroneCount : MonoBehaviour
{   
    // ������� ��������� ������
    public EnemySpawner enemySpawner;

    // ��������� �������� ������ ���������� ��������� ������
    public void DropdownHandler(int index){
        
        // ������ ��������� ���������� ��������� ������
        switch (index)
        {   
            case 0: 
                infoHandler.EnemyDroneCount = 3; 
                break;

            case 1: 
                infoHandler.EnemyDroneCount = 4; 
                break;

            case 2: 
                infoHandler.EnemyDroneCount = 5; 
                break;

            case 3: 
                infoHandler.EnemyDroneCount = 6; 
                break;

            default: 
                break;
        }
    }

}
