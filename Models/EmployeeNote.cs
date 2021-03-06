﻿using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmployeeNote
    {
        public int EmployeeNoteId { get; set; }
        public int EmployeeId { get; set; }
        public string Note { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
