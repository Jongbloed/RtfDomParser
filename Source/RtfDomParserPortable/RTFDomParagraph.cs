/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */



using System;
using System.Runtime.Serialization;
using System.Text;

namespace RtfDomParser
{
    /// <summary>
    /// paragraph element
    /// </summary>
    [DataContract]
    public class RTFDomParagraph : RTFDomElement
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomParagraph()
        {
        }

        internal bool TemplateGenerated = false;
        /// <summary>
        /// 是否是临时生成的段落对象
        /// </summary>
        [DataMember]
        public bool IsTemplateGenerated
        {
            get
            {
                return TemplateGenerated;
            }
        }
        private DocumentFormatInfo myFormat = new DocumentFormatInfo();
        /// <summary>
        /// format
        /// </summary>
        [DataMember]
        public DocumentFormatInfo Format
        {
            get
            {
                return myFormat; 
            }
            set
            {
                myFormat = value; 
            }
        }
        [DataMember]
        public override string InnerText
        {
            get
            {
                return base.InnerText + Environment.NewLine ;
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Paragraph");
            if (this.Format != null)
            {
                str.Append("(" + this.Format.Align + ")");
                if (this.Format.ListID >= 0)
                {
                    str.Append("ListID:" + this.Format.ListID);
                }
                //if (this.Format.NumberedList)
                //{
                //    str.Append("(NumberedList)");
                //}
                //else if (this.Format.BulletedList)
                //{
                //    str.Append("(BulletedList)");
                //}
            }
            
            return str.ToString();
        }
    }
}
