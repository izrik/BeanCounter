using System;
using MetaphysicsIndustries.Giza;
using System.Collections.Generic;

namespace BeanCounter
{
    public class CsvReader
    {
        public CsvReader()
        {
            _fileSpanner = new Spanner(_grammar.def_file);
            _lineSpanner = new Spanner(_grammar.def_record);
        }

        CsvGrammar _grammar = new CsvGrammar();
        Spanner _fileSpanner;
        Spanner _lineSpanner;

        public List<List<string>> ReadCsvFile(string input)
        {
            var errors = new List<Error>();
            var spans = _fileSpanner.Process(input, errors);
            if (errors.ContainsNonWarnings())
            {
                throw new InvalidOperationException("There were errors");
            }
            if (spans.Length > 1)
            {
                throw new InvalidOperationException(string.Format("Ambiguous grammar ({0} spans)", spans.Length));
            }
            if (spans.Length < 1)
            {
                throw new NotImplementedException("No valid spans");
            }

            var lines = new List<List<string>>();
            foreach (var linespan in spans[0].Subspans)
            {
                if (linespan.DefRef != _grammar.def_record) continue;

                var line = new List<string>();
                bool lastComma = false;
                foreach (var sub in linespan.Subspans)
                {
                    if (sub.DefRef == _grammar.def_field)
                    {
                        string value = sub.CollectValue();
                        if (value.StartsWith("\""))
                        {
                            value = value.Trim('"');
                            value.Replace("\"\"", "\"");
                        }

                        line.Add(value);

                        lastComma = false;
                    }
                    else 
                    {
                        if (lastComma)
                        {
                            line.Add(string.Empty);
                        }
                        else
                        {
                            lastComma = true;
                        }
                    }
                }

                lines.Add(line);
            }

            return lines;
        }

        public List<string> ReadCsvLine(string input)
        {
            throw new NotImplementedException();
        }
    }
}

