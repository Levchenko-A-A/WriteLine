namespace WriteLine
{
    internal class Program
    {
        string lineInput;
        while ((lineInput = Console.ReadLine()) != null)
        {
            string[] fields = lineInput.Split(new char[] { '\t' });
        bool isFirstField = true;
            foreach (var item in fields)
            {
                if (isFirstField)
                    isFirstField = false;
                else
                    Console.Write(',');

                // If the field represents a boolean, replace with a numeric representation.
                bool itemBool;
                if (Boolean.TryParse(item, out itemBool))
                    Console.Write(Convert.ToByte(itemBool));
                else
                    Console.Write(item);
            }
    Console.WriteLine();
}
