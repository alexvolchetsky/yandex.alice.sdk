﻿namespace Yandex.Alice.Sdk.Models
{
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using Yandex.Alice.Sdk.Helpers;
    using Yandex.Alice.Sdk.Resources;

    public abstract class AliceModel
    {
        protected static void ValidateMaxLength(string value, int maxLength, [CallerMemberName] string propertyName = null)
        {
            if (value?.Length > maxLength)
            {
                string errorText = string.Format(CultureInfo.CurrentCulture, Yandex_Alice_Sdk_Resources.Error_TooLongString, maxLength, nameof(AliceHelper));
                throw new ArgumentException(errorText, propertyName);
            }
        }

        protected static void ValidateNotNull(string value, [CallerMemberName] string propertyName = null)
        {
            if (value == null)
            {
                throw new ArgumentException(Yandex_Alice_Sdk_Resources.Error_Required, propertyName);
            }
        }
    }
}
