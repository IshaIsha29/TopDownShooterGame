using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICursorFollowMouse : MonoBehaviour
{
    public RectTransform customCursor;

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        customCursor.position = mousePosition;
    }
}
