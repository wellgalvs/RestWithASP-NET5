﻿namespace RestWithASPNET.Configurations
{
    public class TokenConfiguration
    {
        public string Audience { get; set; }

        public string Issuer { get; set; }

        public string Secret { get; set; }

        public int minutes { get; set; }

        public int DaysToExpiry { get; set; }
    }
}
