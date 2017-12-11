using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prodsys
{
    public partial class Form1 : Form
    {
        private string file;
        List<Fact> facts;
        List<Rule> rules;
        List<Fact> trueFacts;
        List<string> goals;

        public Form1()
        {
            InitializeComponent();
        }

        public class Fact
        {
            public string id;
            public string info;
            public double cfactor = 0.0;

            public Fact(string id, string info)
            {
                this.id = id;
                this.info = info;
            }

            public Fact(Fact f)
            {
                id = f.id;
                info = f.info;
                cfactor = f.cfactor;
            }

            public override string ToString()
            {
                if (cfactor != 0.0)
                    return id + ": " + info + ", " + cfactor.ToString();
                else
                    return id + ": " + info;
            }

    }

        public class Rule
        {
            public string id;
            public string info;
            public List<string> left;
            public string right;
            public double cfactor = 0.0;

            public Rule(string id, List<string> left, string right, double cfactor, string info)
            {
                this.id = id;
                this.info = info;
                this.left = left;
                this.right = right;
                this.cfactor = cfactor;
            }

            public override string ToString()
            {
                string left_side = "";
                for (int i = 0; i < left.Count - 1; i++)
                {
                    left_side += left[i] + ", ";
                }
                left_side += left[left.Count - 1];
                return id + ": " + left_side + " -> " + right + " " + info + ", " + cfactor.ToString();
            }
        }

        private void KBbutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;

                if (!File.Exists(file))
                {
                    FileStream fs = File.Create(file);
                    fs.Close();
                }

                factsLB.Items.Clear();
                rulesLB.Items.Clear();
                clearButton_Click(sender, e);

                facts = new List<Fact>();
                rules = new List<Rule>();
                string line;

                StreamReader sr = new StreamReader(file);
                while ((line = sr.ReadLine()) != null)
                {
                    string[] chunks = line.Split(';');
                    if (chunks[0][0] == 'f')
                    {
                        facts.Add(new Fact(chunks[0], chunks[1]));
                        factsLB.Items.Add(new Fact(chunks[0], chunks[1]));
                    }

                    if (chunks[0][0] == 'p')
                    {
                        string[] left_side = chunks[1].Split(',');
                        List<string> left = new List<string>();
                        for (int i = 0; i < left_side.Length; i++)
                            left.Add(left_side[i]);
                        rules.Add(new Rule(chunks[0], left, chunks[2], Double.Parse(chunks[3]), chunks[4]));
                        rulesLB.Items.Add(new Rule(chunks[0], left, chunks[2], Double.Parse(chunks[3]), chunks[4]));
                    }
                }
                sr.Close();
            }
        }

        private void factsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = this.factsLB.IndexFromPoint(e.Location);
            if (ind != System.Windows.Forms.ListBox.NoMatches && !trueFactsLB.Items.Contains(factsLB.Items[ind]))
                trueFactsLB.Items.Add(factsLB.Items[ind]);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            int cnt = trueFactsLB.Items.Count;
            for (int i = 0; i < cnt; ++i)
                trueFactsLB.Items.RemoveAt(0);

            cnt = procRulesLB.Items.Count;
            for (int i = 0; i < cnt; ++i)
                procRulesLB.Items.RemoveAt(0);

            cnt = resFactsLB.Items.Count;
            for (int i = 0; i < cnt; ++i)
                resFactsLB.Items.RemoveAt(0);

            label3.Text = "";
        }

        private void trueFactsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = this.trueFactsLB.IndexFromPoint(e.Location);
            if (ind != System.Windows.Forms.ListBox.NoMatches)
                trueFactsLB.Items.RemoveAt(ind);
        }

        private void forChainButton_Click(object sender, EventArgs e)
        {
            if (trueFactsLB.Items.Count == 0) return;
            label3.Text = "";
            if (procRulesLB.Items.Count > 0)
            {
                int cnt = procRulesLB.Items.Count;
                for (int i = 0; i < cnt; ++i)
                    procRulesLB.Items.RemoveAt(0);
            }
            if (resFactsLB.Items.Count > 0)
            {
                int cnt = resFactsLB.Items.Count;
                for (int i = 0; i < cnt; ++i)
                    resFactsLB.Items.RemoveAt(0);
            }

            trueFacts = new List<Fact>();
            for (int i = 0; i < trueFactsLB.Items.Count; ++i)
                trueFacts.Add((Fact)trueFactsLB.Items[i]);

            List<Fact> resFacts;
            do
            {

                resFacts = new List<Fact>();
                for (int i = 0; i < rules.Count; ++i)
                {
                    int matches = 0;
                    double min = Double.MaxValue;
                    for (int j = 0; j < trueFacts.Count; ++j)
                        // если встречаем в правой части правила один из достоверных фактов
                        if (trueFacts[j].id.Equals(rules[i].right))
                            --matches;
                        else 
                            if (rules[i].left.IndexOf(trueFacts[j].id) != -1)
                        {
                            if (trueFacts[j].cfactor < min)
                                min = trueFacts[j].cfactor;
                            ++matches;
                        }
                                

                    if (matches == rules[i].left.Count)
                    {
                        for (int j = 0; j < facts.Count; ++j)
                            if (facts[j].id == rules[i].right)
                            {
                                Fact f = new Fact((Fact)factsLB.Items[j]);
                                f.cfactor = min * rules[i].cfactor;
                                resFacts.Add(f);
                                break;
                            }
                        procRulesLB.Items.Add(rules[i].ToString());
                    }
                }

                for (int i = 0; i < resFacts.Count; ++i)
                {
                    trueFacts.Add(resFacts[i]);
                    resFactsLB.Items.Add(resFacts[i]);
                }

            } while (resFacts.Count > 0);
        }

        private bool derive(string fid)
        {
            for(int i = 0; i < trueFacts.Count; ++i)
                if (trueFacts[i].id == fid)
                    return true;
            if (!goals.Contains(fid))
                goals.Add(fid);
            else
                return false;
            for (int i = 0; i < rules.Count; ++i)
                if (rules[i].right == fid) // если нашли правило с данным фактом справа
                {
                    int cnt = 0;
                    for (int j = 0; j < rules[i].left.Count; ++j) // проверяем выводимы ли левые факты
                    {
                        if (derive(rules[i].left[j]))
                            ++cnt;
                            
                    }
                    if(cnt == rules[i].left.Count)
                    {
                        procRulesLB.Items.Add(rules[i]);
                        for (int j = 0; j < facts.Count; ++j)
                            if (facts[j].id == rules[i].right)
                            {
                                trueFacts.Add(facts[j]);
                                break;
                            }
                        return true;
                    }
                }
            return false;
        }

        private void backChainButton_Click(object sender, EventArgs e)
        {
            if (trueFactsLB.Items.Count == 0) return;

            string fact_id = textBox1.Text.ToString();
            if (fact_id == "") return;

            label3.Text = "";
            if (procRulesLB.Items.Count > 0)
            {
                int cnt = procRulesLB.Items.Count;
                for (int i = 0; i < cnt; ++i)
                    procRulesLB.Items.RemoveAt(0);
            }
            if (resFactsLB.Items.Count > 0)
            {
                int cnt = resFactsLB.Items.Count;
                for (int i = 0; i < cnt; ++i)
                    resFactsLB.Items.RemoveAt(0);
            }

            trueFacts = new List<Fact>();
            for (int i = 0; i < trueFactsLB.Items.Count; ++i)
                trueFacts.Add((Fact)trueFactsLB.Items[i]);

            goals = new List<string>();
            bool derivable = derive(fact_id);
            if (!derivable)
                label3.Text = fact_id + " is not derivable!";
                //MessageBox.Show(fact_id + " is not derivable!");
        }

        private void conFactorBtton_Click(object sender, EventArgs e)
        {
            if (trueFactsLB.SelectedIndex == -1) return;
            Fact f = new Fact((Fact)trueFactsLB.SelectedItem);
            try { f.cfactor = Double.Parse(textBox2.Text.ToString()); }
            catch { MessageBox.Show("Write double with comma!"); }
            int ind = trueFactsLB.Items.IndexOf(trueFactsLB.SelectedItem);
            trueFactsLB.Items.RemoveAt(ind);
            trueFactsLB.Items.Insert(ind, f);
            trueFactsLB.SelectedIndex = ind;
        }
    }
}
