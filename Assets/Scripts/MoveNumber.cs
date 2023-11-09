using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace UI.Pagination
{
    public class MoveNumber : MonoBehaviour
    {
        [SerializeField] private GameObject HorSlider;

        [SerializeField] private Text _textCount; // Ссылка на компонент текста
        [SerializeField] private UnityEngine.Video.VideoPlayer _skanVideo;

        [SerializeField] public int upNumber;

        private float counter;

        private IEnumerator coroutine;


        void Start()
        {
            upNumber = Random.Range(85, 99);
            counter = 0f; // Устанавливаем начальное значение счетчика
        }

        void Update()
        {

            if (gameObject.activeSelf && counter <= upNumber)
            {
                counter += 100 / (float)_skanVideo.length * Time.deltaTime; // Увеличиваем счетчик на пропорциональное значение в каждом кадре
                _textCount.text = Mathf.Round(counter).ToString() + "%"; // Отображаем значение счетчика
            }
            else
            {
                //print("отсчет");
                coroutine = WaitAndPrint(10.0f);
                StartCoroutine(coroutine);

                //print("finish " + Time.time);
            }
        }
        private IEnumerator WaitAndPrint(float waitTime)
        {
            while (true)
            {
                yield return new WaitForSeconds(waitTime);
                //print("WaitAndPrint " + Time.time);
                SceneManager.LoadScene(0);
            }
        }
    }
}

