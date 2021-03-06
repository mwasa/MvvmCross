﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using Foundation;
using MvvmCross.Platform.Ios;

namespace MvvmCross.Plugin.PhoneCall.Platform.iOS
{
    [Preserve(AllMembers = true)]
	public class MvxPhoneCallTask : MvxIosTask, IMvxPhoneCallTask
    {
        public void MakePhoneCall(string name, string number)
        {            
            var url = new NSUrl("tel:" + Uri.EscapeUriString(number));
            DoUrlOpen(url);
        }
    }
}
