namespace mathGame.djslade.lib.match
{
    public class SubMatch(string difficulty) : Match(difficulty, "-")
    {
        protected override void SetAnswer()
        {
            correctAnswer = firstOperand - secondOperand;
        }
    }
}