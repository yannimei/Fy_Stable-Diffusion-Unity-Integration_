using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageGenerationManager : MonoBehaviour
{
    public StableDiffusionText2Material painting1;
    public Text posPrompt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageGenerate()
    {
        painting1.prompt = posPrompt.text;
        painting1.Generate();
    }
}
