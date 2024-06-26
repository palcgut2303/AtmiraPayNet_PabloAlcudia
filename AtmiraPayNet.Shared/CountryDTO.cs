﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared
{
    public class CountryInfo
    {
        public class NameInfo
        {
            public string common { get; set; }
            public string official { get; set; }
        }

        public class CurrencyInfo
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public NameInfo name { get; set; }
        public string cca2 { get; set; }
        public Dictionary<string, CurrencyInfo> currencies { get; set; }
    }

    public class Rootobject
    {
        public CountryDTO[] Property1 { get; set; }
    }

    public class CountryDTO
    {
        public Name name { get; set; }
        public string cca2 { get; set; }
        public Currencies currencies { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Nativename nativeName { get; set; }
    }

    public class Nativename
    {
        public Ron ron { get; set; }
        public Eng eng { get; set; }
        public Fra fra { get; set; }
        public Nau nau { get; set; }
        public Por por { get; set; }
        public Spa spa { get; set; }
        public Sqi sqi { get; set; }
        public Niu niu { get; set; }
        public Pau pau { get; set; }
        public Ara ara { get; set; }
        public Som som { get; set; }
        public Msa msa { get; set; }
        public Mlg mlg { get; set; }
        public Ber ber { get; set; }
        public Mey mey { get; set; }
        public Ell ell { get; set; }
        public Tur tur { get; set; }
        public Gle gle { get; set; }
        public Grn grn { get; set; }
        public Sin sin { get; set; }
        public Tam tam { get; set; }
        public Afr afr { get; set; }
        public Nbl nbl { get; set; }
        public Nso nso { get; set; }
        public Sot sot { get; set; }
        public Ssw ssw { get; set; }
        public Tsn tsn { get; set; }
        public Tso tso { get; set; }
        public Ven ven { get; set; }
        public Xho xho { get; set; }
        public Zul zul { get; set; }
        public Hrv hrv { get; set; }
        public Cal cal { get; set; }
        public Cha cha { get; set; }
        public Kin kin { get; set; }
        public Srp srp { get; set; }
        public Tvl tvl { get; set; }
        public Nep nep { get; set; }
        public Bar bar { get; set; }
        public Nfr nfr { get; set; }
        public Sag sag { get; set; }
        public Fij fij { get; set; }
        public Hif hif { get; set; }
        public Nno nno { get; set; }
        public Nob nob { get; set; }
        public Smi smi { get; set; }
        public Lav lav { get; set; }
        public Kaz kaz { get; set; }
        public Rus rus { get; set; }
        public Swe swe { get; set; }
        public Tuk tuk { get; set; }
        public Bul bul { get; set; }
        public Smo smo { get; set; }
        public Tkl tkl { get; set; }
        public Dzo dzo { get; set; }
        public Aze aze { get; set; }
        public Swa swa { get; set; }
        public Mlt mlt { get; set; }
        public Ces ces { get; set; }
        public Slk slk { get; set; }
        public Nld nld { get; set; }
        public Pap pap { get; set; }
        public Uzb uzb { get; set; }
        public Zho zho { get; set; }
        public Mkd mkd { get; set; }
        public Deu deu { get; set; }
        public Ukr ukr { get; set; }
        public Fin fin { get; set; }
        public Bos bos { get; set; }
        public Fas fas { get; set; }
        public Tir tir { get; set; }
        public Lit lit { get; set; }
        public Pov pov { get; set; }
        public Fil fil { get; set; }
        public Bis bis { get; set; }
        public Aym aym { get; set; }
        public Que que { get; set; }
        public Khm khm { get; set; }
        public Bwg bwg { get; set; }
        public Kck kck { get; set; }
        public Khi khi { get; set; }
        public Ndc ndc { get; set; }
        public Nde nde { get; set; }
        public Nya nya { get; set; }
        public Sna sna { get; set; }
        public Toi toi { get; set; }
        public Zib zib { get; set; }
        public Nrf nrf { get; set; }
        public Kir kir { get; set; }
        public Hye hye { get; set; }
        public Cnr cnr { get; set; }
        public Kal kal { get; set; }
        public Hmo hmo { get; set; }
        public Tpi tpi { get; set; }
        public Hin hin { get; set; }
        public Mon mon { get; set; }
        public Mya mya { get; set; }
        public Kor kor { get; set; }
        public Nor nor { get; set; }
        public Bel bel { get; set; }
        public Pol pol { get; set; }
        public Gsw gsw { get; set; }
        public Ita ita { get; set; }
        public Roh roh { get; set; }
        public Kon kon { get; set; }
        public Lin lin { get; set; }
        public Dan dan { get; set; }
        public Ltz ltz { get; set; }
        public Fao fao { get; set; }
        public Slv slv { get; set; }
        public Tha tha { get; set; }
        public Ton ton { get; set; }
        public Lat lat { get; set; }
        public Run run { get; set; }
        public Mah mah { get; set; }
        public Glv glv { get; set; }
        public Hat hat { get; set; }
        public Prs prs { get; set; }
        public Pus pus { get; set; }
        public Heb heb { get; set; }
        public Pih pih { get; set; }
        public Rar rar { get; set; }
        public Lao lao { get; set; }
        public Gil gil { get; set; }
        public Jam jam { get; set; }
        public Cat cat { get; set; }
        public Crs crs { get; set; }
        public Urd urd { get; set; }
        public Amh amh { get; set; }
        public Ben ben { get; set; }
        public Mri mri { get; set; }
        public Nzs nzs { get; set; }
        public Zdj zdj { get; set; }
        public Bjz bjz { get; set; }
        public Hun hun { get; set; }
        public Isl isl { get; set; }
        public Tgk tgk { get; set; }
        public Her her { get; set; }
        public Hgm hgm { get; set; }
        public Kwn kwn { get; set; }
        public Loz loz { get; set; }
        public Ndo ndo { get; set; }
        public Tet tet { get; set; }
        public Mfe mfe { get; set; }
        public Div div { get; set; }
        public Ind ind { get; set; }
        public Lua lua { get; set; }
        public Est est { get; set; }
        public Vie vie { get; set; }
        public Kat kat { get; set; }
        public Arc arc { get; set; }
        public Ckb ckb { get; set; }
        public Jpn jpn { get; set; }
    }

    public class Ron
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Eng
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nau
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sqi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Niu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pau
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ara
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Som
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Msa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mlg
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ber
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mey
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ell
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tur
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gle
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Grn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tam
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Afr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nbl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nso
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sot
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ssw
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tsn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tso
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ven
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Xho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zul
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hrv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cal
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cha
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Srp
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tvl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nep
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bar
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nfr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sag
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fij
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hif
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nno
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nob
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Smi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lav
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kaz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tuk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bul
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Smo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tkl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Dzo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Aze
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mlt
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ces
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nld
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pap
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Uzb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mkd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Deu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ukr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bos
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fas
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tir
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lit
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pov
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fil
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bis
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Aym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Que
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Khm
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bwg
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kck
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Khi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ndc
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nde
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nya
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sna
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Toi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zib
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nrf
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kir
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hye
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cnr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kal
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hmo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tpi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mon
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mya
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bel
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pol
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gsw
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ita
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Roh
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kon
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Dan
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ltz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fao
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tha
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ton
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Run
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mah
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Glv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Prs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Heb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pih
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rar
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lao
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gil
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jam
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Crs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Urd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Amh
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ben
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mri
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nzs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zdj
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bjz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hun
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Isl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tgk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Her
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hgm
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kwn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Loz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ndo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tet
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mfe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Div
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ind
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lua
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Est
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Vie
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Arc
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ckb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jpn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Currencies
    {
        public MDL MDL { get; set; }
        public USD USD { get; set; }
        public EUR EUR { get; set; }
        public AUD AUD { get; set; }
        public MZN MZN { get; set; }
        public BRL BRL { get; set; }
        public CVE CVE { get; set; }
        public XAF XAF { get; set; }
        public ALL ALL { get; set; }
        public NZD NZD { get; set; }
        public NGN NGN { get; set; }
        public GMD GMD { get; set; }
        public SOS SOS { get; set; }
        public YER YER { get; set; }
        public MYR MYR { get; set; }
        public XCD XCD { get; set; }
        public GBP GBP { get; set; }
        public MGA MGA { get; set; }
        public DZD DZD { get; set; }
        public MAD MAD { get; set; }
        public MRU MRU { get; set; }
        public PYG PYG { get; set; }
        public LKR LKR { get; set; }
        public ZAR ZAR { get; set; }
        public KWD KWD { get; set; }
        public SLL SLL { get; set; }
        public RWF RWF { get; set; }
        public SYP SYP { get; set; }
        public HNL HNL { get; set; }
        public JOD JOD { get; set; }
        public TVD TVD { get; set; }
        public NPR NPR { get; set; }
        public LRD LRD { get; set; }
        public GGP GGP { get; set; }
        public DJF DJF { get; set; }
        public FJD FJD { get; set; }
        public NOK NOK { get; set; }
        public FKP FKP { get; set; }
        public KZT KZT { get; set; }
        public TMT TMT { get; set; }
        public BGN BGN { get; set; }
        public XPF XPF { get; set; }
        public BBD BBD { get; set; }
        public STN STN { get; set; }
        public BND BND { get; set; }
        public SGD SGD { get; set; }
        public BTN BTN { get; set; }
        public INR INR { get; set; }
        public ARS ARS { get; set; }
        public AZN AZN { get; set; }
        public MXN MXN { get; set; }
        public GTQ GTQ { get; set; }
        public KES KES { get; set; }
        public CZK CZK { get; set; }
        public GIP GIP { get; set; }
        public AWG AWG { get; set; }
        public AED AED { get; set; }
        public SSP SSP { get; set; }
        public XOF XOF { get; set; }
        public SHP SHP { get; set; }
        public BWP BWP { get; set; }
        public UZS UZS { get; set; }
        public TND TND { get; set; }
        public HKD HKD { get; set; }
        public MKD1 MKD { get; set; }
        public SRD SRD { get; set; }
        public SBD SBD { get; set; }
        public UAH UAH { get; set; }
        public BAM BAM { get; set; }
        public IRR IRR { get; set; }
        public CUC CUC { get; set; }
        public CUP CUP { get; set; }
        public ERN ERN { get; set; }
        public TRY TRY { get; set; }
        public PHP PHP { get; set; }
        public VUV VUV { get; set; }
        public BOB BOB { get; set; }
        public RON1 RON { get; set; }
        public KHR KHR { get; set; }
        public ZWL ZWL { get; set; }
        public JEP JEP { get; set; }
        public KGS KGS { get; set; }
        public GYD GYD { get; set; }
        public AMD AMD { get; set; }
        public LBP LBP { get; set; }
        public DKK DKK { get; set; }
        public PGK PGK { get; set; }
        public ZMW ZMW { get; set; }
        public TTD TTD { get; set; }
        public PEN PEN { get; set; }
        public SEK SEK { get; set; }
        public SDG SDG { get; set; }
        public OMR OMR { get; set; }
        public TWD TWD { get; set; }
        public MNT MNT { get; set; }
        public TZS TZS { get; set; }
        public CAD CAD { get; set; }
        public CRC CRC { get; set; }
        public CNY CNY { get; set; }
        public COP COP { get; set; }
        public MMK MMK { get; set; }
        public RUB RUB { get; set; }
        public KPW KPW { get; set; }
        public KYD KYD { get; set; }
        public BYN BYN { get; set; }
        public SZL SZL { get; set; }
        public PLN PLN { get; set; }
        public CHF CHF { get; set; }
        public VES VES { get; set; }
        public PAB PAB { get; set; }
        public WST WST { get; set; }
        public FOK FOK { get; set; }
        public THB THB { get; set; }
        public BSD BSD { get; set; }
        public TOP TOP { get; set; }
        public BIF BIF { get; set; }
        public BHD BHD { get; set; }
        public IMP IMP { get; set; }
        public HTG HTG { get; set; }
        public AFN AFN { get; set; }
        public ILS ILS { get; set; }
        public LYD LYD { get; set; }
        public UYU UYU { get; set; }
        public NIO NIO { get; set; }
        public CKD CKD { get; set; }
        public LAK LAK { get; set; }
        public KID KID { get; set; }
        public ANG ANG { get; set; }
        public JMD JMD { get; set; }
        public EGP EGP { get; set; }
        public CLP CLP { get; set; }
        public LSL LSL { get; set; }
        public GHS GHS { get; set; }
        public SCR SCR { get; set; }
        public AOA AOA { get; set; }
        public BMD BMD { get; set; }
        public PKR PKR { get; set; }
        public SAR SAR { get; set; }
        public KRW KRW { get; set; }
        public ETB ETB { get; set; }
        public BDT BDT { get; set; }
        public KMF KMF { get; set; }
        public BZD BZD { get; set; }
        public UGX UGX { get; set; }
        public HUF HUF { get; set; }
        public ISK ISK { get; set; }
        public TJS TJS { get; set; }
        public NAD NAD { get; set; }
        public RSD RSD { get; set; }
        public MUR MUR { get; set; }
        public MOP MOP { get; set; }
        public MVR MVR { get; set; }
        public IDR IDR { get; set; }
        public CDF CDF { get; set; }
        public VND VND { get; set; }
        public GNF GNF { get; set; }
        public GEL GEL { get; set; }
        public MWK MWK { get; set; }
        public IQD IQD { get; set; }
        public JPY JPY { get; set; }
        public DOP DOP { get; set; }
        public QAR QAR { get; set; }
    }

    public class MDL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class USD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class EUR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AUD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MZN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BRL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CVE
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class XAF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ALL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NZD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NGN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SOS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class YER
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MYR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class XCD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GBP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MGA
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DZD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MAD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MRU
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PYG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LKR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ZAR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KWD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SLL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class RWF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SYP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HNL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class JOD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TVD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NPR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LRD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GGP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DJF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class FJD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NOK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class FKP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KZT
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TMT
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BGN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class XPF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BBD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class STN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BND
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SGD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BTN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class INR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ARS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AZN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MXN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GTQ
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KES
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CZK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GIP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AWG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AED
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SSP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class XOF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SHP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BWP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class UZS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TND
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HKD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MKD1
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SRD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SBD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class UAH
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BAM
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class IRR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CUC
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CUP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ERN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TRY
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PHP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class VUV
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BOB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class RON1
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KHR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ZWL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class JEP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KGS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GYD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LBP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DKK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PGK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ZMW
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TTD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PEN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SEK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SDG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class OMR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TWD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MNT
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TZS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CAD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CRC
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CNY
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class COP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MMK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class RUB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KPW
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KYD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BYN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SZL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PLN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CHF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class VES
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PAB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class WST
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class FOK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class THB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BSD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TOP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BIF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BHD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class IMP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HTG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AFN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ILS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LYD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class UYU
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NIO
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CKD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LAK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KID
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ANG
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class JMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class EGP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CLP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class LSL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GHS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SCR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class AOA
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BMD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PKR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class SAR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KRW
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ETB
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BDT
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class KMF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class BZD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class UGX
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class HUF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class ISK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class TJS
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class NAD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class RSD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MUR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MOP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MVR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class IDR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CDF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class VND
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GNF
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class GEL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class MWK
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class IQD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class JPY
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class DOP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class QAR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }



}
