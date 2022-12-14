using System;
using System.Web;

namespace IAA_Lab1
{
    public class IISHandler4 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var x = Convert.ToInt32(context.Request.QueryString.Get("X")) == 0 
                ? Convert.ToInt32(context.Request.Form.Get("X")) 
                : Convert.ToInt32(context.Request.QueryString.Get("X"));

            var y = Convert.ToInt32(context.Request.QueryString.Get("Y")) == 0 
                ? Convert.ToInt32(context.Request.Form.Get("Y"))
                : Convert.ToInt32(context.Request.QueryString.Get("Y"));

            var sum = x + y;
            var res = context.Response;
            res.ContentType = "text/plain";
            res.Write(sum);
        }

        #endregion
    }
}
