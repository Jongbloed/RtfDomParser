﻿/*
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
    /// 页眉元素
    /// </summary>
    [DataContract]
    public class RTFDomHeader : RTFDomElement
    {
        private HeaderFooterStyle _Style = HeaderFooterStyle.AllPages;
        /// <summary>
        /// 页眉页脚样式
        /// </summary>
        [System.ComponentModel.DefaultValue( HeaderFooterStyle.AllPages )]
        [DataMember]
        public HeaderFooterStyle Style
        {
            get
            {
                return _Style; 
            }
            set
            {
                _Style = value; 
            }
        }
        public override string ToString()
        {
            return "Header " + this.Style;
        }

        /// <summary>
        /// 判断元素是否有实际内容
        /// </summary>
        [DataMember]
        public bool HasContentElement
        {
            get
            {
                return RTFUtil.HasContentElement(this);
            }
        }
    }

    /// <summary>
    /// 页脚元素
    /// </summary>
    [DataContract]
    public class RTFDomFooter : RTFDomElement
    {
        private HeaderFooterStyle _Style = HeaderFooterStyle.AllPages;
        /// <summary>
        /// 页眉页脚样式
        /// </summary>
        [System.ComponentModel.DefaultValue(HeaderFooterStyle.AllPages)]
        [DataMember]
        public HeaderFooterStyle Style
        {
            get
            {
                return _Style;
            }
            set
            {
                _Style = value;
            }
        }


        /// <summary>
        /// 判断元素是否有实际内容
        /// </summary>
        [DataMember]
        public bool HasContentElement
        {
            get
            {
                return RTFUtil.HasContentElement(this);
            }
        }

        public override string ToString()
        {
            return "Footer " + this.Style;
        }
    }

    public enum HeaderFooterStyle
    {
        AllPages ,
        LeftPages ,
        RightPages ,
        FirstPage
    }
}