using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public Transform MainCam;
    public Transform middleBG;
    public Transform SideBG;
    public float length = 38.2f;
    public int preloadCount = 1; // number of copies to preload
    private List<Transform> bgList = new List<Transform>();

    void Start()
    {
        bgList.Add(middleBG);
        bgList.Add(SideBG);
        // preload additional copies of the background
        for (int i = 0; i < preloadCount; i++)
        {
            Transform newBG = Instantiate(middleBG, transform);
            newBG.position = middleBG.position + Vector3.right * length * (i + 1);
            bgList.Add(newBG);

            newBG = Instantiate(SideBG, transform);
            newBG.position = SideBG.position + Vector3.right * length * (i + 1);
            bgList.Add(newBG);

            newBG = Instantiate(SideBG, transform);
            newBG.position = SideBG.position + Vector3.left * length * (i + 1);
            bgList.Add(newBG);
        }
    }

    void Update()
    {
        if (MainCam.position.x > middleBG.position.x)
            SideBG.position = middleBG.position + Vector3.right * length;
        if (MainCam.position.x < middleBG.position.x)
            SideBG.position = middleBG.position + Vector3.left * length;
        if (MainCam.position.x > SideBG.position.x + length / 2 || MainCam.position.x < SideBG.position.x - length / 2)
        {
            Transform temp = middleBG;
            middleBG = SideBG;
            SideBG = temp;
            SideBG.position = middleBG.position + (SideBG.position.x < middleBG.position.x ? Vector3.right : Vector3.left) * length;
        }

        
        float preloadDistance = preloadCount * length;
        if (MainCam.position.x + preloadDistance > bgList[bgList.Count - 1].position.x)
        {
            
            for (int i = 0; i < preloadCount; i++)
            {
                Transform newBG = Instantiate(middleBG, transform);
                newBG.position = bgList[bgList.Count - 1].position + Vector3.right * length * (i + 1);
                bgList.Add(newBG);

                newBG = Instantiate(SideBG, transform);
                newBG.position = bgList[bgList.Count - 1].position + Vector3.right * length * (i + 1);
                bgList.Add(newBG);

                newBG = Instantiate(SideBG, transform);
                newBG.position = bgList[bgList.Count - 1].position + Vector3.left * length * (i + 1);
                bgList.Add(newBG);
            }
        }
    }
}
