﻿using System;
using System.Collections.Generic;
using System.Text;
using NewLife.Data;

namespace NewLife.Remoting
{
    /// <summary>API控制器</summary>
    //[AllowAnonymous]
    public class ApiController
    {
        /// <summary>主机</summary>
        public IApiHost Host { get; set; }

        private String[] _all;
        /// <summary>获取所有接口</summary>
        /// <returns></returns>
        public String[] All()
        {
            // 加上10ms延迟来模拟业务损耗，测试消耗占95.63%。没加睡眠时，Json损耗占55.5%
            //System.Threading.Thread.Sleep(10);
            if (_all != null) return _all;

            var list = new List<String>();
            foreach (var item in Host.Manager.Services)
            {
                var act = item.Value;

                var mi = act.Method;

                var sb = new StringBuilder();
                sb.AppendFormat("{0} {1}", mi.ReturnType.Name, act.Name);
                sb.Append("(");

                var pis = mi.GetParameters();
                for (var i = 0; i < pis.Length; i++)
                {
                    if (i > 0) sb.Append(", ");
                    sb.AppendFormat("{0} {1}", pis[i].ParameterType.Name, pis[i].Name);
                }

                sb.Append(")");

                var des = mi.GetDescription();
                if (!des.IsNullOrEmpty()) sb.AppendFormat(" {0}", des);

                list.Add(sb.ToString());
            }

            return _all = list.ToArray();
        }

        /// <summary>获取指定种类的环境信息</summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        public String Info(String kind)
        {
            switch ((kind + "").ToLower())
            {
                case "machine": return Environment.MachineName;
                case "user": return Environment.UserName;
                case "ip": return NetHelper.MyIP() + "";
                case "time": return DateTime.Now.ToFullString();
                default:
                    return DateTime.Now.ToFullString();
            }
        }

#if DEBUG
        /// <summary>上传文件</summary>
        /// <param name="fileName"></param>
        /// <param name="fileData"></param>
        /// <returns></returns>
        public Packet Upload(String fileName, Packet fileData)
        {
            Log.XTrace.WriteLine("上传文件[{0}]，共{1:n0}字节", fileName, fileData.Total);

            return fileData;
        }
#endif
    }
}