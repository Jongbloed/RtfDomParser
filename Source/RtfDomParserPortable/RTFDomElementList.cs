/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */



using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace RtfDomParser
{
    /// <summary>
    /// RTF element's list
    /// </summary>
    [DataContract]
    [System.Diagnostics.DebuggerTypeProxy(typeof(RTFInstanceDebugView))]
    public class RTFDomElementList : List<RTFDomElement>
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomElementList()
        {
        }

        /// <summary>
        /// get the last element in the list
        /// </summary>
        public RTFDomElement LastElement
        {
            get
            {
                if (this.Count > 0)
                    return (RTFDomElement)this[this.Count - 1];
                else
                    return null;
            }
        }
        /// <summary>
        /// add element
        /// </summary>
        /// <param name="element">element</param>
        /// <returns>index</returns>
        public new int Add(RTFDomElement element )
        {
            base.Add( element );
            return base.Count - 1;
        }
    }
}
