using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvas;

        void Start()
        {
            canvas = GetComponent<CanvasGroup>();
        }

        public void FadeOutImmediate()
        {
            canvas.alpha = 1;
        }

        IEnumerator FadeInOut()
        {
            yield return FadeOut(3f);
            print("Faded out");
            yield return FadeIn(2f);
        }

        public IEnumerator FadeOut(float timeF)
        {
            while (canvas.alpha < 1)
            {
                canvas.alpha += Time.deltaTime / timeF;
                yield return null;
            }
        }
        public IEnumerator FadeIn(float timeF)
        {
            while (canvas.alpha > 0)
            {
                canvas.alpha -= Time.deltaTime / timeF;
                yield return null;
            }
        }
    }
}