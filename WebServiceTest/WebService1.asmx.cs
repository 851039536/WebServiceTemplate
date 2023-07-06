using System.Media;
using System.Web.Services;

namespace WebServiceTemplate
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : WebService
    {
        private readonly SoundPlayer _player = new SoundPlayer();
        [WebMethod]
        public string PlayMusic()
        {
            _player.SoundLocation = @"D:\config\x0pbk-swz4q.wav";
            _player.Load();
            _player.Play();
            return "播放音乐中";
        }

        [WebMethod]
        public string StopMusic()
        {
            _player.Stop();
            _player.Dispose();
            return "音乐关闭";
        }
        [WebMethod(Description = "测试")]
        public string Test()
        {
            return "正常";
        }
    }
}
