namespace Nowe_zadanie
{
    class Task
    {
        public bool Check;
        // dopisałam { get; set; } bo pojawial sie ten komunikat Task.cs(7,17): warning CS0649: Do pola "Task.CheckAll" nigdy nie jest przypisywana wartość i będzie ono mieć zawsze wartość domyślną false [C:\Users\hermiodek\Documents\projekty\do zrobenia\do zrobenia.csproj]//

        public string Description;

        public string ShowCheck()
        {
            string checkRepresentation;

            if (Check)
            {
                checkRepresentation = "V";
            }
            else
            {
                checkRepresentation = " ";
            }
            return checkRepresentation;
        }
    }
}