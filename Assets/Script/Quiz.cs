using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class Quiz : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject quizUI;
    public TMP_Text questionText;
    public Button[] answerButtons;

    private int currentQuestionIndex = 0;
    private Question[] questions;
    private int score = 0;
    private float videoPlayTime = 0f;
    private bool isQuestionActive = false;
    private bool allQuestionsAnswered = false; // Flag to track if all questions have been answered.

    [System.Serializable]
    public class Question
    {
        public string questionText;
        public string[] options;
        public int correctOptionIndex;
    }

    void Start()
    {
        questions = new Question[]
        {
            new Question
            {
                questionText = "When did the annular eclipse take place in 2021?",
                options = new string[] { "June10,2021", "June15,2021", "June 20, 2021","July 10, 2021" },
                correctOptionIndex = 0
            },
            new Question
            {
                questionText = "which shadow cast by the sun is the smallest and darkest?",
                options = new string[] { "Penumbra", "Gumbra", "Gumbra","Dendumbra" },
                correctOptionIndex = 2
            },
            new Question
            {
                questionText = "Which of the following areas could see the Annular eclipse that took place in 2021? i) Asia ii) Europe iii) Australia ",
                options = new string[] { "i & iii", "i&ii", "i,ii&iii", "None of the above" },
                correctOptionIndex = 1
            },
            // Add more questions as needed.
        };

        // Initialize the quiz UI.
        quizUI.SetActive(false);

        // Start playing the video.
        videoPlayer.Play();
    }

    void Update()
    {
        // Check video playback time.
        videoPlayTime = (float)videoPlayer.time;

        // Check if all questions have been answered.
        if (currentQuestionIndex >= questions.Length && !allQuestionsAnswered)
        {
            Debug.Log("Quiz Complete. Score: " + score);
            allQuestionsAnswered = true;
            ResumeVideo(); // Resume the video when all questions are answered.
        }

        // Check if it's time to show a question.
        if (!allQuestionsAnswered)
        {
            if (videoPlayTime >= 10f && currentQuestionIndex == 0 && !isQuestionActive)
            {
                ShowQuestion();
                PauseVideo(); // Pause the video when showing the question.
            }
            else if (videoPlayTime >= 20f && currentQuestionIndex == 1 && !isQuestionActive)
            {
                ShowQuestion();
                PauseVideo(); // Pause the video when showing the question.
            }
            else if (videoPlayTime >= 25f && currentQuestionIndex == 2 && !isQuestionActive)
            {
                ShowQuestion();
                PauseVideo(); // Pause the video when showing the question.
            }
        }
    }


    void ShowQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            questionText.text = currentQuestion.questionText;

            for (int i = 0; i < answerButtons.Length; i++)
            {
                answerButtons[i].GetComponentInChildren<TMP_Text>().text = currentQuestion.options[i];
                int answerIndex = i; // Capture the answer index in a local variable.
                answerButtons[i].onClick.RemoveAllListeners(); // Clear previous listeners.
                answerButtons[i].onClick.AddListener(() => OnAnswerSelected(answerIndex));
            }

            quizUI.SetActive(true);
            isQuestionActive = true;
        }
    }

    void OnAnswerSelected(int selectedOptionIndex)
    {
        if (currentQuestionIndex < questions.Length)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            if (selectedOptionIndex == currentQuestion.correctOptionIndex)
            {
                // Correct answer.
                score++;
            }

            // Move to the next question.
            currentQuestionIndex++;
            quizUI.SetActive(false);
            isQuestionActive = false;
            ResumeVideo();
        }
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }

    public void ResumeVideo()
    {
        videoPlayer.Play();
    }
}
