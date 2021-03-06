using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawerPuzzle : MonoBehaviour
{

    public int [] drawerCode = {3, 5, 5, 4, 3, 4, 5, 3};
    public int [] attemptCode = new int [8];
    private int currentIndex = 0;
    private int addedValue;
    private bool completed = false;
    public GameObject chave;

    public bool checkValues ()
    {
        for (int i = 0; i<drawerCode.Length; i++)
        {
            if (drawerCode[i] != attemptCode[i])
            {
                return false;
            }
            
        }
        completed = true;
        Win();
        return true;
    }

    private void EnterValue()
    {
        if (currentIndex == 8)
        {
            for (int i = 0; i<attemptCode.Length - 1; i++)
            {
                attemptCode[i] = attemptCode[i+1];
            }
            attemptCode[7] = addedValue;
        }
        else
        {
            attemptCode[currentIndex] = addedValue;
            currentIndex = currentIndex + 1;
        }

    }

    private void Win()
    {
        chave.SetActive(true);
    }
    
    void Update()
    {
        if (completed == false)
        {
            checkValues();
        }    
    }

    public void TriButton()
    {
        addedValue = 3;
        EnterValue();
    }

    public void SqaButton()
    {
        addedValue = 4;
        EnterValue();
    }

    public void PentButton()
    {
        addedValue = 5;
        EnterValue();    
    }
}