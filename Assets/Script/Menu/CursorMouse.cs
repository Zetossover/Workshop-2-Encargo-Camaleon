using UnityEngine;

public class CursorMouse : MonoBehaviour
{
    [SerializeField] Texture2D cursorSprite;
    [SerializeField] Vector2 cursorPosition;

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorSprite,cursorPosition,CursorMode.Auto);
    }
    private void OnMouseExit()
    {
        Cursor.SetCursor(null,cursorPosition,CursorMode.Auto);
    }

}
