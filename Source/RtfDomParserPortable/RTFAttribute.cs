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
    /// rtf attribute
    /// </summary>
    [DataContract]
    public class RTFAttribute
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFAttribute()
        {
        }

        private string strName = null;
        /// <summary>
        /// attribute's name
        /// </summary>
        [System.ComponentModel.DefaultValue( null)]
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

        private int intValue = int.MinValue ;
        /// <summary>
        /// value
        /// </summary>
        [System.ComponentModel.DefaultValue( int.MinValue )]
        [DataMember]
        public int Value
        {
            get
            {
                return intValue; 
            }
            set
            {
                intValue = value; 
            }
        }
        public override string ToString()
        {
            return strName + "=" + intValue;
        }
    }

    /// <summary>
    /// RTF attribute list
    /// </summary>
    [DataContract]
    [System.Diagnostics.DebuggerTypeProxy(typeof(RTFInstanceDebugView))]
    public class RTFAttributeList : List<RTFAttribute>
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFAttributeList()
        {
        }

        public RTFAttribute GetItem(int index)
        {
            return (RTFAttribute)this[index];
        }

        public int this[string name]
        {
            get
            {
                foreach (RTFAttribute a in this)
                {
                    if (a.Name == name)
                        return a.Value;
                }
                return int.MinValue;
            }
            set
            {
                foreach (RTFAttribute a in this)
                {
                    if (a.Name == name)
                    {
                        a.Value = value;
                        return;
                    }
                }
                RTFAttribute item = new RTFAttribute();
                item.Name = name;
                item.Value = value;
                this.Add(item);
            }
        }

        public new int Add(RTFAttribute item)
        {
            base.Add(item);
            return base.Count - 1;
        }

        public int Add(string name, int v)
        {
            RTFAttribute item = new RTFAttribute();
            item.Name = name;
            item.Value = v;
            return this.Add(item);
        }
        
        public void Remove(string name)
        {
            base.RemoveAll(item => item.Name == name);
        }
        
        public bool Contains(string name)
        {
            foreach (RTFAttribute a in this)
            {
                if (a.Name == name)
                    return true;
            }
            return false;
        }

        public RTFAttributeList Clone()
        {
            RTFAttributeList list = new RTFAttributeList();
            foreach (RTFAttribute item in this)
            {
                RTFAttribute newItem = new RTFAttribute();
                newItem.Name = item.Name;
                newItem.Value = item.Value;
                list.Add(newItem);
            }
            return list;
        }
    }
}
