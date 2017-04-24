﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.TaskManagement
{
    namespace Commands.Staff
    {
        public partial class AddOrUpdateStaffMemberCommand { }
        public partial class DeleteStaffMemberCommand { }
    }

    namespace Queries.Staff
    {
        partial class StaffStatusQuery  { }
    }

    namespace Events.Staff
    {
        partial class StaffStatusReport { }
    }
}