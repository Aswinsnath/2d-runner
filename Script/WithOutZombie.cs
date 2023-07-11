using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithOutZombie : MonoBehaviour
{
    public GameObject[] playerCharacters;
    public GameObject[] zombies;

    private int selectedCharacter = 0;

    private void Start()
    {
        SelectCharacter(selectedCharacter);
    }

    public void SelectNextCharacter()
    {
        selectedCharacter++;
        if (selectedCharacter >= playerCharacters.Length)
        {
            selectedCharacter = 0;
        }
        SelectCharacter(selectedCharacter);
    }

    public void SelectPreviousCharacter()
    {
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = playerCharacters.Length - 1;
        }
        SelectCharacter(selectedCharacter);
    }

    private void SelectCharacter(int characterIndex)
    {
        for (int i = 0; i < playerCharacters.Length; i++)
        {
            if (i == characterIndex)
            {
                playerCharacters[i].SetActive(true);
            }
            else
            {
                playerCharacters[i].SetActive(false);
            }
        }

        if (characterIndex == 0 || characterIndex == 1)
        {
            // Deactivate all zombies when the first or second character is selected
            foreach (GameObject zombie in zombies)
            {
                zombie.SetActive(false);
            }
        }
        else
        {
            // Activate all zombies when any other character is selected
            foreach (GameObject zombie in zombies)
            {
                zombie.SetActive(true);
            }
        }
    }
}
