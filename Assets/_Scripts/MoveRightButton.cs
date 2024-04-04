using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;
    private float _speed = 5.0f;
    private bool _buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _buttonPressed = true;
        StartCoroutine(MoveRight());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _buttonPressed = false;
        StopCoroutine(MoveRight());
    }

    private IEnumerator MoveRight()
    {
        while (_buttonPressed)
        {
            _player.transform.Translate(Vector2.right * _speed * Time.deltaTime);
            yield return null;
        }
    }
}
