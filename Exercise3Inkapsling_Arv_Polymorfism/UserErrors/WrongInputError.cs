namespace Exercise3Inkapsling_Arv_Polymorfism.UserErrors
{
    public class WrongInputError : UserError
    {
        public override string UEMessage()
        {
            return "Wrong input!";
        }
    }
}
