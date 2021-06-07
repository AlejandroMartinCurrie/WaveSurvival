using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionController : MonoBehaviour
{
    public Image _fadeImage;
    public float fadeTime = 2f;




    public void FadeToBlack()
    {
        StartCoroutine(CrFadeToBlack());
    }


    public IEnumerator CrFadeToBlack()
    {
        Color transparentBlackColor = new Color(0, 0, 0, 0);
        Color BlackColor = new Color(0, 0, 0, 1);
        _fadeImage.enabled = true;

        for (float i = 0; i < fadeTime; i += Time.deltaTime)
        {
            _fadeImage.color = Color.Lerp(transparentBlackColor, BlackColor, i / fadeTime);
            yield return 0;
        }

        _fadeImage.color = BlackColor;
    }




    public void FadeFromBlack()
    {
        StartCoroutine(CrFadeFromBlack());
    }

    public IEnumerator CrFadeFromBlack()
    {
        Color transparentBlackColor = new Color(0, 0, 0, 0);
        Color BlackColor = new Color(0, 0, 0, 1);
        _fadeImage.enabled = true;

        for (float i = 0; i < fadeTime; i += Time.deltaTime)
        {
            _fadeImage.color = Color.Lerp(BlackColor, transparentBlackColor, i / fadeTime);
            yield return 0;
        }
        _fadeImage.color = transparentBlackColor;
    }




    void Start()
    {
        FadeFromBlack();
    }


    void Update()
    {

    }
}
