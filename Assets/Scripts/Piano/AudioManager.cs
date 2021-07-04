using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("������ ���")] // ����� ������ ��� �������� ������������ �������� "������ ���"
    [SerializeField] private AudioClip[] Notes = new AudioClip[10]; // ������
    string rightWord = "57325377126542";
    string currentWord = "";
    void Start()
    {
        AudioNotes = GetComponent<AudioSource>(); // ��������� AudioSource � �������
    }

    public void PlaySound(int numberNotes) // ����� � ����������, � ������� �������� ����� �������� ����
    {
        
        currentWord += (numberNotes+1).ToString();
        Debug.Log(currentWord);
        if (currentWord.Length > rightWord.Length)
            currentWord = currentWord.Substring(1);

        if (currentWord == rightWord)
            SceneManager.LoadScene("PreEnding");
        //Debug.Log("Right!");
        AudioNotes.PlayOneShot(Notes[numberNotes]); // �������������� ����� ��� ����������
    }
}