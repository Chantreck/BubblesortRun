using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("Массив нот")] // будет сверху над массивом отображаться название "Массив нот"
    [SerializeField] private AudioClip[] Notes = new AudioClip[10]; // массив

    void Start()
    {
        AudioNotes = GetComponent<AudioSource>(); // получение AudioSource с объекта
    }

    public void PlaySound(int numberNotes) // метод с параметром, с помощью которого будем выбирать трек
    {
        AudioNotes.PlayOneShot(Notes[numberNotes]); // вопроизведение звука без прерываний
    }
}