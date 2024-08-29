using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInOutController : MonoBehaviour
{
    public GameObject imagesContainer;
    public Image[] images;

    public void StartFadeInOut()
    {
        StartCoroutine(FadeInAndOut(1f, 1f));
    }

    IEnumerator FadeInAndOut(float fadeInDuration, float fadeOutDuration)
    {
        imagesContainer.SetActive(true);
        yield return StartCoroutine(FadeIn(fadeInDuration));
        yield return new WaitForSeconds(1f);
        // Fade Out
        yield return StartCoroutine(FadeOut(fadeOutDuration));
        yield return new WaitForSeconds(2f);
        imagesContainer.SetActive(false);
    }

    IEnumerator FadeIn(float duration)
    {
        float elapsedTime = 0f;

        Color[] startColors = new Color[images.Length];
        Color endColor = new Color(0f, 0f, 0f, 1f);

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
        Color endColor = new Color(0f, 0f, 0f, 0f);

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