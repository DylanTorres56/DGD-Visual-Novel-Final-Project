using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        titleScreen.canvasRenderer.SetAlpha(0f);

        fadeIn();
    }

    // Update is called once per frame
    void fadeIn()
    {
        titleScreen.CrossFadeAlpha(1, 3f, false);
    }
}
