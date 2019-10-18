using System;
using System.Collections.Generic;
using System.Text;

//IMPORTANT: Ao criar uma classe de extensão, sempre criar a mesma dentro do namespace System para que ela possa ser usada no tipo em que foi definida.
namespace System
{
    public static class DateTimeExtensions
    {
        public static string ShowParsedDateTime(this DateTime obj)
        {
            return obj.ToString();
        }
    }
}
