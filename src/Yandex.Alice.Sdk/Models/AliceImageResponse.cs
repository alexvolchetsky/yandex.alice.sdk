﻿namespace Yandex.Alice.Sdk.Models
{
    using System.Collections.Generic;

    public class AliceImageResponse : AliceImageResponse<object, object>
    {
        public AliceImageResponse(AliceRequestBase<object, object> request, string text, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, text, keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<object, object> request, string text, string tts, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, tts, new List<AliceButtonModel>(), keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<object, object> request, string text, List<AliceButtonModel> buttons, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, text, buttons, keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<object, object> request, string text, string tts, List<AliceButtonModel> buttons, bool keepSessionState = true, bool keepUserState = true)
            : base(request, text, tts, buttons, keepSessionState, keepUserState)
        {
        }
    }

    public class AliceImageResponse<TSession, TUSer>
        : AliceResponseBase<AliceImageResponseModel, TSession, TUSer>
    {
        public AliceImageResponse(AliceRequestBase<TSession, TUSer> request, string text, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, text, keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<TSession, TUSer> request, string text, string tts, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, tts, new List<AliceButtonModel>(), keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<TSession, TUSer> request, string text, List<AliceButtonModel> buttons, bool keepSessionState = true, bool keepUserState = true)
            : this(request, text, text, buttons, keepSessionState, keepUserState)
        {
        }

        public AliceImageResponse(AliceRequestBase<TSession, TUSer> request, string text, string tts, List<AliceButtonModel> buttons, bool keepSessionState = true, bool keepUserState = true)
            : base(request, text, tts, buttons, keepSessionState, keepUserState)
        {
        }
    }
}
