using System.IO;
using System.Reflection;
using DBCEditorExample.Structures;
using DBCLib;

namespace DBCEditorExample.DataStores
{
    public static partial class DBCStores
    {
        public static DBCFile<Users> Users { get; private set; }

        private static readonly string Signature = "WDBC";

        public static void InitFiles()
        {
            string dbcFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\DBCFiles\\";

            Users = new DBCFile<Users>(dbcFolder + "Users.dbc", Signature);
        }
    }
}
