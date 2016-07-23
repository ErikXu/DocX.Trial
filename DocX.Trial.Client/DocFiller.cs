using System.Collections.Generic;
using System.IO;

namespace DocX.Trial.Client
{
    public class DocFiller
    {
        public void Fill(string templatePath, string filePath, IEnumerable<DocItem> items)
        {
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                var doc = Novacode.DocX.Load(templatePath);

                foreach (var item in items)
                {
                    doc.Paragraphs[item.ParagraphIndex].ReplaceText(item.Placeholder, item.Value);
                }
                doc.SaveAs(fs);
            }
        }
    }
}