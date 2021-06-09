using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("������ ���")] // ����� ������ ��� �������� ������������ �������� "������ ���"
    [SerializeField] private AudioClip[] Notes = new AudioClip[10]; // ������

    void Start()
    {
        AudioNotes = GetComponent<AudioSource>(); // ��������� AudioSource � �������
    }

    public void PlaySound(int numberNotes) // ����� � ����������, � ������� �������� ����� �������� ����
    {
        AudioNotes.PlayOneShot(Notes[numberNotes]); // �������������� ����� ��� ����������
    }
}