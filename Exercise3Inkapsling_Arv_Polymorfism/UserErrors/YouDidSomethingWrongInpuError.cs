namespace Exercise3Inkapsling_Arv_Polymorfism.UserErrors
{
    public class YouDidSomethingWrongInpuError : UserError
    {
        public override string UEMessage()
        {
            return "You did something wrong input!";
        }
    }
}
