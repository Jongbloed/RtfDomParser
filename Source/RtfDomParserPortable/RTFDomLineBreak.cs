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
    /// line element
    /// </summary>
    [DataContract]
    public class RTFDomLineBreak : RTFDomElement
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomLineBreak()
        {
            this.Locked = true;
        }

        [DataMember]
        public override string InnerText
        {
            get
            {
                return Environment.NewLine;
            }
        }
        public override string ToString()
        {
            return "linebreak";
        }
    }
}
