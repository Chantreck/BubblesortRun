using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� ����������, �� � �� ������� ���������

public class Scene : MonoBehaviour
{
    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ������������ ����� (�� ��� � ��� ���������)

        // ����� ���� �������� ��� ���: SceneManager.LoadScene(0) - ��� �� ������
    }

}