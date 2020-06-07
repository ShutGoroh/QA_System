using LemmaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_System
{
    class GenerateAnswer
    {
        //ModelQAContainer model;
        //UserData user;
        //UserSystems systemCollection;

        //List<String> stopWords = new List<String>();

        //public void stopW()
        //{
        //    System.IO.StreamReader file = new System.IO.StreamReader(@"stopWords.txt");
        //    string line;
        //    while ((line = file.ReadLine()) != null)
        //    {
        //        stopWords.Add(line);
        //    }
        //    file.Close();
        //}

        //private List<Double> token(string s)
        //{
        //    ILemmatizer lmtz = new LemmatizerPrebuiltFull(LanguagePrebuilt.Russian);
        //    List<String> wordsInText = new List<string>();
        //    wordsInText.AddRange(s.Split(new char[] { '.', '?', '!', '(', ')', ',', ':', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries));
        //    for (int i = 0; i < wordsInText.Count; i++)
        //    {
        //        wordsInText[i] = wordsInText[i].ToLower();
        //        wordsInText[i] = lmtz.Lemmatize(wordsInText[i]);
        //        for (int w = 0; w < stopWords.Count; w++)
        //        {
        //            if (wordsInText[i] == stopWords[w])
        //            {
        //                wordsInText.RemoveAt(i);
        //                i--;
        //                break;
        //            }
        //        }
        //    }
        //    int size = (from p in model.TypeDemands
        //                where p.GroupDemand.SystemCollectionId == systemCollection.SystemCollectionId
        //                select p).Count();

        //    var gos = (from p in model.GlossarySystems
        //               where p.SystemCollectionId == systemCollection.SystemCollectionId
        //               select p).ToList();
        //    List<Double> tfidf = new List<double>();
        //    double tf = 0;

        //    for (int g = 0; g < gos.Count; g++)
        //    {
        //        for (int k = 0; k < wordsInText.Count; k++)
        //        {
        //            if (wordsInText[k] == gos[g].WordGlossary)
        //                tf++;
        //        }
        //        tf = (tf / wordsInText.Count) * (Math.Log(1 + size / gos[g].WordValue));
        //        tfidf.Add(tf);
        //        tf = 0;
        //    }
        //    return tfidf;
        //}

        //private void searchAncwer(string question)
        //{
        //    double minVal = 0;
        //    int minId = -1;
        //    List<Double> q = new List<double>();
        //    q = token(question);
        //    var a = (from p in model.DemandDescriptions
        //             where p.TypeDemand.GroupDemand.SystemCollectionId == systemCollection.SystemCollectionId
        //             select p).ToList();
        //    for (int i = 0; i < a.Count; i++)
        //    {
        //        List<Double> answer = new List<double>();
        //        answer = token(a[i].Description);
        //        double rast = 0;
        //        double znamenat1 = 0;
        //        double znamenat2 = 0;
        //        double cheslit = 0;
        //        for (int o = 0; o < answer.Count; o++)
        //        {

        //            cheslit = q[o] * answer[o] + cheslit;

        //            znamenat1 = Math.Pow(q[o], 2) + znamenat1;
        //            znamenat2 = Math.Pow(answer[o], 2) + znamenat2;

        //        }
        //        rast = Math.Sqrt(znamenat1) * Math.Sqrt(znamenat2);
        //        rast = Math.Abs(cheslit) / rast;
        //        if (rast >= minVal && rast != 0)
        //        {
        //            minId = a[i].Id;
        //            minVal = rast;
        //        }
        //    }
        //    if (minId != -1)
        //    {
        //        UserQuestions userQuestions = new UserQuestions();
        //        userQuestions.QuestionBody = question;
        //        userQuestions.UserSystemsId = systemCollection.Id;
        //        userQuestions.DemandDescriptionId = minId;
        //        userQuestions.DemandDescription = model.DemandDescriptions.Find(minId);
        //        model.UserQuestions.Add(userQuestions);
        //        model.SaveChanges();
        //        richTextBox1.SelectionColor = Color.Teal;
        //        richTextBox1.AppendText(userQuestions.DemandDescription.Description);
        //    }
        //    else
        //    {
        //        UserQuestions userQuestions = new UserQuestions();
        //        userQuestions.QuestionBody = question;
        //        userQuestions.UserSystemsId = systemCollection.Id;
        //        userQuestions.DemandDescriptionId = null;
        //        model.UserQuestions.Add(userQuestions);
        //        model.SaveChanges();
        //        richTextBox1.SelectionColor = Color.Teal;
        //        richTextBox1.AppendText("I don't know:(");

        //    }
        //}
    }
}
