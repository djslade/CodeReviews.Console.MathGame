namespace mathGame.djslade.lib.match
{
    public class MultMatch(string difficulty) : Match(difficulty, "*")
    {
        protected override void SetAnswer()
        {
            correctAnswer = firstOperand * secondOperand;
        }
    }
}