﻿using System.Collections.Generic;
using Microsoft.Recognizers.Text.DataDrivenTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Recognizers.Text.DateTime.Tests
{
    [TestClass]
    public class TestDateTime_Turkish : TestBase
    {
        public static IDictionary<string, IDateTimeExtractor> Extractors { get; private set; }

        public static IDictionary<string, IDateTimeParser> Parsers { get; private set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Extractors = new Dictionary<string, IDateTimeExtractor>();
            Parsers = new Dictionary<string, IDateTimeParser>();
        }

        [NetCoreTestDataSource]
        [TestMethod]
        public void DateExtractor(TestModel testSpec)
        {
            ExtractorInitialize(Extractors);
            TestDateTimeExtractor(testSpec);
        }

        [NetCoreTestDataSource]
        [TestMethod]
        public void DateParser(TestModel testSpec)
        {
            ExtractorInitialize(Extractors);
            ParserInitialize(Parsers);
            TestDateTimeParser(testSpec);
        }

        [NetCoreTestDataSource]
        [TestMethod]
        public void HolidayExtractor(TestModel testSpec)
        {
            ExtractorInitialize(Extractors);
            TestDateTimeExtractor(testSpec);
        }

        [NetCoreTestDataSource]
        [TestMethod]
        public void HolidayParser(TestModel testSpec)
        {
            ExtractorInitialize(Extractors);
            ParserInitialize(Parsers);
            TestDateTimeParser(testSpec);
        }
    }
}
