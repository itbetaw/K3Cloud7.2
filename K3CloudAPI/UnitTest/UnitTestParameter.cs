using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.K3CLoudAPI
{
    public class UnitTestParameter : BaseTestParameter
    {
        public override string URL
        {
            get
            {
                //return "https://dllhcy.ik3cloud.com/K3Cloud/";
                //return "http://47.112.127.88:8089/K3Cloud/";
                return "http://192.168.1.115/K3Cloud/";
                //return "http://kangyin.ik3cloud.com/K3Cloud/";
            }
        }

        public override string DBId
        {
            get
            {
                //return "20180403110600";
                //return "5d0ca54935456f";
                //return "20160907115235";
                return "5d049dadd3f5a4";
            }
        }

        public override string UserName
        {
            get
            {
                //return "陈浩圣";
                return "Administrator";
            }
        }

        public override string Password
        {
            get
            {
                //return "Lhcy@2018";
                //return "19890909a.";
                return "888888";
            }
        }

        public override string AppId
        {
            get
            {
                return "http://qzmslm888.gnway.cc/K3API";
            }
        }

        public override string AppSecret
        {
            get { throw new NotImplementedException(); }
        }

    }
}
