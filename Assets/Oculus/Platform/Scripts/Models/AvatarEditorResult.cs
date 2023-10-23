// This file was @generated with LibOVRPlatform/codegen/main. Do not modify it!

namespace Oculus.Platform.Models
{
    using System;

    public class AvatarEditorResult
    {
        /// Whether the request has sent.
        public readonly bool RequestSent;


        public AvatarEditorResult(IntPtr o)
        {
            RequestSent = CAPI.ovr_AvatarEditorResult_GetRequestSent(o);
        }
    }

}
