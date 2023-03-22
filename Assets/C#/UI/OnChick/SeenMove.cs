using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SeenMove : MonoBehaviour
{
    public Image image;
    public string name;
    private void Start()
    {
        
    }
    public void BtnStart()
    {
        image.gameObject.SetActive(true);
        Debug.Log("!?");
        image.DOFade(1, 1).OnComplete(() =>
        {
            SceneManager.LoadScene(name);
        });
    }
}
