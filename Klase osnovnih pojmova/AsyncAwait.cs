﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // Ova klasa će mi služit za vježbanje async i await keyworda
    class AsyncAwait
    {
        private readonly string _url;
        private Stopwatch stoperica;
        public AsyncAwait(string url) // Koristio sam msdn.microsoft.com za test
        {
            _url = url;
        }
        // Ova metoda vraća html element stranice čiju adresu proslijedimo u contructor-u
        public string GetHtml()
        {
            var webClient = new WebClient();
            return webClient.DownloadString(_url);
        }
        // Ova metoda asinhrono vraća html element stranice čiju adresu proslijedimo u constructor-u
        public async Task<string> GetHtmlAsync()
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(_url);
        }
        // Ova metoda služi da mjerimo vrijeme između poziva GetHtmlAsync i da nam ispiše prvih 10 slova html elementa
        public async void TimeOfExecutionAync() // Vrijeme izvršavanja 0.5 sec
        {
            stoperica = new Stopwatch();
            var getHtmlTask = GetHtmlAsync();            
            stoperica.Stop();
            Console.WriteLine(stoperica.Elapsed());
            var html = await getHtmlTask;
            Console.WriteLine(html.Substring(0,10));
        }
        // Ova meotda služi da mjerimo vrijeme između poziva GetHtml i da na ispiše prvih 10 slova html elementa
        public void TimeOfExecution() // Vrijeme izvršavanja 2.5 sec
        {
            var stoperica = new Stopwatch();
            var html = GetHtml();
            stoperica.Stop();
            Console.WriteLine(stoperica.Elapsed());
            Console.WriteLine(html.Substring(0,15));
        }
    }
}
