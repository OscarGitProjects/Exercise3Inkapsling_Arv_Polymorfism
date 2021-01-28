namespace Exercise3Inkapsling_Arv_Polymorfism.UserErrors
{
    public class AnotherWrongInputError : UserError
    {
        public override string UEMessage()
        {
            return "Another Wrong input!";
        }
    }
}
