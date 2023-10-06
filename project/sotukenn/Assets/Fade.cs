using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Text text;

    void Update()
    {
        Color color = text.material.GetColor("_Color");
        color.a = color.a <= 0 ? 1 : color.a +0.01f;
        text.material.SetColor("_Color", color);
    }
}
