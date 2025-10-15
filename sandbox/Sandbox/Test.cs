class Test
{
    private List<string> _questions;
    public string GetRandomQuestion()
    {
        _questions.Add("What was the most difficult part about it?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("How it made you feel?");
        _questions.Add("If you could go back and change something, what would it be?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("What did you learned about this experience?");
        _questions.Add("If you could say something to yourself at that moment, what would it be?");
        _questions.Add("Do you think it made you a different person?");
        _questions.Add("How did it affect you?");

        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);

        return $"{_questions[index]}!";
    }
}