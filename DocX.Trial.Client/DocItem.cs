namespace DocX.Trial.Client
{
    public class DocItem
    {
        public DocItem(int paragraphIndex, string placeholder, string value)
        {
            ParagraphIndex = paragraphIndex;
            Placeholder = placeholder;
            Value = value;
        }

        public int ParagraphIndex { get; set; }

        public string Placeholder { get; set; }

        public string Value { get; set; }
    }
}