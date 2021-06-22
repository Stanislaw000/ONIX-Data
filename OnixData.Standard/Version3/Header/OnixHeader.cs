﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Version3.Header
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OnixHeader
    {
        public OnixHeader()
        {
            Sender       = new OnixHeaderSender();
            Addressee    = new OnixHeaderAddressee();
            SentDateTime = DefaultLanguageOfText = DefaultCurrencyCode = DefaultPriceType = "";
        }

        private OnixHeaderSender    senderField;
        private OnixHeaderAddressee addresseeField;
        private string              sentDateTimeField;
        private string              defLangOfText;
        private string              defPriceType;
        private string              defCurrencyCode;

        #region Reference Tags

        /// <remarks/>
        public OnixHeaderSender Sender
        {
            get { return this.senderField; }
            set { this.senderField = value; }
        }

        /// <remarks/>
        public OnixHeaderAddressee Addressee
        {
            get { return this.addresseeField; }
            set { this.addresseeField = value; }
        }

        /// <remarks/>
        public string SentDateTime
        {
            get { return this.sentDateTimeField; }
            set { this.sentDateTimeField = value; }
        }

        /// <remarks/>
        public string DefaultLanguageOfText
        {
            get { return this.defLangOfText; }
            set { this.defLangOfText = value; }
        }

        /// <remarks/>
        public string DefaultPriceType
        {
            get { return this.defPriceType; }
            set { this.defPriceType = value; }
        }

        /// <remarks/>
        public string DefaultCurrencyCode
        {
            get { return this.defCurrencyCode; }
            set { this.defCurrencyCode = value; }
        }

        #endregion

        #region Short Tags

        /// <remarks/>
        public OnixHeaderSender sender
        {
            get { return Sender; }
            set { Sender = value; }
        }

        /// <remarks/>
        public OnixHeaderAddressee addressee
        {
            get { return Addressee; }
            set { Addressee = value; }
        }

        /// <remarks/>
        public string x307
        {
            get { return SentDateTime; }
            set { SentDateTime = value; }
        }

        /// <remarks/>
        public string m184
        {
            get { return DefaultLanguageOfText; }
            set { DefaultLanguageOfText = value; }
        }

        /// <remarks/>
        public string x310
        {
            get { return DefaultPriceType; }
            set { DefaultPriceType = value; }
        }

        /// <remarks/>
        public string m186
        {
            get { return DefaultCurrencyCode; }
            set { DefaultCurrencyCode = value; }
        }

        #endregion
    }
}
