using System;
using MetaphysicsIndustries.Giza;
using System.Collections.Generic;
using System.Text;

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
            if (input == string.Empty)
            {
                return new List<List<string>> {
                    new List<string> {
                        string.Empty
                    }
                };
            }

            var errors = new List<Error>();
            var spans = _fileSpanner.Process(input, errors);
            if (errors.ContainsNonWarnings())
            {
                var sb = new StringBuilder();
                sb.AppendLine("There were errors:");
                foreach (var error in errors)
                {
                    sb.AppendFormat("  {0}", error.Description);
                    sb.AppendLine();
                }
                throw new InvalidOperationException(sb.ToString());
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
            var prevNewline = true;
            foreach (var linespan in spans[0].Subspans)
            {
                if (linespan.DefRef == _grammar.def_record)
                {
                    var line = new List<string>();
                    bool lastComma = true;
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

                    if (lastComma)
                    {
                        line.Add(string.Empty);
                    }

                    lines.Add(line);

                    prevNewline = false;
                }
                else if (linespan.Node == _grammar.node_file_1__000A_ ||
                        linespan.Node == _grammar.node_file_4__000A_ ||
                        linespan.Node == _grammar.node_file_7__000A_ ||
                        linespan.Node == _grammar.node_file_9__000A_)
                {
                    if (prevNewline)
                    {
                        lines.Add(new List<string> { string.Empty });
                    }
                    else
                    {
                        prevNewline = true;
                    }
                }


            }

            if (prevNewline)
            {
                lines.Add(new List<string> { string.Empty });
            }

            return lines;
        }

        public List<string> ReadCsvLine(string input)
        {
            throw new NotImplementedException();
        }
    }
}

