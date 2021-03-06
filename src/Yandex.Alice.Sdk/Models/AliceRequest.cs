﻿namespace Yandex.Alice.Sdk.Models
{
    using System.Text.Json.Serialization;

    public class AliceRequest
        : AliceRequest<object, object, object>
    {
    }

    public class AliceRequest<TIntents, TSession, TUser>
        : AliceRequestBase<TSession, TUser>
    {
        [JsonPropertyName("request")]
        public AliceRequestModel<TIntents> Request { get; set; }
    }

    public class AliceRequestBase<TSession, TUser>
    {
        [JsonPropertyName("state")]
        public AliceStateModel<TSession, TUser> State { get; set; }

        [JsonPropertyName("meta")]
        public AliceMetaModel Meta { get; set; }

        [JsonPropertyName("session")]
        public AliceSessionModel Session { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
