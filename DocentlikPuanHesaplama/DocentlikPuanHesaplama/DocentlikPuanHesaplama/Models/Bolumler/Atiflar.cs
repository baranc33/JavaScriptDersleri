﻿namespace DocentlikPuanHesaplama.Models.Bolumler
{
    public class Atiflar : BaseEntity {
        public string BolumAdi { get; set; } = "5. Atıflar";
        public string ErrorMessage { get; set; } = "";
        public bool Error { get; set; } = false;
    }
}