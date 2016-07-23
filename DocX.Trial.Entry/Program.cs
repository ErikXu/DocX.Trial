using System;
using System.Collections.Generic;
using System.IO;
using DocX.Trial.Client;

namespace DocX.Trial.Entry
{
    class Program
    {
        static void Main()
        {
            TestFill();
        }

        private static void TestFill()
        {
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "Letter.docx");
            var items = new List<DocItem>
            {
                new DocItem (0, "[收件人]", "张三"),
                new DocItem (2, "[公司名称]", "DocX公司"),
                new DocItem (2, "[商业类型]", "Doc使用"),
                new DocItem (3, "[电话号码]", "400-123-456"),
                new DocItem (3, "[销售代表]", "李四"),
                new DocItem (4, "[公司名称]", "DocX公司"),
                new DocItem (10, "[发件人]", "王五"),
                new DocItem (11, "[职位]", "首席执行官")
            };

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fill.docx");

            var filler = new DocFiller();
            filler.Fill(templatePath, filePath, items);
        }
    }
}
