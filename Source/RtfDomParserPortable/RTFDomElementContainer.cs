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
    /// RTF element container
    /// </summary>
    [DataContract]
    public class RTFDomElementContainer : RTFDomElement
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomElementContainer()
        {
        }
        private string strName = null;
        /// <summary>
        /// name
        /// </summary>
        [System.ComponentModel.DefaultValue( null )]
        [DataMember]
        public string Name
        {
            get
            {
                return strName; 
            }
            set
            {
                strName = value; 
            }
        }

        public override string ToString()
        {
            return "Container : " + strName;
        }
    }
}
