using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Demo2();

        }
        
        private async Task Demo1()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://httpbin.org/get", HttpCompletionOption.ResponseHeadersRead);

                response.EnsureSuccessStatusCode();

                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                       
                        using (var reader = new JsonTextReader(streamReader))
                        {
                            while (await reader.ReadAsync())
                            {
                                if (reader.Value != null)
                                {
                                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                                }
                                else
                                {
                                    Console.WriteLine("Token: {0}", reader.TokenType);
                                }
                            }
                        }
                    }
                }


            }
        }

        private async Task Demo2() 
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://httpbin.org/get", HttpCompletionOption.ResponseHeadersRead);

                response.EnsureSuccessStatusCode();

                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                        var contents = await streamReader.ReadToEndAsync();
                        Console.WriteLine(contents);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
