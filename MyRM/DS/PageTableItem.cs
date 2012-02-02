﻿namespace MyRM.DS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TP;

    [System.Serializable()]
    class PageTableItem
    {
        #region Private Members

        // use one letter names to make serialization compact
        private int p;

        [NonSerialized]
        private bool isDirty;

        #endregion

        public PageTableItem()
        {
            this.IsDirty = false;
            this.PageIndex = -1;
        }
        
        public bool IsDirty
        {
            get
            {
                return isDirty;
            }
            set
            {
                isDirty = value;
            }
        }

        public int PageIndex
        {
            get
            {
                return p;
            }
            set
            {
                p = value;
            }
        }
    }
}