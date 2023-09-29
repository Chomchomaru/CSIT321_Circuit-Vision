using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    public static UI Instance;

    private int currentPage = 0;
    public GameObject BG;
    public GameObject [] pages;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        /*Screen.orientation = ScreenOrientation.Portrait;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePage(int pageNum)
    {
        pages[currentPage].SetActive(false);
        pages[pageNum].SetActive(true);
        currentPage = pageNum;
        if (currentPage == 4) BG.SetActive(false);
    }

    /*public void ToProject()
    {
        BG.SetActive(false);
        ChangePage(3);
    }*/
}

