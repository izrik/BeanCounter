using System;
using MetaphysicsIndustries.Giza;

namespace BeanCounter
{
    public class CsvGrammar : Grammar
    {
        public Definition def_file = new Definition("file");
        public Definition def_record = new Definition("record");
        public Definition def_field = new Definition("field");
        public Definition def_escaped = new Definition("escaped");
        public Definition def_non_002D_escaped = new Definition("non-escaped");
        public Definition def_text_002D_data = new Definition("text-data");

        public CharNode node_file_0__000D_;
        public CharNode node_file_1__000A_;
        public DefRefNode node_file_2_record;
        public CharNode node_file_3__000D_;
        public CharNode node_file_4__000A_;
        public DefRefNode node_file_5_record;
        public CharNode node_file_6__000D_;
        public CharNode node_file_7__000A_;
        public CharNode node_file_8__000D_;
        public CharNode node_file_9__000A_;
        public CharNode node_record_0__002C_;
        public DefRefNode node_record_1_field;
        public CharNode node_record_2__002C_;
        public DefRefNode node_record_3_field;
        public DefRefNode node_field_0_escaped;
        public DefRefNode node_field_1_non_002D_escaped;
        public CharNode node_escaped_0__0022_;
        public DefRefNode node_escaped_1_text_002D_data;
        public CharNode node_escaped_2__005C_n_005C_r_002C_;
        public CharNode node_escaped_3__0022__0022_;
        public CharNode node_escaped_4__0022__0022_;
        public CharNode node_escaped_5__0022_;
        public DefRefNode node_non_002D_escaped_0_text_002D_data;
        public CharNode node_text_002D_data_0__005C_l_005C_d_0020__0021__0023__0024__0025__0026__0027__0028__0029__002A__002B__002D__002E__002F__003A__003B__003C__003D__003E__003F__0040__005C__005B__005C__005C__005C__005D__005E__005F__0060__007B__007C__007D__007E_;

        public CsvGrammar()
        {
            Definitions.Add(def_file);
            Definitions.Add(def_record);
            Definitions.Add(def_field);
            Definitions.Add(def_escaped);
            Definitions.Add(def_non_002D_escaped);
            Definitions.Add(def_text_002D_data);

            def_file.Directives.Add(DefinitionDirective.MindWhitespace);
            node_file_0__000D_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\r"), "\r");
            node_file_1__000A_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\n"), "\n");
            node_file_2_record = new DefRefNode(def_record, "record");
            node_file_3__000D_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\r"), "\r");
            node_file_4__000A_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\n"), "\n");
            node_file_5_record = new DefRefNode(def_record, "record");
            node_file_6__000D_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\r"), "\r");
            node_file_7__000A_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\n"), "\n");
            node_file_8__000D_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\r"), "\r");
            node_file_9__000A_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\n"), "\n");
            def_file.Nodes.Add(node_file_0__000D_);
            def_file.Nodes.Add(node_file_1__000A_);
            def_file.Nodes.Add(node_file_2_record);
            def_file.Nodes.Add(node_file_3__000D_);
            def_file.Nodes.Add(node_file_4__000A_);
            def_file.Nodes.Add(node_file_5_record);
            def_file.Nodes.Add(node_file_6__000D_);
            def_file.Nodes.Add(node_file_7__000A_);
            def_file.Nodes.Add(node_file_8__000D_);
            def_file.Nodes.Add(node_file_9__000A_);
            def_file.StartNodes.Add(node_file_0__000D_);
            def_file.StartNodes.Add(node_file_1__000A_);
            def_file.StartNodes.Add(node_file_2_record);
            def_file.StartNodes.Add(node_file_8__000D_);
            def_file.StartNodes.Add(node_file_9__000A_);
            def_file.EndNodes.Add(node_file_7__000A_);
            def_file.EndNodes.Add(node_file_5_record);
            def_file.EndNodes.Add(node_file_2_record);
            def_file.EndNodes.Add(node_file_9__000A_);
            node_file_0__000D_.NextNodes.Add(node_file_1__000A_);
            node_file_1__000A_.NextNodes.Add(node_file_0__000D_);
            node_file_1__000A_.NextNodes.Add(node_file_1__000A_);
            node_file_1__000A_.NextNodes.Add(node_file_2_record);
            node_file_2_record.NextNodes.Add(node_file_3__000D_);
            node_file_2_record.NextNodes.Add(node_file_4__000A_);
            node_file_2_record.NextNodes.Add(node_file_6__000D_);
            node_file_2_record.NextNodes.Add(node_file_7__000A_);
            node_file_3__000D_.NextNodes.Add(node_file_4__000A_);
            node_file_4__000A_.NextNodes.Add(node_file_3__000D_);
            node_file_4__000A_.NextNodes.Add(node_file_4__000A_);
            node_file_4__000A_.NextNodes.Add(node_file_5_record);
            node_file_5_record.NextNodes.Add(node_file_3__000D_);
            node_file_5_record.NextNodes.Add(node_file_4__000A_);
            node_file_5_record.NextNodes.Add(node_file_6__000D_);
            node_file_5_record.NextNodes.Add(node_file_7__000A_);
            node_file_6__000D_.NextNodes.Add(node_file_7__000A_);
            node_file_7__000A_.NextNodes.Add(node_file_6__000D_);
            node_file_7__000A_.NextNodes.Add(node_file_7__000A_);
            node_file_8__000D_.NextNodes.Add(node_file_9__000A_);
            node_file_9__000A_.NextNodes.Add(node_file_8__000D_);
            node_file_9__000A_.NextNodes.Add(node_file_9__000A_);

            def_record.Directives.Add(DefinitionDirective.MindWhitespace);
            node_record_0__002C_ = new CharNode(CharClass.FromUndelimitedCharClassText(","), ",");
            node_record_1_field = new DefRefNode(def_field, "field");
            node_record_2__002C_ = new CharNode(CharClass.FromUndelimitedCharClassText(","), ",");
            node_record_3_field = new DefRefNode(def_field, "field");
            def_record.Nodes.Add(node_record_0__002C_);
            def_record.Nodes.Add(node_record_1_field);
            def_record.Nodes.Add(node_record_2__002C_);
            def_record.Nodes.Add(node_record_3_field);
            def_record.StartNodes.Add(node_record_0__002C_);
            def_record.StartNodes.Add(node_record_1_field);
            def_record.EndNodes.Add(node_record_3_field);
            def_record.EndNodes.Add(node_record_2__002C_);
            def_record.EndNodes.Add(node_record_1_field);
            node_record_0__002C_.NextNodes.Add(node_record_1_field);
            node_record_1_field.NextNodes.Add(node_record_2__002C_);
            node_record_2__002C_.NextNodes.Add(node_record_3_field);
            node_record_2__002C_.NextNodes.Add(node_record_2__002C_);
            node_record_3_field.NextNodes.Add(node_record_2__002C_);

            def_field.Directives.Add(DefinitionDirective.MindWhitespace);
            node_field_0_escaped = new DefRefNode(def_escaped, "escaped");
            node_field_1_non_002D_escaped = new DefRefNode(def_non_002D_escaped, "non-escaped");
            def_field.Nodes.Add(node_field_0_escaped);
            def_field.Nodes.Add(node_field_1_non_002D_escaped);
            def_field.StartNodes.Add(node_field_0_escaped);
            def_field.StartNodes.Add(node_field_1_non_002D_escaped);
            def_field.EndNodes.Add(node_field_0_escaped);
            def_field.EndNodes.Add(node_field_1_non_002D_escaped);

            def_escaped.Directives.Add(DefinitionDirective.MindWhitespace);
            node_escaped_0__0022_ = new CharNode(CharClass.FromUndelimitedCharClassText("\""), "\"");
            node_escaped_1_text_002D_data = new DefRefNode(def_text_002D_data, "text-data");
            node_escaped_2__005C_n_005C_r_002C_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\n\\r,"), "\\n\\r,");
            node_escaped_3__0022__0022_ = new CharNode(CharClass.FromUndelimitedCharClassText("\""), "\"\"");
            node_escaped_4__0022__0022_ = new CharNode(CharClass.FromUndelimitedCharClassText("\""), "\"\"");
            node_escaped_5__0022_ = new CharNode(CharClass.FromUndelimitedCharClassText("\""), "\"");
            def_escaped.Nodes.Add(node_escaped_0__0022_);
            def_escaped.Nodes.Add(node_escaped_1_text_002D_data);
            def_escaped.Nodes.Add(node_escaped_2__005C_n_005C_r_002C_);
            def_escaped.Nodes.Add(node_escaped_3__0022__0022_);
            def_escaped.Nodes.Add(node_escaped_4__0022__0022_);
            def_escaped.Nodes.Add(node_escaped_5__0022_);
            def_escaped.StartNodes.Add(node_escaped_0__0022_);
            def_escaped.EndNodes.Add(node_escaped_5__0022_);
            node_escaped_0__0022_.NextNodes.Add(node_escaped_1_text_002D_data);
            node_escaped_0__0022_.NextNodes.Add(node_escaped_2__005C_n_005C_r_002C_);
            node_escaped_0__0022_.NextNodes.Add(node_escaped_3__0022__0022_);
            node_escaped_0__0022_.NextNodes.Add(node_escaped_5__0022_);
            node_escaped_1_text_002D_data.NextNodes.Add(node_escaped_1_text_002D_data);
            node_escaped_1_text_002D_data.NextNodes.Add(node_escaped_2__005C_n_005C_r_002C_);
            node_escaped_1_text_002D_data.NextNodes.Add(node_escaped_3__0022__0022_);
            node_escaped_1_text_002D_data.NextNodes.Add(node_escaped_5__0022_);
            node_escaped_2__005C_n_005C_r_002C_.NextNodes.Add(node_escaped_1_text_002D_data);
            node_escaped_2__005C_n_005C_r_002C_.NextNodes.Add(node_escaped_2__005C_n_005C_r_002C_);
            node_escaped_2__005C_n_005C_r_002C_.NextNodes.Add(node_escaped_3__0022__0022_);
            node_escaped_2__005C_n_005C_r_002C_.NextNodes.Add(node_escaped_5__0022_);
            node_escaped_3__0022__0022_.NextNodes.Add(node_escaped_4__0022__0022_);
            node_escaped_4__0022__0022_.NextNodes.Add(node_escaped_1_text_002D_data);
            node_escaped_4__0022__0022_.NextNodes.Add(node_escaped_2__005C_n_005C_r_002C_);
            node_escaped_4__0022__0022_.NextNodes.Add(node_escaped_3__0022__0022_);
            node_escaped_4__0022__0022_.NextNodes.Add(node_escaped_5__0022_);

            def_non_002D_escaped.Directives.Add(DefinitionDirective.MindWhitespace);
            node_non_002D_escaped_0_text_002D_data = new DefRefNode(def_text_002D_data, "text-data");
            def_non_002D_escaped.Nodes.Add(node_non_002D_escaped_0_text_002D_data);
            def_non_002D_escaped.StartNodes.Add(node_non_002D_escaped_0_text_002D_data);
            def_non_002D_escaped.EndNodes.Add(node_non_002D_escaped_0_text_002D_data);
            node_non_002D_escaped_0_text_002D_data.NextNodes.Add(node_non_002D_escaped_0_text_002D_data);

            def_text_002D_data.Directives.Add(DefinitionDirective.MindWhitespace);
            node_text_002D_data_0__005C_l_005C_d_0020__0021__0023__0024__0025__0026__0027__0028__0029__002A__002B__002D__002E__002F__003A__003B__003C__003D__003E__003F__0040__005C__005B__005C__005C__005C__005D__005E__005F__0060__007B__007C__007D__007E_ = new CharNode(CharClass.FromUndelimitedCharClassText("\\l\\d !#$%&'()*+-./:;<=>?@\\[\\\\\\]^_`{|}~"), "\\l\\d !#$%&'()*+-./:;<=>?@\\[\\\\\\]^_`{|}~");
            def_text_002D_data.Nodes.Add(node_text_002D_data_0__005C_l_005C_d_0020__0021__0023__0024__0025__0026__0027__0028__0029__002A__002B__002D__002E__002F__003A__003B__003C__003D__003E__003F__0040__005C__005B__005C__005C__005C__005D__005E__005F__0060__007B__007C__007D__007E_);
            def_text_002D_data.StartNodes.Add(node_text_002D_data_0__005C_l_005C_d_0020__0021__0023__0024__0025__0026__0027__0028__0029__002A__002B__002D__002E__002F__003A__003B__003C__003D__003E__003F__0040__005C__005B__005C__005C__005C__005D__005E__005F__0060__007B__007C__007D__007E_);
            def_text_002D_data.EndNodes.Add(node_text_002D_data_0__005C_l_005C_d_0020__0021__0023__0024__0025__0026__0027__0028__0029__002A__002B__002D__002E__002F__003A__003B__003C__003D__003E__003F__0040__005C__005B__005C__005C__005C__005D__005E__005F__0060__007B__007C__007D__007E_);

        }
    }
}

