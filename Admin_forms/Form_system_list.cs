using LemmaSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace QA_System.Admin_forms
{
    public partial class Form_system_list : Form
    {
        ModelQAContainer model;
        int currentPage = 0;
        List<String> stopWords = new List<String>();

        public Form_system_list(ModelQAContainer _model)
        {
            InitializeComponent();
            model = _model;
            stopW();
        }

        private void Form_system_list_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        public void Alert(string msg, Form_Alerts.enmType type)
        {
            Form_Alerts frm = new Form_Alerts();
            frm.showAlert(msg, type);
        }

        public void ShowList()
        {
            TableSystemList.DataSource = (from p in model.SystemCollections
                                          select new
                                          {
                                              id = p.Id,
                                              Наименование = p.SystemName
                                          }).ToList();
            TableSystemList.Columns[TableSystemList.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            TableSystemList.Update();
            TableSystemList.Columns[0].Visible = false;
            TableSystemList.ClearSelection();
        }

        public void stopW()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"stopWords.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                stopWords.Add(line);
            }
            file.Close();
        }

        private void AdditionToGlossary(string s, SystemCollection system)
        {
            ILemmatizer lmtz = new LemmatizerPrebuiltFull(LanguagePrebuilt.Russian);
            List<String> wordsInText = new List<string>();
            wordsInText.AddRange(s.Split(new char[] { '.', '?', '!', '(', ')', ',', ':', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries));
            for (int i = 0; i < wordsInText.Count; i++)
            {
                wordsInText[i] = wordsInText[i].ToLower();
                wordsInText[i] = lmtz.Lemmatize(wordsInText[i]);
                for (int w = 0; w < stopWords.Count; w++)
                {
                    if (wordsInText[i] == stopWords[w])
                    {
                        wordsInText.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            List<String> words = new List<string>();
            foreach (var a in wordsInText.Distinct<string>())
                words.Add(a);

            for (int i = 0; i < words.Count; i++)
            {
                bool t = false;
                GlossarySystem glossarySystem = new GlossarySystem();

                var gos = (from p in model.GlossarySystems where p.SystemCollectionId == system.Id select p).ToList();
                for (int g = 0; g < gos.Count; g++)
                {
                    if (gos[g].WordGlossary == words[i])
                    {
                        glossarySystem = model.GlossarySystems.Find(gos[g].Id);
                        t = true;
                        break;
                    }
                }
                if (t != true)
                {
                    glossarySystem.WordGlossary = words[i];
                    glossarySystem.SystemCollectionId = system.Id;
                    glossarySystem.WordValue = 1;
                    glossarySystem.SystemCollection = system;
                    model.GlossarySystems.Add(glossarySystem);
                    model.SaveChanges();
                }
                else
                {
                    glossarySystem.WordValue++;
                    model.SaveChanges();
                }
            }
        }

        private void ParseText(DocX doc, int m, int l, SystemCollection system, string sGroup)
        {
            List<String> listIndex = new List<string> { "КП-",
                "ОС-",
                "ОДР-",
                "ДП-",
                "ПЗ-",
                "ФС-",
                "ИП-",
                "ИО-",
                "ПИ-",
                "ИПД-",
                "ТП-",
                "ТОТ-",
                "ТБ-",
                "АКПО-" };
            List<String> listName = new List<string> {
            "Классы и характеристики пользователей",
            "Операционная среда",
            "Ограничения дизайна и реализации",
            "Документация для пользователей",
            "Предположения и зависимости",
            "Функции системы",
            "Интерфейсы пользователей",
            "Интерфейсы оборудования",
            "Программные интерфейсы",
            "Интерфейсы передачи данных",
            "Требования к производительности",
            "Требования к охране труда",
            "Требования к безопасности",
            "Атрибуты качества ПО"
            };
            
            var paragraph = doc.Paragraphs;
            GroupDemand group = new GroupDemand();
            group.GroupName = sGroup + system.SystemName;
            group.SystemCollectionId = system.Id;
            group.SystemCollection = system;
            model.GroupDemands.Add(group);
            model.SaveChanges();
            for (int j = m; j < l; j++)
            {
                TypeDemand typeDemand = new TypeDemand();
                typeDemand.TymeName = listName[j];
                typeDemand.GroupDemandId = group.Id;
                typeDemand.GroupDemand = group;
                model.TypeDemands.Add(typeDemand);
                model.SaveChanges();
                for (int k = 1; k < paragraph.Count; k++)
                {
                    if (currentPage < paragraph.Count)
                    {
                        var parText = paragraph[currentPage];
                        string s = parText.Text;
                        Regex regex = new Regex(listIndex[j] + k + ".");
                        MatchCollection matches = regex.Matches(s);
                        if (matches.Count > 0)
                        {
                            DemandDescription description = new DemandDescription();
                            description.Description = s;
                            description.TypeDemandId = typeDemand.Id;
                            description.TypeDemand = typeDemand;
                            model.DemandDescriptions.Add(description);
                            model.SaveChanges();
                            AdditionToGlossary(s, system);
                            currentPage++;                            
                        }
                        else
                        {
                            if (k == 1)
                            {
                                DemandDescription description = new DemandDescription();
                                description.Description = s;
                                description.TypeDemandId = typeDemand.Id;
                                description.TypeDemand = typeDemand;
                                model.DemandDescriptions.Add(description);
                                model.SaveChanges();
                                AdditionToGlossary(s, system);
                                currentPage++;
                            }
                            else
                            {
                                currentPage++;
                                break;
                            }
                        }
                    }
                    else
                        break;
                }
            }
            currentPage++;
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            OpenDocFile();
        }

        private void OpenDocFile()
        {
            List<String> listGroup = new List<string> {
            "Общее описание ",
            "Функциональные требования ",
            "Требования к внешнему интерфейсу ",
            "Другие нефункциональные требования "
            };
            currentPage = 5;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                DocX doc = DocX.Load(ofd.FileName);
                var paragraph = doc.Paragraphs;
                var parText = paragraph[0];
                textBox1.Text = parText.Text;
                SystemCollection system = new SystemCollection();
                system.SystemName = parText.Text;
                parText = paragraph[3];
                system.GeneralDescription = parText.Text;
                model.SystemCollections.Add(system);
                model.SaveChanges();
                textBox1.Text = "Please wait";
                ParseText(doc, 0, 5, system, listGroup[0]);
                ParseText(doc, 5, 6, system, listGroup[1]);
                ParseText(doc, 6, 10, system, listGroup[2]);
                ParseText(doc, 10, 14, system, listGroup[3]);
                textBox1.Text = system.GeneralDescription;
            }
            Alert("Success", Form_Alerts.enmType.Success);
            ShowList();
        }
    }
}
