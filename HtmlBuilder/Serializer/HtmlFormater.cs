//using HtmlBuilder.Extensions;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace HtmlBuilder.Serializer
//{
//    public class HtmlFormater : IHtmlFormater
//    {
//        private readonly HtmlSerializerSettings settings;

//        public HtmlFormater()
//        {
//            this.settings = new HtmlSerializerSettings();
//        }

//        public HtmlFormater(int count)
//            : this()
//        {
//            this.settings.Count = count;
//        }

//        public HtmlFormater(char identChar)
//            : this()
//        {
//            this.settings.IdentChar = identChar;
//        }

//        public HtmlFormater(int count, char identChar)
//            : this()
//        {
//            this.settings.Count = count;
//            this.settings.IdentChar = identChar;
//        }

//        public HtmlFormater(HtmlSerializerSettings settings)
//        {
//            this.settings = settings;
//        }


//        public void AddIndent(IElement element, IElement startedElement, TextWriter text)
//        {
//            var deep = settings.UseParrentIdent ?
//                element.CalculateDeep() :
//                element.CalculateDeep() - startedElement.CalculateDeep();

//            foreach (var level in Enumerable.Range(0, deep))
//                foreach (var step in Enumerable.Range(0, settings.Count))
//                    text.Write(settings.IdentChar);
//        }


//    }
//}
