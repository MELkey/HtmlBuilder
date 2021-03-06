﻿namespace HtmlBuilder.Tags
{
    /// <summary>
    /// An addition to the document
    /// </summary>
    public class Ins : GlobalElement
    {
        private const string name = "ins";
        public override string TagName => name;

        /// <summary>
        /// Link to the source of the quotation or more information about the edit
        /// </summary>
        public Attributes.Cite Cite { get; set; }

        /// <summary>
        /// Date and (optionally) time of the change
        /// </summary>
        public Attributes.DateTime DateTime { get; set; }
    }
}
