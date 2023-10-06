using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class swapvideo : MonoBehaviour
{

       private  Quiz mark;
     //   public VideoClip videoClip1; // Assign your first video clip in the Inspector.
       // public VideoClip videoClip2; // Assign your second video clip in the Inspector.
       // private VideoPlayer videoPlayer;
       // private float startTime;

        void Start()
        {
           // videoPlayer = GetComponent<VideoPlayer>();
           // videoPlayer.clip = videoClip1;
           // videoPlayer.Play();
           // startTime = Time.time;
          mark = GetComponent<Quiz>();
        }

        void Update()
        {
         // Check if it's time to swap the video (e.g., after 1 minute).
         //if (Time.time - startTime >= 10.0f && mark.score == 2)
         // {
         //     SwapVideo();
         // }
          Debug.Log("mark:" +mark);
        }

        //void SwapVideo()
        //{
            // Swap to the second video clip.
          //  videoPlayer.Stop();
         //   videoPlayer.clip = videoClip2;
         //   videoPlayer.Play();
         //   startTime = Time.time;
        //}

}


