﻿using System.ComponentModel.DataAnnotations;

namespace Core.Models.Entities
{
    public class MuhendislikEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";





        #region Makaleler
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerAsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? MakalelerAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerAbasYazar { get; set; }
                public int MakalelerACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerBsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? MakalelerBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerBbasYazar { get; set; }
                public int MakalelerBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerCmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerCyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerCsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? MakalelerChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? MakalelerCbasYazar { get; set; }
                public int MakalelerCCount { get; set; } = 0;




        #endregion



        #region Yayin
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAbasYazar { get; set; } = default!;
                public int YayinACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinByazarsayisi { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBbasYazar { get; set; } = default!;
                public int YayinBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCbildiri { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinChatirlatici { get; set; }
                public int YayinCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDbildiri { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? YayinDhatirlatici { get; set; }
                public int YayinDCount { get; set; } = 0;



        #endregion




        #region Kitap
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapAhatirlatici { get; set; }
                public int KitapACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapBhatirlatici { get; set; }
                public int KitapBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapChatirlatici { get; set; }
                public int KitapCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? KitapDhatirlatici { get; set; }
                public int KitapDCount { get; set; } = 0;

        #endregion


        #region Patent
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAyazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? PatentAhatirlatici { get; set; }
                public int PatentACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentByazarsayisi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? PatentBhatirlatici { get; set; }
                public int PatentBCount { get; set; } = 0;


        #endregion



        #region Atiflar
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarAhatirlatici { get; set; }
                public int AtiflarACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarBhatirlatici { get; set; }
                public int AtiflarBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCatif { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? AtiflarChatirlatici { get; set; }
                public int AtiflarCCount { get; set; } = 0;
        #endregion




        #region Danismanlik
        // altıncı kısım verileri
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAsayi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? DanismanlikAhatirlatici { get; set; }
                public int DanismanlikACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBsayi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? DanismanlikBhatirlatici { get; set; }
                public int DanismanlikBCount { get; set; } = 0;

        #endregion



        #region Arastirma
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaAhatirlatici { get; set; }
                public int ArastirmaACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaBhatirlatici { get; set; }
                public int ArastirmaBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaChatirlatici { get; set; }
                public int ArastirmaCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDproje { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ArastirmaDhatirlatici { get; set; }
                public int ArastirmaDCount { get; set; } = 0;
        #endregion



        #region Toplanti
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ToplantiAhatirlatici { get; set; }
                public int ToplantiACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBsirasi { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? ToplantiBhatirlatici { get; set; }
                public int ToplantiBCount { get; set; } = 0;

        #endregion




        #region Egitim
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAders { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? EgitimAhatirlatici { get; set; }
                public int EgitimACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBders { get; set; }
                [MaxLength(100, ErrorMessage = "En Fazla 100 karakter olabilir")] public string? EgitimBhatirlatici { get; set; }
                public int EgitimBCount { get; set; } = 0;

                 public bool Gorev2yil { get; set; } = false;
        #endregion


    }
}
