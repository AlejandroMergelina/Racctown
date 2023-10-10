using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoseFollower : MonoBehaviour
{

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private UIInventoryItem item;

    public void Awake()
    {

        canvas = transform.root.GetComponent<Canvas>();

    }
    public void SetData(Sprite sprite, int quantity)
    {

        item.SetData(sprite, quantity);

    }
    private void Update()
    {

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, Input.mousePosition, canvas.worldCamera, out position);
        transform.position = canvas.transform.TransformPoint(position);

    }

    public void Toogle(bool val)
    {

        print($"Item toogled {val}");
        gameObject.SetActive(val);

    }

}
