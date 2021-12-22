﻿using Okta.Idx.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embedded_auth_with_sdk.Models
{
    public class OktaVerifySelectEnrollmentChannelModel
    {
        public OktaVerifySelectEnrollmentChannelModel()
        { 
        }

        public OktaVerifySelectEnrollmentChannelModel(OktaVerifyEnrollOptions enrollPollOptions)
        {
            this.EnrollPollOptions = enrollPollOptions;
        }

        protected OktaVerifyEnrollOptions EnrollPollOptions { get; set; }

        [Required]
        [Display(Name = "enrollment channel")]
        public string SelectedChannel
        {
            get; 
            set;
        }

        public IList<OktaVerifySelectEnrollmentChannelParameterModel> RemediationOptionParameters 
        {
            get => EnrollPollOptions?
                .GetChannelOptions()
                .Where(rop => rop.Value != OktaVerifyEnrollmentChannel.QrCode)
                .Select(remediationOptionParameter => new OktaVerifySelectEnrollmentChannelParameterModel(remediationOptionParameter))
                .ToList();
        } 
    }
}