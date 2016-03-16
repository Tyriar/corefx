// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Xunit;

namespace System.Globalization.Tests
{
    public class KoreanCalendarGetDayOfWeek
    {
        private static readonly RandomDataGenerator s_randomDatagenerator = new RandomDataGenerator();

        public static IEnumerable<object[]> GetDayOfWeek_TestData()
        {
            yield return new object[] { DateTime.MinValue };
            yield return new object[] { DateTime.MaxValue };
            yield return new object[] { new DateTime(2000, 2, 29) };
            yield return new object[] { new DateTime(s_randomDatagenerator.GetInt64(-55) % (DateTime.MaxValue.Ticks + 1)) };
        }

        [Theory]
        [MemberData(nameof(GetDayOfWeek_TestData))]
        public void GetDayOfWeek(DateTime time)
        {
            Assert.Equal(new GregorianCalendar().GetDayOfWeek(time), new KoreanCalendar().GetDayOfWeek(time));
        }
    }
}
