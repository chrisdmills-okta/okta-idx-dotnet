﻿// <copyright file="IRemediationOptionItem.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using Okta.Sdk.Abstractions;

namespace Okta.Idx.Sdk
{
    public interface IRemediationOptionItem : IResource
    {
        /// <summary>
        /// Gets the name of the form item that can be used in a UI. This relates to the name that is used for the body of the request for the RemediationOption.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the type of value that is expected
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Returns an object that is populated from the json path.
        /// Example: `$.authenticatorEnrollments.value[0]` would relate to the jsonPath `OktaIdentityEngine->raw()->authenticatorEnrollments->value[0]`
        /// </summary>
        string RelatesTo { get; }

        /// <summary>
        /// Form
        /// </summary>
        IForm Form { get; }
    }
}
