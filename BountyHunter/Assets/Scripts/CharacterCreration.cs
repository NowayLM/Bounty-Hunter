using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCreration : MonoBehaviour
{
    private List<GameObject> models;
    // Default index 
    private int selectionIndex = 0;

    private void Start()
    {
        selectionIndex = PlayerPrefs.GetInt("CharacterSelected");
        models = new List<GameObject>();

        foreach(Transform t in transform)
        {
            models.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }

        models[selectionIndex].SetActive(true);
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
            transform.Rotate(new Vector3(0.0f, Input.GetAxis("Mouse X"), 0.0f));
    }

    public void Select(int index)
    {
        // Checks if there is an index problem
        if (index == selectionIndex)
            return;
        if (index < 0 || index >= models.Count)
            return;

        models[selectionIndex].SetActive(false);
        selectionIndex = index;
        models[selectionIndex].SetActive(true);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", selectionIndex);
        SceneManager.LoadScene(2);
    }
}
