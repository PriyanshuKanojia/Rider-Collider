using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Transform Rider;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Rider.position.z.ToString("0");
    }
}
