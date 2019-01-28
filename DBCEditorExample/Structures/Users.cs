namespace DBCEditorExample.Structures
{
    public class Users
    {
        public uint Id;             // 0
        public string FirstName;    // 1 
        public string LastName;     // 2
        public uint BirthYear;      // 3
        public string Email;        // 4

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
