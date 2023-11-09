using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Pagination
{
    public class CountUp : MonoBehaviour
    {
        [SerializeField] private GameObject HorSlider;

        [SerializeField] private Text _textCount; // ������ �� ��������� ������
        [SerializeField] private UnityEngine.Video.VideoPlayer _skanVideo;

        [SerializeField] private int upNumber;

        private float counter;

        void Start()
        {
            upNumber = Random.Range(85, 99);
            counter = 0f; // ������������� ��������� �������� ��������
        }

        void Update()
        {
            if (gameObject.activeSelf && counter <= upNumber)
            {
                counter += 100 / (float)_skanVideo.length * Time.deltaTime; // ����������� ������� �� ���������������� �������� � ������ �����
                _textCount.text = Mathf.Round(counter).ToString(); // ���������� �������� ��������
            }
            else
            {
                HorSlider.GetComponent<PagedRect>().NextPage();
            }
        }
    }
}