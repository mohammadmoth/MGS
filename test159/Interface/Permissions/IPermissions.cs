﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServerGame.Interface.Permissions
{
    interface IPermissions
    {



        bool CanAddNewUser { get; }

        bool CanAddNewRoom { get;  }


    }
}
