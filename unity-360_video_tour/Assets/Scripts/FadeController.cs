using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInOutController : MonoBehaviour
{
    public Image[] images;

    public void StartFadeInOut()
    {
        StartCoroutine(FadeInAndOut(1f, 1f));
    }

    IEnumerator FadeInAndOut(float fadeInDuration, float fadeOutDuration)
    {
        // Fade In
        yield return StartCoroutine(FadeIn(fadeInDuration));
        yield return new WaitForSeconds(1f);
        // Fade Out
        yield return StartCoroutine(FadeOut(fadeOutDuration));
    }

    IEnumerator FadeIn(float duration)
    {
        float elapsedTime = 0f;

        Color[] startColors = new Color[images.Length];
        Color endColor = new Color(1f, 1f, 1f, 1f);

        for (int i = 0; i < images.Length; i++)
        {
            startColors[i] = images[i].color;
        }

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;

            for (int i = 0; i < images.Length; i++)
            {
                images[i].color = Color.Lerp(startColors[i], endColor, t);
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        for (int i = 0; i < images.Length; i++)
        {
            images[i].color = endColor;
        }
    }

    IEnumerator FadeOut(float duration)
    {
        float elapsedTime = 0f;

        Color[] startColors = new Color[images.Length];
        Color endColor = new Color(1f, 1f, 1f, 0f);

        for (int i = 0; i < images.Length; i++)
        {
            startColors[i] = images[i].color;
        }

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;

            for (int i = 0; i < images.Length; i++)
            {
                images[i].color = Color.Lerp(startColors[i], endColor, t);
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        for (int i = 0; i < images.Length; i++)
        {
            images[i].color = endColor;
        }
    }
}