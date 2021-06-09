using EasyMessageDemo.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyMessageDemo
{
    public class MessageSend
    {

        /// <summary>
        /// 
        /// </summary>
        public static async Task PostAsync(int i=1,string name="")
        {
            using (var client = new HttpClient())
            {
                var data = new MessageSendDto
                {
                    secret = MessageConfig.SECRET_KEY,
                    app_key = MessageConfig.GROUPAPPKEY_DRINK,
                    //template_id = MessageConfig.GROUPAPPKEY_DRINK_TEST,
                    template_id = MessageConfig.TEMPLATID_TODO,
                    data= new Data 
                    {
                        first = new DataDto { value = $"喝水提醒[{1}]" },
                        keyword1 = new DataDto { value = $"{DateTime.Now.Ticks}" },
                        keyword2 = new DataDto { value = "喝水", color = "#FF0000" },
                        keyword3 = new DataDto { value = "Marvin", color = "#FF0000" },
                        keyword4 = new DataDto { value = $"{name}，你已经两个小时没有喝水了", color = "#FF0000" },
                        keyword5 = new DataDto { value = $"{DateTime.Now}" },
                        remark = new DataDto { value = "快去喝水吧", color = "#FF0000" }
                    }

                };
                var body = JsonConvert.SerializeObject(data);
                var content = new StringContent(body);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var result = await client.PostAsync(MessageConfig.URL_SEND, content);

                Console.WriteLine(JsonConvert.SerializeObject(result));
            };
        }

    }
}
