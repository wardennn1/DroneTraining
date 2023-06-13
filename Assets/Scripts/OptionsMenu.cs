using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // ���� �����
    public GameObject optionsObject;
    public bool EscapeMenuOpen;

    // Update is called once per frame
    void Update()
    {   

        // ��������� ������� ������� Escape ��� ������ ���� �����
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EscapeMenuOpen == false)
            {
                EscapeMenuOpen = true;
                optionsObject.SetActive(true);
            }

            else
            {
                EscapeMenuOpen = false;
                optionsObject.SetActive(false);
            }
        }   
    }

    // ��������� ������� ������ ����������� �������������
    public void continueMod()
    {   
        EscapeMenuOpen = false;
        optionsObject.SetActive(false);
    }

    //��������� ������� ������ �������� � ������� ����
    public void backToMenu()
    {   
        // ���������� ���������� ���������� �� ����������� ��������
        infoHandler.AllyDroneCount = 3;
        infoHandler.EnemyDroneCount = 3;
        infoHandler.WeatherMode = 0;
        SceneManager.LoadScene(0);
    }

}
