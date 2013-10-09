using NUnit.Framework;
using System;
using BeanCounter;

namespace BeanCounterTests
{
    [TestFixture]
    public class CsvReaderTest
    {
        [Test]
        public void TestNoErrors()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "line2,fielda,fieldb,fieldc\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("fielda", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyField()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "line2,,fieldb,fieldc\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestTwoEmptyFields()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "line2,,,fieldc\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("", lines[1][1]);
            Assert.AreEqual("", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyFirstField()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                ",fielda,fieldb,fieldc\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("", lines[1][0]);
            Assert.AreEqual("fielda", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyLastField()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "line2,fielda,fieldb,\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("fielda", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyRecord()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(1, lines[1].Count);
            Assert.AreEqual("", lines[1][0]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyFirstRecord()
        {
            // setup
            string input =
                "\n" +
                "line2,fielda,fieldb,fieldc\n" +
                "line3,fielda,fieldb";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(1, lines[0].Count);
            Assert.AreEqual("", lines[0][0]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("fielda", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(3, lines[2].Count);
            Assert.AreEqual("line3", lines[2][0]);
            Assert.AreEqual("fielda", lines[2][1]);
            Assert.AreEqual("fieldb", lines[2][2]);
        }

        [Test]
        public void TestEmptyLastRecord()
        {
            // setup
            string input =
                "line1,fielda,fieldb\n" +
                "line2,fielda,fieldb,fieldc\n" +
                "";
            var reader = new CsvReader();

            // action
            var lines = reader.ReadCsvFile(input);

            // assertions
            Assert.IsNotNull(lines);
            Assert.AreEqual(3, lines.Count);

            Assert.IsNotNull(lines[0]);
            Assert.AreEqual(3, lines[0].Count);
            Assert.AreEqual("line1", lines[0][0]);
            Assert.AreEqual("fielda", lines[0][1]);
            Assert.AreEqual("fieldb", lines[0][2]);

            Assert.IsNotNull(lines[1]);
            Assert.AreEqual(4, lines[1].Count);
            Assert.AreEqual("line2", lines[1][0]);
            Assert.AreEqual("fielda", lines[1][1]);
            Assert.AreEqual("fieldb", lines[1][2]);
            Assert.AreEqual("fieldc", lines[1][3]);

            Assert.IsNotNull(lines[2]);
            Assert.AreEqual(1, lines[2].Count);
            Assert.AreEqual("", lines[2][0]);
        }
    }
}

