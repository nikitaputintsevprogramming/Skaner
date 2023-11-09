using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Pagination
{
    public class OneButton : MonoBehaviour
    {
        [SerializeField] private GameObject HorSlider;

        void Start()
        {
            
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("1 key was pressed.");
                HorSlider.GetComponent<PagedRect>().NextPage();
            }
        }
    }
}
