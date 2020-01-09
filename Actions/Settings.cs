namespace ScraperApp
{ 
    public class Settings
    {
        public class Yahoo
        {
            public class UserCredentials
            {
                string _userName = "";
                string _userPass = "";

                public string UserName { get { return _userName; } set { _userName = value; } }
                public string UserPass { get { return _userPass; } set { _userPass = value; } }
                public UserCredentials(string username, string userpass)
                {
                    _userName = username;
                    _userPass = userpass;
                }
            }

            public static string loginPage = "https://login.yahoo.com/config/login?.src=fpctx&.intl=us&.lang=en-US&.done=https://www.yahoo.com";
            public static string passwordPage = "https://login.yahoo.com/account/challenge/password?.src=fpctx&.intl=us&.lang=en-US&authMechanism=primary&display=login&done=https%3A%2F%2Fwww.yahoo.com%2F&sessionIndex=Qg--&acrumb=vfV0rBrz";
            public static string portfolioPage = " https://finance.yahoo.com/portfolio/p_0/view";
            public static string loginNameField = "login-username";
            public static string loginPassField = "login-passwd";
        }
    }
}