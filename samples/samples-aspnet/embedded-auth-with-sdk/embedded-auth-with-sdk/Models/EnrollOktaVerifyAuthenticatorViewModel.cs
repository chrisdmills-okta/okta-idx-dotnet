﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace embedded_auth_with_sdk.Models
{
    public class EnrollOktaVerifyAuthenticatorViewModel
    {
        public EnrollOktaVerifyAuthenticatorViewModel(string pollEndpoint = "/Manage/Poll")
        {
            this.PollEndpoint = pollEndpoint;
        }

        public string QrCodeHref { get; set; }

        public string SelectedChannel { get; set; }

        public string PollEndpoint { get; set; }

        public int? RefreshInterval { get; set; }

        public string Message { get; set; }
    }
}