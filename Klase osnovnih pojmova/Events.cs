﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice
{
    //
    // Ovdje vježbam evente sa EventHandler-om
    //
    
    // Ova klasa nam služi da imamo neki objekat koji možemo slati preko eventa
    public class Video
    {
        private string _title;
        public Video(string title)
        {
            _title = title;
        }
        public string GetTitle()
        {
            return _title;
        }
    }
    // Ova klasa je publisher eventova. Ona poziva metode koje sadrži event VideoEncoded.
    //Event je u principu samo delegat kao polje na klasi, koji kao parametre prima object i EventArgs.
    // Možemo sami definisati delegat(object source, EventArgs e) ili možemo koristiti već definisane EventArgs i EventArgs<T>    
    public class VideoEncoder
    {
        // Ova metoda poziva metodu koja poziva event, onVideoEncoded.
        public void Encode(Video video)
        {
            Console.WriteLine($"Video {video.GetTitle()} has been encoded");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        // Ovo je event. EventHandler je ustvari samo delegat, što je samo ustvari kolekcija pointera na metode
        // Deklaracija EventHandler-a izgleda ovako:  public delegate void EventHandle(object sender, EventArgs e);
        // EventHandler može biti i generički kao što je ispod deklarisan.
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        // Ova metoda poziva event. Prvo provjerava ima li ijedan subsrciber (metoda dodijeljena delegatu VideoEncoded) i ako ima poziva VideoEncoded
        // U parametre šalje this, trenutni objekat koji pizva VideoEncoded (VideoEncoder), i VideoEventArgs inicijaliziran sa Video objektom
        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs(video));
        }

    }
    // Ovo je klasa koja ima subscriber metodu
    // Inicijaliziramo jedan objekat klase MailService i onda dodijelimo metodu MailService.OnVideoEncoded, objektu VideoEncoder property-u VideoEncoded
    // videoEncoderObjekat.VideoEncoded += mailServiceObjekat.OnVideoEncoded;
    // Kada publisher (VideoEncoder) objekat pozove svoju OnVideoEncoded metodu pozvat će se OnVideoEncoded metoda subscribera (MailService)
    public class MailService
    {
        public void OnVideoEncoded(object soure, VideoEventArgs e)
        {
            Console.WriteLine($"Mail has been sent {e.Video.GetTitle()}");
            Console.WriteLine($"e: {e.ToString()}");
        }
    }
    // Možemo i sami derive-ati svoju EventArgs, od EventArgs-a, klasu i dodati joj polja koja želimo, kao što se može vidjet ispod
    // U ovom slučaju smo dodali property Video i koristimo ga da prikažemo titlove video objekta
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
        public VideoEventArgs(Video video)
        {
            Video = video;
        }
    }
}
