using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public GameObject canvas;
    public GameObject splashScreen;

    private void Awake(){
        GameObject screen = Instantiate<GameObject>(splashScreen);
        screen.transform.SetParent(canvas.transform, false);
        StartCoroutine(ShowSplash(screen));
    }
    private IEnumerator ShowSplash(GameObject screen){
        yield return new WaitForSeconds(3f);
        screen.SetActive(false);
        //Destory(screen);
    }
}
