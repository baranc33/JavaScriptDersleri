﻿using System.ComponentModel.DataAnnotations;

namespace Core.Models.Entities
{
    public class SaglikEntity
    {
        public int Id { get; set; }
        public string MyUserId { get; set; } = "";
        public MyUser MyUser { get; set; }=new MyUser();


        #region UluslarArasi
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiAbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int UluslarArasiACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiBbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int UluslarArasiBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UluslarArasiCbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int UluslarArasiCCount { get; set; } = 0;




        #endregion


        #region Ulusal
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? UlusalAbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int UlusalACount { get; set; } = 0;


        #endregion

        #region Yayin
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinAbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int YayinACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBmakalesayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinByazarsayisi { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinBbasYazar { get; set; } = default!;
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int YayinBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCbildiri { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinCyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int YayinCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDbildiri { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? YayinDhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int YayinDCount { get; set; } = 0;



        #endregion




        #region Kitap
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int KitapACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int KitapBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCkitap { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapCyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int KitapCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDbolumSayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? KitapDhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int KitapDCount { get; set; } = 0;

        #endregion


        #region Patent
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int PatentACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? PatentBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int PatentBCount { get; set; } = 0;


        #endregion



        #region Atiflar
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAatif { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int AtiflarACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBatif { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int AtiflarBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarCatif { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? AtiflarChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int AtiflarCCount { get; set; } = 0;
        #endregion




        #region Danismanlik
        // altıncı kısım verileri
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int DanismanlikACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBseviye { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? DanismanlikBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int DanismanlikBCount { get; set; } = 0;

        #endregion



        #region Arastirma
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAproje { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ArastirmaACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBproje { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ArastirmaBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaCproje { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaChatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ArastirmaCCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDproje { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ArastirmaDhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ArastirmaDCount { get; set; } = 0;
        #endregion



        #region Toplanti
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAyazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ToplantiACount { get; set; } = 0;


                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBsayi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiByazarsayisi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBsirasi { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? ToplantiBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int ToplantiBCount { get; set; } = 0;

        #endregion




        #region Egitim
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAders { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimAhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int EgitimACount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBdoktora { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBders { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public string? EgitimBhatirlatici { get; set; }
                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public int EgitimBCount { get; set; } = 0;

                [MaxLength(20, ErrorMessage = "En Fazla 20 karakter olabilir")] public bool Gorev2yil { get; set; } = false;
        #endregion


    }
}
