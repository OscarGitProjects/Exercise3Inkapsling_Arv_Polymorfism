namespace Exercise3Inkapsling_Arv_Polymorfism.UserErrors
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field.This fired an error!";
        }
    }
}
