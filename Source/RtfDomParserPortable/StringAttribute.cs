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
    /// string attribute
    /// </summary>
    [DataContract]
    public class StringAttribute
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public StringAttribute()
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

        private string strValue = null;
        /// <summary>
        /// value
        /// </summary>
        [System.ComponentModel.DefaultValue( null)]
        [DataMember]
        public string Value
        {
            get
            {
                return strValue; 
            }
            set
            {
                strValue = value; 
            }
        }
        public override string ToString()
        {
            return strName + "=" + strValue;
        }
    }

    [DataContract]
    [System.Diagnostics.DebuggerTypeProxy(typeof(RTFInstanceDebugView))]
    public class StringAttributeCollection : List<StringAttribute>
    {
        public StringAttributeCollection()
        {
        }

        public string this[string name]
        {
            get
            {
                foreach (StringAttribute attr in this)
                {
                    if (attr.Name == name)
                    {
                        return attr.Value;
                    }
                }
                return null;
            }
            set
            {
                foreach (StringAttribute item in this)
                {
                    if (item.Name == name)
                    {
                        if (value == null)
                            base.Remove(item);
                        else
                            item.Value = value;
                        return;
                    }
                }
                if (value != null)
                {
                    StringAttribute newItem = new StringAttribute();
                    newItem.Name = name;
                    newItem.Value = value;
                    base.Add(newItem);
                }
            }
        }

        public new int Add(StringAttribute item)
        {
            base.Add(item);
            return base.Count - 1;
        }
        
    }
}
