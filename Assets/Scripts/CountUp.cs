using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Pagination
{
    public class CountUp : MonoBehaviour
    {
        [SerializeField] private GameObject HorSlider;

        [SerializeField] private Text _textCount; // Ссылка на компонент текста
        [SerializeField] private UnityEngine.Video.VideoPlayer _skanVideo;

        [SerializeField] public int upNumber;

        private float counter;

        void Start()
        {
            upNumber = Random.Range(85, 99);
            counter = 0f; // Устанавливаем начальное значение счетчика
        }

        void Update()
        {
            if (gameObject.activeSelf && counter <= upNumber)
            {
                _textCount.gameObject.SetActive(false);
                counter += 100 / (float)_skanVideo.length * Time.deltaTime; // Увеличиваем счетчик на пропорциональное значение в каждом кадре
                _textCount.text = Mathf.Round(counter).ToString(); // Отображаем значение счетчика
            }
            else
            {
                HorSlider.GetComponent<PagedRect>().NextPage();
            }
        }
    }
}