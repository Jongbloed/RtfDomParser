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
    /// 内嵌对象
    /// </summary>
    [DataContract]
    public class RTFDomObject : RTFDomElement
    {
        /// <summary>
        /// 初始化对象
        /// </summary>
        public RTFDomObject()
        {
        }

        private Dictionary<string, string> _CustomAttributes = new Dictionary<string, string>();
        /// <summary>
        /// 用户自定义的属性列表
        /// </summary>
        [DataMember]
        public Dictionary<string, string> CustomAttributes
        {
            get
            {
                if (_CustomAttributes == null)
                {
                    _CustomAttributes = new Dictionary<string, string>();
                }
                return _CustomAttributes; 
            }
            set
            {
                _CustomAttributes = value; 
            }
        }
        
        private RTFObjectType _Type = RTFObjectType.EMB;
        /// <summary>
        /// 对象类型
        /// </summary>
        [DataMember]
        public RTFObjectType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _ClassName = null;
        /// <summary>
        /// 类型名称
        /// </summary>
        [DataMember]
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }

        private string _Name = null;
        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private byte[] _Content = null;
        /// <summary>
        /// 对象二进制内容
        /// </summary>
        [DataMember]
        public byte[] Content
        {
            get { return _Content; }
            set { _Content = value; }
        }

        /// <summary>
        /// 文本格式的内容
        /// </summary>
        [DataMember]
        public string ContentText
        {
            get
            {
                if (_Content == null || _Content.Length == 0)
                {
                    return null;
                }
                else
                {
                    return Encoding.UTF8.GetString(_Content, 0, _Content.Length);
                }
            }
        }

        private int _Width = 0;
        /// <summary>
        /// 宽度
        /// </summary>
        [DataMember]
        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        private int _Height = 0;
        /// <summary>
        /// 高度
        /// </summary>
        [DataMember]
        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        private int _ScaleX = 100;

        [DataMember]
        public int ScaleX
        {
            get { return _ScaleX; }
            set { _ScaleX = value; }
        }

        private int _ScaleY = 100;

        [DataMember]
        public int ScaleY
        {
            get { return _ScaleY; }
            set { _ScaleY = value; }
        }

        public override string ToString()
        {
            string txt = "Object:" + this.Width + "*" + this.Height;
            if (_Content != null && _Content.Length > 0)
            {
                txt = txt + " " + Convert.ToDouble(_Content.Length / 1024.0).ToString("0.00") + "KB";
            }
            return txt;
        }

        /// <summary>
        /// result
        /// </summary>
        [System.ComponentModel.DefaultValue(null)]
        [DataMember]
        public RTFDomElementContainer Result
        {
            get
            {
                foreach (RTFDomElement element in this.Elements)
                {
                    if (element is RTFDomElementContainer)
                    {
                        RTFDomElementContainer c = (RTFDomElementContainer)element;
                        if (c.Name == RTFConsts._result)
                        {
                            return c;
                        }
                    }
                }
                return null;
            }
            //set
            //{
            //    strResult = value;
            //}
        }


    }

    public enum RTFObjectType
    {
        EMB   ,
        Link,
        AutLink ,
        Sub ,
        Pub ,
        Icemb,
        Html,
        Ocx
    }
}
