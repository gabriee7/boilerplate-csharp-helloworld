using MyTest.Debugging;

namespace MyTest
{
    public class MyTestConsts
    {
        public const string LocalizationSourceName = "MyTest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b8ca6db42d11477b855ed2f90b0cdf93";
    }
}
