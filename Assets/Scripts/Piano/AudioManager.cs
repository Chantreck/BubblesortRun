using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("Массив нот")] // будет сверху над массивом отображаться название "Массив нот"
    [SerializeField] private AudioClip[] Notes = new AudioClip[10]; // массив
    string rightWord = "57325377126542";
    string currentWord = "";
    void Start()
    {
        AudioNotes = GetComponent<AudioSource>(); // получение AudioSource с объекта
    }

    public void PlaySound(int numberNotes) // метод с параметром, с помощью которого будем выбирать трек
    {
        
        currentWord += (numberNotes+1).ToString();
        Debug.Log(currentWord);
        if (currentWord.Length > rightWord.Length)
            currentWord = currentWord.Substring(1);

        if (currentWord == rightWord)
            SceneManager.LoadScene("PreEnding");
        //Debug.Log("Right!");
        AudioNotes.PlayOneShot(Notes[numberNotes]); // вопроизведение звука без прерываний
    }
}