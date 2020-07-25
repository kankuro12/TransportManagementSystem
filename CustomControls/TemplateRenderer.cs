using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xipton.Razor;

namespace CustomControls
{
    public class Convertables
    {
        public string name { get; set; }
        public string value { get; set; }
        public Convertables(string n, string v)
        {
            this.name = n;
            this.value = v;
        }
    }
    public class TemplateRenderer
    {
        public static RazorMachine RazorMachine;

        public static string RenderHtml(string path, List<Convertables> convertables = null, object ModelValues = null)
        {
            var b = File.ReadAllText(path);
            if (convertables != null)
            {
                foreach (var item in convertables)
                {
                    b = b.Replace("#" + item.name + "#", item.value);
                }
            }
            if (RazorMachine == null)
            {
                RazorMachine = new RazorMachine();
            }

            var result = RazorMachine.Execute(b, ModelValues);
            return result.Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="convertables"></param>
        /// <param name="ModelValues"></param>
        /// <returns>Url of new generated Html File</returns>
        public static string Render(string filename, List<Convertables> convertables = null, object ModelValues = null)
        {

            var minipath = @"Templates/" + filename + ".cshtml";
            var b = RenderHtml(minipath, convertables, ModelValues);
            if (!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }
            var p = "Temp/url.html";
            File.WriteAllText(p, b);
            string curDir = Directory.GetCurrentDirectory();
            return String.Format("file:///{0}/{1}", curDir, p);
        }
        public static string Render(string filename, Convertables convertables = null, object ModelValues = null)
        {

            var minipath = @"Templates/" + filename + ".cshtml";
            var cs = new List<Convertables>() { convertables };
            var b = RenderHtml(minipath, cs, ModelValues);
            if (!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }
            var p = "Temp/url.html";
            File.WriteAllText(p, b);
            string curDir = Directory.GetCurrentDirectory();
            return String.Format("file:///{0}/{1}", curDir, p);
        }
    }
}
