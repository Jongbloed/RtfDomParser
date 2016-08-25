/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */


using System;
using System.Runtime.InteropServices ;
using System.IO ;
using System.Text ;

namespace RtfDomParser
{
	/// <summary>
    /// some utility functions , this source code evolution from other software.
	/// </summary>
	internal class RTFUtil
	{


        /// <summary>
        /// 判断对象是否有实际内容
        /// </summary>
        /// <param name="rootElement">根元素对象</param>
        /// <returns>是否有实际内容</returns>
        public static bool HasContentElement(RTFDomElement rootElement)
        {
            if (rootElement.Elements.Count == 0)
            {
                return false;
            }
            if (rootElement.Elements.Count == 1)
            {
                if (rootElement.Elements[0] is RTFDomParagraph)
                {
                    RTFDomParagraph p = (RTFDomParagraph)rootElement.Elements[0];
                    if (p.Elements.Count == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
		private RTFUtil()
		{
			 
		}
	}
}
