﻿using LBPL.PlugIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------
//   服务资源池接口
// 
//   author：林滨
//------------------------------------------------

namespace LBPL.PlugIn.Integration.Interface
{
   public interface IJobLibray
    {
      List<QuartzJobsCollection> GetJobList();
    }
}
