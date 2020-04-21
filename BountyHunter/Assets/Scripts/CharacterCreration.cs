using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

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

    float speed = 50.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetMouseButton(0))
            transform.Rotate(new Vector3(transform.position.z * 3, Input.GetAxis("Mouse X") * 3, Input.GetAxis("Mouse Y") * 3));
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
