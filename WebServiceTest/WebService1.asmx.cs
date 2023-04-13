using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Web;
using System.Web.Services;

namespace WebServiceTest
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SoundPlayer player = new SoundPlayer();
        [WebMethod]
        public string PlayMusic()
        {
            player.SoundLocation = @"D:\config\x0pbk-swz4q.wav";
            player.Load();
            player.Play();
            return "播放音乐中";
        }

        [WebMethod]
        public string StopMusic()
        {
            player.Stop();
            player.Dispose();
            return "音乐关闭";
        }
        [WebMethod(Description = "测试")]
        public string Test()
        {
            return "正常";
        }
    }
}
