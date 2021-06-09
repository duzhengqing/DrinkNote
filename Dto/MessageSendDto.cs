using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMessageDemo.Dto
{
    public class MessageSendDto
    {

        /// <summary>
        /// comment
        /// </summary>
        public string secret { get; set; }

        /// <summary>
        /// comment
        /// </summary>
        public string app_key { get; set; }


        /// <summary>
        /// comment
        /// </summary>
        public string template_id { get; set; }


        /// <summary>
        /// comment
        /// </summary>
        public string url { get; set; } = "";


        /// <summary>
        /// comment
        /// </summary>
        public Data data { get; set; }


    }

    /// <summary>
    /// comment
    /// </summary>
    public class Data
    {

        /// <summary>
        /// 
        /// </summary>
        public DataDto first { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto keyword1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto keyword2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto keyword3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto keyword4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto keyword5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DataDto remark { get; set; }
    }

    public class DataDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; } = "#173177";
    }

}
