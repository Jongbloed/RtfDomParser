/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */



using System;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RtfDomParser
{
    /// <summary>
    /// table row
    /// </summary>
    [DataContract]
    public class RTFDomTableRow : RTFDomElement
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomTableRow()
        {
        }

        private List<RTFAttributeList> myCellSettings = new List<RTFAttributeList>();
        /// <summary>
        /// cell settings
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        internal List<RTFAttributeList> CellSettings
        {
            get
            {
                return myCellSettings;
            }
            set
            {
                myCellSettings = value;
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

        private int intLevel = 1;
        /// <summary>
        /// document level
        /// </summary>
        [DefaultValue( 1 )]
        [DataMember]
        public int Level
        {
            get 
            {
                return intLevel; 
            }
            set
            {
                intLevel = value;
            }
        }

        private int intRowIndex = 0;
        /// <summary>
        /// row index
        /// </summary>
        [DefaultValue( 0 )]
        [DataMember]
        internal int RowIndex
        {
            get
            {
                return intRowIndex;
            }
            set
            {
                intRowIndex = value;
            }
        }

        private bool bolIsLastRow = false;
        /// <summary>
        /// is the last row
        /// </summary>
        [DefaultValue( false )]
        [DataMember]
        public bool IsLastRow
        {
            get
            {
                return bolIsLastRow;
            }
            set
            {
                bolIsLastRow = value;
            }
        }

        private bool bolHeader = false;
        /// <summary>
        /// is header row
        /// </summary>
        [DefaultValue( false )]
        [DataMember]
        public bool Header
        {
            get
            {
                return bolHeader;
            }
            set
            {
                bolHeader = value;
            }
        }
         

        private int intHeight = 0;
        /// <summary>
        /// height
        /// </summary>
        [System.ComponentModel.DefaultValue(0)]
        [DataMember]
        public int Height
        {
            get
            {
                return intHeight;
            }
            set
            {
                intHeight = value;
            }
        }


        private int intPaddingLeft = int.MinValue;
        /// <summary>
        /// padding left
        /// </summary>
        [System.ComponentModel.DefaultValue(int.MinValue)]
        [DataMember]
        public int PaddingLeft
        {
            get
            {
                return intPaddingLeft;
            }
            set
            {
                intPaddingLeft = value;
            }
        }

        private int intPaddingTop = int.MinValue;
        /// <summary>
        /// top padding
        /// </summary>
        [System.ComponentModel.DefaultValue(int.MinValue)]
        [DataMember]
        public int PaddingTop
        {
            get
            {
                return intPaddingTop;
            }
            set
            {
                intPaddingTop = value;
            }
        }

        

        private int intPaddingRight = int.MinValue;
        /// <summary>
        /// right padding
        /// </summary>
        [System.ComponentModel.DefaultValue(int.MinValue)]
        [DataMember]
        public int PaddingRight
        {
            get
            {
                return intPaddingRight;
            }
            set
            {
                intPaddingRight = value;
            }
        }

        private int intPaddingBottom = int.MinValue;
        /// <summary>
        /// bottom padding
        /// </summary>
        [System.ComponentModel.DefaultValue(int.MinValue)]
        [DataMember]
        public int PaddingBottom
        {
            get
            {
                return intPaddingBottom;
            }
            set
            {
                intPaddingBottom = value;
            }
        }

        private int intWidth = 0;
        /// <summary>
        /// width
        /// </summary>
        [DefaultValue( 0 )]
        [DataMember]
        public int Width
        {
            get
            {
                return intWidth; 
            }
            set
            {
                intWidth = value; 
            }
        }

        public override string ToString()
        {
            return "Row " + intRowIndex;
        }

    }
}
