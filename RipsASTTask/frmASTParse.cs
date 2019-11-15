using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr.Runtime;
using RipsASTTask.ASTreeUtilities;

namespace RipsASTTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpSqlQuery.Width = SystemInformation.VirtualScreen.Width - 10;
            grpParse.Width = SystemInformation.VirtualScreen.Width - 10;
            grpParseStringTree.Width = SystemInformation.VirtualScreen.Width - 10;
            txtSqlQuery.Text = QueryString();


        }

        public string QueryString()
        {
            StringBuilder input = new StringBuilder();
            input.Append("USE database1;");
            input.AppendLine();
            input.Append("SELECT id, name, address FROM users WHERE is_customer IS NOT NULL ORDER BY created;");
            input.AppendLine();
            input.Append("INSERT INTO user_notes (id, user_id, note, created) VALUES (1, 1, \"Note 1\", NOW());");
            input.AppendLine();
            input.Append("DELETE FROM database2.logs WHERE id < 1000;");
            input.AppendLine();
            return input.ToString();

        }
        private void btnParseQuery_Click(object sender, EventArgs e)
        {
            string inputString = txtSqlQuery.Text;
            var input = new ANTLRStringStream(inputString);
            var lexer = new EntityLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new EntityParser(tokens);
            var result = parser.prog();
            var tree = result.Tree;
            txtParseStringTree.Text = tree.ToStringTree();
            var treeNodeDrawable = new ASTreeNode(tree);

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            Image image = new VisualAST(treeNodeDrawable).Draw();
            pictureBox1.Image = image;



        }
    }
}
