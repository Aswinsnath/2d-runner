/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartManager : MonoBehaviour
{
    public static int Health = 3;
    public Image[] hearts;


    public Sprite fullHeart;
    public Sprite emtyHeart;

    
    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emtyHeart;
        }
        for (int i =0; i < Health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }
}
*/