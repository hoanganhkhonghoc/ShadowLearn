using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class GameManagerLinght : MonoBehaviour
{
    public GameObject monster;

    public Light2D globalLight2D;

    public Light2D lightGame;

    public float minIntensity = 0f;
    public float maxIntensity = 1f;
    private float transitionDuration = 30f;

    private bool increasingIntensity = true;

    private float time = 0;
    private bool timeStart = false;
    public bool dark = false;

    public ManagerPlayer managerPlayer;
    public bool MS = false;
    public StatusPlayer statusPlayer;
    void Start()
    {
        StartCoroutine(ChangeIntensityRoutine());
        dem = 0;
    }

    IEnumerator ChangeIntensityRoutine()
    {
        while (true)
        {
            float startIntensity = globalLight2D.intensity;
            float endIntensity = increasingIntensity ? maxIntensity : minIntensity;
            float startTime = Time.time;
            float elapsedTime = 0f;

            while (elapsedTime < transitionDuration)
            {
                elapsedTime = Time.time - startTime;
                float t = Mathf.Clamp01(elapsedTime / transitionDuration);
                globalLight2D.intensity = Mathf.Lerp(startIntensity, endIntensity, t);
                yield return null;
            }

            if(globalLight2D.intensity == 0)
            {
                timeStart = true;
                dark = true;
            }
            else
            {
                dark = false;
            }

            globalLight2D.intensity = endIntensity;
            increasingIntensity = !increasingIntensity;

            yield return new WaitForSeconds(transitionDuration);
        }
    }
    int dem;
    private void Update()
    {
        if(dark == true && timeStart)
        {
            time += Time.deltaTime;
        }
        if (time >= 10 && managerPlayer.save == false && time <= 20)
        {
            
            if(dem == 0)
            {
                statusPlayer.mana = statusPlayer.mana / 2;
                dem++;
            }
            MS = true;
            monster.SetActive(true);
        }

        if (time >= 20 || managerPlayer.save == true)
        {
            
            MS = false;
            monster.SetActive(false);
        }
        if (time > 20 && !dark)
        {
            dem = 0;
            time = 0;
            timeStart = false;
        }
        if (dark)
        {
            lightGame.intensity = 0.02f;
        }
        else
        {
            lightGame.intensity = 0.05f;
        }
    }
}
