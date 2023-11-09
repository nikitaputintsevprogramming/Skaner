using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveNumber : MonoBehaviour
{
    [SerializeField] private Text _textCount; // —сылка на компонент текста


    void Start()
    {
        
    }

    void Update()
    {
        if(gameObject.activeSelf)
        _textCount.transform.position = Vector3.Lerp(_textCount.transform.position, new Vector2(Screen.width/2, Screen.height / 2), 2f * Time.deltaTime);
    }
}
