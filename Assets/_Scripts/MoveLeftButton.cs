using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;
    private float _speed = 5.0f;
    private bool _buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _buttonPressed = true;
        StartCoroutine(MoveDown());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _buttonPressed = false;
        StopCoroutine(MoveDown());
    }

    private IEnumerator MoveDown()
    {
        while (_buttonPressed)
        {
            _player.transform.Translate(Vector2.left * _speed * Time.deltaTime);
            _player.GetComponent<SpriteRenderer>().flipX = true;
            yield return null;
        }
    }
}
