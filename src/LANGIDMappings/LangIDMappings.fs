module LANGIDMappings

open System

let internal langidPrimaryLanguage(langid: uint16): uint16 = 
    (langid &&& 0x3ffus)

let internal langidSubLanguage(langid: uint16): uint16 = 
    langid >>> 10

[<Literal>]
let private NeutralSubLanguage = 0x00us
[<Literal>] 
let private LangAfrikaans = 0x36us
[<Literal>] 
let private LangAlbanian = 0x1cus
[<Literal>] 
let private LangAlsatian = 0x84us
[<Literal>] 
let private LangAmharic = 0x5eus
[<Literal>] 
let private LangArabic = 0x01us
[<Literal>] 
let private LangArmenian = 0x2bus
[<Literal>] 
let private LangAssamese = 0x4dus
[<Literal>] 
let private LangAzeri = 0x2cus
[<Literal>] 
let private LangBangla = 0x45us
[<Literal>] 
let private LangBashkir = 0x6dus
[<Literal>] 
let private LangBasque = 0x2dus
[<Literal>] 
let private LangBelarusian = 0x23us
[<Literal>] 
let private LangBosnian = 0x1aus
[<Literal>] 
let private LangBreton = 0x7eus
[<Literal>] 
let private LangBulgarian = 0x02us
[<Literal>] 
let private LangCentralKurdish = 0x92us
[<Literal>] 
let private LangCherokee = 0x5cus
[<Literal>] 
let private LangCatalan = 0x03us
[<Literal>] 
let private LangChinese = 0x04us
[<Literal>] 
let private LangCorsican = 0x83us
[<Literal>] 
let private LangCroatian = 0x1aus
[<Literal>] 
let private LangCzech = 0x05us
[<Literal>] 
let private LangDanish = 0x06us
[<Literal>] 
let private LangDari = 0x8cus
[<Literal>] 
let private LangDivehi = 0x65us
[<Literal>] 
let private LangDutch = 0x13us
[<Literal>] 
let private LangEnglish = 0x09us
[<Literal>] 
let private LangEstonian = 0x25us
[<Literal>] 
let private LangFaroese = 0x38us
[<Literal>] 
let private LangFilipino = 0x64us
[<Literal>] 
let private LangFinnish = 0x0bus
[<Literal>] 
let private LangFrench = 0x0cus
[<Literal>] 
let private LangFrisian = 0x62us
[<Literal>] 
let private LangGalician = 0x56us
[<Literal>] 
let private LangGeorgian = 0x37us
[<Literal>] 
let private LangGerman = 0x07us
[<Literal>] 
let private LangGreek = 0x08us
[<Literal>] 
let private LangGreenlandic = 0x6fus
[<Literal>] 
let private LangGujarati = 0x47us
[<Literal>] 
let private LangHausa = 0x68us
[<Literal>] 
let private LangHawaiian = 0x75us
[<Literal>] 
let private LangHebrew = 0x0dus
[<Literal>] 
let private LangHindi = 0x39us
[<Literal>] 
let private LangHungarian = 0x0eus
[<Literal>] 
let private LangIcelandic = 0x0fus
[<Literal>] 
let private LangIgbo = 0x70us
[<Literal>] 
let private LangIndonesian = 0x21us
[<Literal>] 
let private LangInuktitut = 0x5dus
[<Literal>] 
let private LangIrish = 0x3cus
[<Literal>] 
let private LangXhosa = 0x34us
[<Literal>] 
let private LangZulu = 0x35us
[<Literal>] 
let private LangItalian = 0x10us
[<Literal>] 
let private LangJapanese = 0x11us
[<Literal>] 
let private LangKannada = 0x4bus
[<Literal>] 
let private LangKashmiri = 0x60us
[<Literal>] 
let private LangKazak = 0x3fus
[<Literal>] 
let private LangKhmer = 0x53us
[<Literal>] 
let private LangKiche = 0x86us
[<Literal>] 
let private LangKinyarwanda = 0x87us
[<Literal>] 
let private LangKonkani = 0x57us
[<Literal>] 
let private LangKorean = 0x12us
[<Literal>] 
let private LangKyrgyz = 0x40us
[<Literal>] 
let private LangLao = 0x54us
[<Literal>] 
let private LangLatvian = 0x26us
[<Literal>] 
let private LangLithuanian = 0x27us
[<Literal>] 
let private LangLowerSorbian = 0x2eus
[<Literal>] 
let private LangLuxembourgish = 0x6eus
[<Literal>] 
let private LangMacedonian = 0x2fus
[<Literal>] 
let private LangMalay = 0x3eus
[<Literal>] 
let private LangMalayalam = 0x4cus
[<Literal>] 
let private LangMaltese = 0x3aus
[<Literal>] 
let private LangManipuri = 0x58us
[<Literal>] 
let private LangMaori = 0x81us
[<Literal>] 
let private LangMapudungun = 0x7aus
[<Literal>] 
let private LangMarathi = 0x4eus
[<Literal>] 
let private LangMohawk = 0x7cus
[<Literal>] 
let private LangMongolian = 0x50us
[<Literal>] 
let private LangNepali = 0x61us
[<Literal>] 
let private LangNorwegian = 0x14us
[<Literal>] 
let private LangOccitan = 0x82us
// ***FIXME: check to see if mappings are set up
[<Literal>] 
let private LangOriya = 0x48us
[<Literal>] 
let private LangPashto = 0x63us
[<Literal>] 
let private LangPersian = 0x29us
[<Literal>] 
let private LangPolish = 0x15us
[<Literal>] 
let private LangPortuguese = 0x16us
[<Literal>] 
let private LangPular = 0x67us
[<Literal>] 
let private LangPunjabi = 0x46us
[<Literal>] 
let private LangQuechua = 0x6bus
[<Literal>] 
let private LangRomanian = 0x18us
[<Literal>] 
let private LangRomansh = 0x17us
[<Literal>] 
let private LangRussian = 0x19us
[<Literal>] 
let private LangSakha = 0x85us
[<Literal>] 
let private LangSami = 0x3bus
[<Literal>] 
let private LangSanskrit = 0x4fus
[<Literal>] 
let private LangSerbian = 0x1aus
[<Literal>] 
let private LangSotho = 0x6cus
[<Literal>] 
let private LangTswana = 0x32us
[<Literal>] 
let private LangSindhi = 0x59us
[<Literal>] 
let private LangSinhalese = 0x5bus
[<Literal>] 
let private LangSlovak = 0x1bus
[<Literal>] 
let private LangSlovenian = 0x24us
[<Literal>] 
let private LangSpanish = 0x0aus
[<Literal>] 
let private LangSwahili = 0x41us
[<Literal>] 
let private LangSwedish = 0x1dus
[<Literal>] 
let private LangSyriac = 0x5aus
[<Literal>] 
let private LangTajik = 0x28us
[<Literal>] 
let private LangTamazight = 0x5fus
[<Literal>] 
let private LangTamil = 0x49us
[<Literal>] 
let private LangTatar = 0x44us
[<Literal>] 
let private LangTelugu = 0x4aus
[<Literal>] 
let private LangThai = 0x1eus
[<Literal>] 
let private LangTibetan = 0x51us
[<Literal>] 
let private LangTigrinya = 0x73us
[<Literal>] 
let private LangTigrigna = 0x73us
[<Literal>] 
let private LangTurkish = 0x1fus
[<Literal>] 
let private LangTurkmen = 0x42us
[<Literal>] 
let private LangUkrainian = 0x22us
[<Literal>] 
let private LangUpperSorbian = 0x2eus
[<Literal>] 
let private LangUrdu = 0x20us
[<Literal>] 
let private LangUighur = 0x80us
[<Literal>] 
let private LangUzbek = 0x43us
[<Literal>] 
let private LangValencian = 0x03us
[<Literal>] 
let private LangVietnamese = 0x2aus
[<Literal>] 
let private LangWelsh = 0x52us
[<Literal>] 
let private LangWolof = 0x88us
[<Literal>] 
let private LangYi = 0x78us
[<Literal>] 
let private LangYoruba = 0x6aus

[<Literal>]
let private SublangNeutral = 0x00us    // language neutral
[<Literal>]
let private SublangDefault = 0x01us    // user default
[<Literal>]
let private SublangSysDefault = 0x02us    // system default
[<Literal>]
let private SublangCustomDefault = 0x03us    // default custom language/locale
[<Literal>]
let private SublangCustomUnspecified = 0x04us    // custom language/locale
[<Literal>]
let private SublangUICustomDefault = 0x05us    // Default custom MUI language/locale


[<Literal>]
let private SublangAfrikaansSouthAfrica = 0x01us    // Afrikaans (South Africa) 0x0436 af-ZA
[<Literal>]
let private SublangAlbanianAlbania = 0x01us    // Albanian (Albania) 0x041c sq-AL
[<Literal>]
let private SublangAlsatianFrance = 0x01us    // Alsatian (France) 0x0484
[<Literal>]
let private SublangAmharicEthiopia = 0x01us    // Amharic (Ethiopia) 0x045e
[<Literal>]
let private SublangArabicSaudiArabia = 0x01us    // Arabic (Saudi Arabia)
[<Literal>]
let private SublangArabicIraq = 0x02us    // Arabic (Iraq)
[<Literal>]
let private SublangArabicEgypt = 0x03us    // Arabic (Egypt)
[<Literal>]
let private SublangArabicLibya = 0x04us    // Arabic (Libya)
[<Literal>]
let private SublangArabicAlgeria = 0x05us    // Arabic (Algeria)
[<Literal>]
let private SublangArabicMorocco = 0x06us    // Arabic (Morocco)
[<Literal>]
let private SublangArabicTunisia = 0x07us    // Arabic (Tunisia)
[<Literal>]
let private SublangArabicOman = 0x08us    // Arabic (Oman)
[<Literal>]
let private SublangArabicYemen = 0x09us    // Arabic (Yemen)
[<Literal>]
let private SublangArabicSyria = 0x0aus    // Arabic (Syria)
[<Literal>]
let private SublangArabicJordan = 0x0bus    // Arabic (Jordan)
[<Literal>]
let private SublangArabicLebanon = 0x0cus    // Arabic (Lebanon)
[<Literal>]
let private SublangArabicKuwait = 0x0dus    // Arabic (Kuwait)
[<Literal>]
let private SublangArabicUAE = 0x0eus    // Arabic (U.A.E)
[<Literal>]
let private SublangArabicBahrain = 0x0fus    // Arabic (Bahrain)
[<Literal>]
let private SublangArabicQatar = 0x10us    // Arabic (Qatar)
[<Literal>]
let private SublangArmenianArmenia = 0x01us    // Armenian (Armenia) 0x042b hy-AM
[<Literal>]
let private SublangAssameseIndia = 0x01us    // Assamese (India) 0x044d
[<Literal>]
let private SublangAzeriLatin = 0x01us    // Azeri (Latin) - for Azerbaijani, SUBLANGAZERBAIJANIAZERBAIJANLATIN preferred
[<Literal>]
let private SublangAzeriCyrillic = 0x02us    // Azeri (Cyrillic) - for Azerbaijani, SUBLANGAZERBAIJANIAZERBAIJANCYRILLIC preferred
[<Literal>]
let private SublangAzerbaijaniAzerbaijanLatin = 0x01us    // Azerbaijani (Azerbaijan, Latin)
[<Literal>]
let private SublangAzerbaijaniAzerbaijanCyrillic = 0x02us    // Azerbaijani (Azerbaijan, Cyrillic)
[<Literal>]
let private SublangBanglaIndia = 0x01us    // Bangla (India)
[<Literal>]
let private SublangBanglaBangladesh = 0x02us    // Bangla (Bangladesh)
[<Literal>]
let private SublangBashkirRussia = 0x01us    // Bashkir (Russia) 0x046d ba-RU
[<Literal>]
let private SublangBasqueBasque = 0x01us    // Basque (Basque) 0x042d eu-ES
[<Literal>]
let private SublangBelarusianBelarus = 0x01us    // Belarusian (Belarus) 0x0423 be-BY
[<Literal>]
let private SublangBengaliIndia = 0x01us    // Bengali (India) - Note some prefer SUBLANGBANGLAINDIA
[<Literal>]
let private SublangBengaliBangladesh = 0x02us    // Bengali (Bangladesh) - Note some prefer SUBLANGBANGLABANGLADESH
[<Literal>]
let private SublangBosnianBosniaHerzegovinaLatin = 0x05us    // Bosnian (Bosnia and Herzegovina - Latin) 0x141a bs-BA-Latn
[<Literal>]
let private SublangBosnianBosniaHerzegovinaCyrillic = 0x08us    // Bosnian (Bosnia and Herzegovina - Cyrillic) 0x201a bs-BA-Cyrl
[<Literal>]
let private SublangBretonFrance = 0x01us    // Breton (France) 0x047e
[<Literal>]
let private SublangBulgarianBulgaria = 0x01us    // Bulgarian (Bulgaria) 0x0402
[<Literal>]
let private SublangCatalanCatalan = 0x01us    // Catalan (Catalan) 0x0403
[<Literal>]
let private SublangCentralKurdishIraq = 0x01us    // Central Kurdish (Iraq) 0x0492 ku-Arab-IQ
[<Literal>]
let private SublangCherokeeCherokee = 0x01us    // Cherokee (Cherokee) 0x045c chr-Cher-US
[<Literal>]
let private SublangChineseTraditional = 0x01us    // Chinese (Taiwan) 0x0404 zh-TW
[<Literal>]
let private SublangChineseSimplified = 0x02us    // Chinese (PR China) 0x0804 zh-CN
[<Literal>]
let private SublangChineseHongKong = 0x03us    // Chinese (Hong Kong S.A.R., P.R.C.) 0x0c04 zh-HK
[<Literal>]
let private SublangChineseSingapore = 0x04us    // Chinese (Singapore) 0x1004 zh-SG
[<Literal>]
let private SublangChineseMacau = 0x05us    // Chinese (Macau S.A.R.) 0x1404 zh-MO
[<Literal>]
let private SublangCorsicanFrance = 0x01us    // Corsican (France) 0x0483
[<Literal>]
let private SublangCzechCzechRepublic = 0x01us    // Czech (Czech Republic) 0x0405
[<Literal>]
let private SublangCroatianCroatia = 0x01us    // Croatian (Croatia)
[<Literal>]
let private SublangCroatianBosniaHerzegovinaLatin = 0x04us    // Croatian (Bosnia and Herzegovina - Latin) 0x101a hr-BA
[<Literal>]
let private SublangDanishDenmark = 0x01us    // Danish (Denmark) 0x0406
[<Literal>]
let private SublangDariAfghanistan = 0x01us    // Dari (Afghanistan)
[<Literal>]
let private SublangDivehiMaldives = 0x01us    // Divehi (Maldives) 0x0465 div-MV
[<Literal>]
let private SublangDutch = 0x01us    // Dutch
[<Literal>]
let private SublangDutchBelgian = 0x02us    // Dutch (Belgian)
[<Literal>]
let private SublangEnglishUS = 0x01us    // English (USA)
[<Literal>]
let private SublangEnglishUK = 0x02us    // English (UK)
[<Literal>]
let private SublangEnglishAus = 0x03us    // English (Australian)
[<Literal>]
let private SublangEnglishCan = 0x04us    // English (Canadian)
[<Literal>]
let private SublangEnglishNZ = 0x05us    // English (New Zealand)
[<Literal>]
let private SublangEnglishEire = 0x06us    // English (Irish)
[<Literal>]
let private SublangEnglishSouthAfrica = 0x07us    // English (South Africa)
[<Literal>]
let private SublangEnglishJamaica = 0x08us    // English (Jamaica)
[<Literal>]
let private SublangEnglishCaribbean = 0x09us    // English (Caribbean)
[<Literal>]
let private SublangEnglishBelize = 0x0aus    // English (Belize)
[<Literal>]
let private SublangEnglishTrinidad = 0x0bus    // English (Trinidad)
[<Literal>]
let private SublangEnglishZimbabwe = 0x0cus    // English (Zimbabwe)
[<Literal>]
let private SublangEnglishPhilippines = 0x0dus    // English (Philippines)
[<Literal>]
let private SublangEnglishIndia = 0x10us    // English (India)
[<Literal>]
let private SublangEnglishMalaysia = 0x11us    // English (Malaysia)
[<Literal>]
let private SublangEnglishSingapore = 0x12us    // English (Singapore)
[<Literal>]
let private SublangEstonianEstonia = 0x01us    // Estonian (Estonia) 0x0425 et-EE
[<Literal>]
let private SublangFaeroeseFaroeIslands = 0x01us    // Faroese (Faroe Islands) 0x0438 fo-FO
[<Literal>]
let private SublangFilipinoPhilippines = 0x01us    // Filipino (Philippines) 0x0464 fil-PH
[<Literal>]
let private SublangFinnishFinland = 0x01us    // Finnish (Finland) 0x040b
[<Literal>]
let private SublangFrench = 0x01us    // French
[<Literal>]
let private SublangFrenchBelgian = 0x02us    // French (Belgian)
[<Literal>]
let private SublangFrenchCanadian = 0x03us    // French (Canadian)
[<Literal>]
let private SublangFrenchSwiss = 0x04us    // French (Swiss)
[<Literal>]
let private SublangFrenchLuxembourg = 0x05us    // French (Luxembourg)
[<Literal>]
let private SublangFrenchMonaco = 0x06us    // French (Monaco)
[<Literal>]
let private SublangFrisianNetherlands = 0x01us    // Frisian (Netherlands) 0x0462 fy-NL
[<Literal>]
let private SublangFulahSenegal = 0x02us    // Fulah (Senegal) 0x0867 ff-SN
[<Literal>]
let private SublangGalicianGalician = 0x01us    // Galician (Galician) 0x0456 gl-ES
[<Literal>]
let private SublangGeorgianGeorgia = 0x01us    // Georgian (Georgia) 0x0437 ka-GE
[<Literal>]
let private SublangGerman = 0x01us    // German
[<Literal>]
let private SublangGermanSwiss = 0x02us    // German (Swiss)
[<Literal>]
let private SublangGermanAustrian = 0x03us    // German (Austrian)
[<Literal>]
let private SublangGermanLuxembourg = 0x04us    // German (Luxembourg)
[<Literal>]
let private SublangGermanLiechtenstein = 0x05us    // German (Liechtenstein)
[<Literal>]
let private SublangGreekGreece = 0x01us    // Greek (Greece)
[<Literal>]
let private SublangGreenlandicGreenland = 0x01us    // Greenlandic (Greenland) 0x046f kl-GL
[<Literal>]
let private SublangGujaratiIndia = 0x01us    // Gujarati (India (Gujarati Script)) 0x0447 gu-IN
[<Literal>]
let private SublangHausaNigeriaLatin = 0x01us    // Hausa (Latin, Nigeria) 0x0468 ha-NG-Latn
[<Literal>]
let private SublangHawaiianUs = 0x01us    // Hawiian (US) 0x0475 haw-US
[<Literal>]
let private SublangHebrewIsrael = 0x01us    // Hebrew (Israel) 0x040d
[<Literal>]
let private SublangHindiIndia = 0x01us    // Hindi (India) 0x0439 hi-IN
[<Literal>]
let private SublangHungarianHungary = 0x01us    // Hungarian (Hungary) 0x040e
[<Literal>]
let private SublangIcelandicIceland = 0x01us    // Icelandic (Iceland) 0x040f
[<Literal>]
let private SublangIgboNigeria = 0x01us    // Igbo (Nigeria) 0x0470 ig-NG
[<Literal>]
let private SublangIndonesianIndonesia = 0x01us    // Indonesian (Indonesia) 0x0421 id-ID
[<Literal>]
let private SublangInuktitutCanada = 0x01us    // Inuktitut (Syllabics) (Canada) 0x045d iu-CA-Cans
[<Literal>]
let private SublangInuktitutCanadaLatin = 0x02us    // Inuktitut (Canada - Latin)
[<Literal>]
let private SublangIrishIreland = 0x02us    // Irish (Ireland)
[<Literal>]
let private SublangItalian = 0x01us    // Italian
[<Literal>]
let private SublangItalianSwiss = 0x02us    // Italian (Swiss)
[<Literal>]
let private SublangJapaneseJapan = 0x01us    // Japanese (Japan) 0x0411
[<Literal>]
let private SublangKannadaIndia = 0x01us    // Kannada (India (Kannada Script)) 0x044b kn-IN
[<Literal>]
let private SublangKashmiriSAsia = 0x02us    // Kashmiri (South Asia)
[<Literal>]
let private SublangKashmiriIndia = 0x02us    // For app compatibility only
[<Literal>]
let private SublangKazakKazakhstan = 0x01us    // Kazakh (Kazakhstan) 0x043f kk-KZ
[<Literal>]
let private SublangKhmerCambodia = 0x01us    // Khmer (Cambodia) 0x0453 kh-KH
[<Literal>]
let private SublangKicheGuatemala = 0x01us    // K'iche (Guatemala)
[<Literal>]
let private SublangKinyarwandaRwanda = 0x01us    // Kinyarwanda (Rwanda) 0x0487 rw-RW
[<Literal>]
let private SublangKonkaniIndia = 0x01us    // Konkani (India) 0x0457 kok-IN
[<Literal>]
let private SublangKorean = 0x01us    // Korean (Extended Wansung)
[<Literal>]
let private SublangKyrgyzKyrgyzstan = 0x01us    // Kyrgyz (Kyrgyzstan) 0x0440 ky-KG
[<Literal>]
let private SublangLaoLao = 0x01us    // Lao (Lao PDR) 0x0454 lo-LA
[<Literal>]
let private SublangLatvianLatvia = 0x01us    // Latvian (Latvia) 0x0426 lv-LV
[<Literal>]
let private SublangLithuanian = 0x01us    // Lithuanian
[<Literal>]
let private SublangLowerSorbianGermany = 0x02us    // Lower Sorbian (Germany) 0x082e wee-DE
[<Literal>]
let private SublangLuxembourgishLuxembourg = 0x01us    // Luxembourgish (Luxembourg) 0x046e lb-LU
[<Literal>]
let private SublangMacedonianMacedonia = 0x01us    // Macedonian (Macedonia (FYROM)) 0x042f mk-MK
[<Literal>]
let private SublangMalayMalaysia = 0x01us    // Malay (Malaysia)
[<Literal>]
let private SublangMalayBruneiDarussalam = 0x02us    // Malay (Brunei Darussalam)
[<Literal>]
let private SublangMalayalamIndia = 0x01us    // Malayalam (India (Malayalam Script) ) 0x044c ml-IN
[<Literal>]
let private SublangMalteseMalta = 0x01us    // Maltese (Malta) 0x043a mt-MT
[<Literal>]
let private SublangMaoriNewZealand = 0x01us    // Maori (New Zealand) 0x0481 mi-NZ
[<Literal>]
let private SublangMapudungunChile = 0x01us    // Mapudungun (Chile) 0x047a arn-CL
[<Literal>]
let private SublangMarathiIndia = 0x01us    // Marathi (India) 0x044e mr-IN
[<Literal>]
let private SublangMohawkMohawk = 0x01us    // Mohawk (Mohawk) 0x047c moh-CA
[<Literal>]
let private SublangMongolianCyrillicMongolia = 0x01us    // Mongolian (Cyrillic, Mongolia)
[<Literal>]
let private SublangMongolianPRC = 0x02us    // Mongolian (PRC)
[<Literal>]
let private SublangNepaliIndia = 0x02us    // Nepali (India)
[<Literal>]
let private SublangNepaliNepal = 0x01us    // Nepali (Nepal) 0x0461 ne-NP
[<Literal>]
let private SublangNorwegianBokmal = 0x01us    // Norwegian (Bokmal)
[<Literal>]
let private SublangNorwegianNynorsk = 0x02us    // Norwegian (Nynorsk)
[<Literal>]
let private SublangOccitanFrance = 0x01us    // Occitan (France) 0x0482 oc-FR
[<Literal>]
let private SublangOdiaIndia = 0x01us    // Odia (India (Odia Script)) 0x0448 or-IN
[<Literal>]
let private SublangPashtoAfghanistan = 0x01us    // Pashto (Afghanistan)
[<Literal>]
let private SublangPersianIran = 0x01us    // Persian (Iran) 0x0429 fa-IR
[<Literal>]
let private SublangPolishPoland = 0x01us    // Polish (Poland) 0x0415
[<Literal>]
let private SublangPortuguese = 0x02us    // Portuguese
[<Literal>]
let private SublangPortugueseBrazilian = 0x01us    // Portuguese (Brazil)
[<Literal>]
let private SublangPularSenegal = 0x02us    // Deprecated: Use SUBLANGFULAHSENEGAL instead
[<Literal>]
let private SublangPunjabiIndia = 0x01us    // Punjabi (India (Gurmukhi Script)) 0x0446 pa-IN
[<Literal>]
let private SublangPunjabiPakistan = 0x02us    // Punjabi (Pakistan (Arabic Script)) 0x0846 pa-Arab-PK
[<Literal>]
let private SublangQuechuaBolivia = 0x01us    // Quechua (Bolivia)
[<Literal>]
let private SublangQuechuaEcuador = 0x02us    // Quechua (Ecuador)
[<Literal>]
let private SublangQuechuaPeru = 0x03us    // Quechua (Peru)
[<Literal>]
let private SublangRomanianRomania = 0x01us    // Romanian (Romania) 0x0418
[<Literal>]
let private SublangRomanshSwitzerland = 0x01us    // Romansh (Switzerland) 0x0417 rm-CH
[<Literal>]
let private SublangRussianRussia = 0x01us    // Russian (Russia) 0x0419
[<Literal>]
let private SublangSakhaRussia = 0x01us    // Sakha (Russia) 0x0485 sah-RU
[<Literal>]
let private SublangSamiNorthernNorway = 0x01us    // Northern Sami (Norway)
[<Literal>]
let private SublangSamiNorthernSweden = 0x02us    // Northern Sami (Sweden)
[<Literal>]
let private SublangSamiNorthernFinland = 0x03us    // Northern Sami (Finland)
[<Literal>]
let private SublangSamiLuleNorway = 0x04us    // Lule Sami (Norway)
[<Literal>]
let private SublangSamiLuleSweden = 0x05us    // Lule Sami (Sweden)
[<Literal>]
let private SublangSamiSouthernNorway = 0x06us    // Southern Sami (Norway)
[<Literal>]
let private SublangSamiSouthernSweden = 0x07us    // Southern Sami (Sweden)
[<Literal>]
let private SublangSamiSkoltFinland = 0x08us    // Skolt Sami (Finland)
[<Literal>]
let private SublangSamiInariFinland = 0x09us    // Inari Sami (Finland)
[<Literal>]
let private SublangSanskritIndia = 0x01us    // Sanskrit (India) 0x044f sa-IN
[<Literal>]
let private SublangScottishGaelic = 0x01us    // Scottish Gaelic (United Kingdom) 0x0491 gd-GB
[<Literal>]
let private SublangSerbianBosniaHerzegovinaLatin = 0x06us    // Serbian (Bosnia and Herzegovina - Latin)
[<Literal>]
let private SublangSerbianBosniaHerzegovinaCyrillic = 0x07us    // Serbian (Bosnia and Herzegovina - Cyrillic)
[<Literal>]
let private SublangSerbianMontenegroLatin = 0x0bus    // Serbian (Montenegro - Latn)
[<Literal>]
let private SublangSerbianMontenegroCyrillic = 0x0cus    // Serbian (Montenegro - Cyrillic)
[<Literal>]
let private SublangSerbianSerbiaLatin = 0x09us    // Serbian (Serbia - Latin)
[<Literal>]
let private SublangSerbianSerbiaCyrillic = 0x0aus    // Serbian (Serbia - Cyrillic)
[<Literal>]
let private SublangSerbianCroatia = 0x01us    // Croatian (Croatia) 0x041a hr-HR
[<Literal>]
let private SublangSerbianLatin = 0x02us    // Serbian (Latin)
[<Literal>]
let private SublangSerbianCyrillic = 0x03us    // Serbian (Cyrillic)
[<Literal>]
let private SublangSindhiIndia = 0x01us    // Sindhi (India) reserved 0x0459
[<Literal>]
let private SublangSindhiPakistan = 0x02us    // Sindhi (Pakistan) 0x0859 sd-Arab-PK
[<Literal>]
let private SublangSindhiAfghanistan = 0x02us    // For app compatibility only
[<Literal>]
let private SublangSinhaleseSriLanka = 0x01us    // Sinhalese (Sri Lanka)
[<Literal>]
let private SublangSothoNorthernSouthAfrica = 0x01us    // Northern Sotho (South Africa)
[<Literal>]
let private SublangSlovakSlovakia = 0x01us    // Slovak (Slovakia) 0x041b sk-SK
[<Literal>]
let private SublangSlovenianSlovenia = 0x01us    // Slovenian (Slovenia) 0x0424 sl-SI
[<Literal>]
let private SublangSpanish = 0x01us    // Spanish (Castilian)
[<Literal>]
let private SublangSpanishMexican = 0x02us    // Spanish (Mexico)
[<Literal>]
let private SublangSpanishModern = 0x03us    // Spanish (Modern)
[<Literal>]
let private SublangSpanishGuatemala = 0x04us    // Spanish (Guatemala)
[<Literal>]
let private SublangSpanishCostaRica = 0x05us    // Spanish (Costa Rica)
[<Literal>]
let private SublangSpanishPanama = 0x06us    // Spanish (Panama)
[<Literal>]
let private SublangSpanishDominicanRepublic = 0x07us    // Spanish (Dominican Republic)
[<Literal>]
let private SublangSpanishVenezuela = 0x08us    // Spanish (Venezuela)
[<Literal>]
let private SublangSpanishColombia = 0x09us    // Spanish (Colombia)
[<Literal>]
let private SublangSpanishPeru = 0x0aus    // Spanish (Peru)
[<Literal>]
let private SublangSpanishArgentina = 0x0bus    // Spanish (Argentina)
[<Literal>]
let private SublangSpanishEcuador = 0x0cus    // Spanish (Ecuador)
[<Literal>]
let private SublangSpanishChile = 0x0dus    // Spanish (Chile)
[<Literal>]
let private SublangSpanishUruguay = 0x0eus    // Spanish (Uruguay)
[<Literal>]
let private SublangSpanishParaguay = 0x0fus    // Spanish (Paraguay)
[<Literal>]
let private SublangSpanishBolivia = 0x10us    // Spanish (Bolivia)
[<Literal>]
let private SublangSpanishElSalvador = 0x11us    // Spanish (El Salvador)
[<Literal>]
let private SublangSpanishHonduras = 0x12us    // Spanish (Honduras)
[<Literal>]
let private SublangSpanishNicaragua = 0x13us    // Spanish (Nicaragua)
[<Literal>]
let private SublangSpanishPuertoRico = 0x14us    // Spanish (Puerto Rico)
[<Literal>]
let private SublangSpanishUS = 0x15us    // Spanish (United States)
[<Literal>]
let private SublangSwahiliKenya = 0x01us    // Swahili (Kenya) 0x0441 sw-KE
[<Literal>]
let private SublangSwedish = 0x01us    // Swedish
[<Literal>]
let private SublangSwedishFinland = 0x02us    // Swedish (Finland)
[<Literal>]
let private SublangSyriacSyria = 0x01us    // Syriac (Syria) 0x045a syr-SY
[<Literal>]
let private SublangTajikTajikistan = 0x01us    // Tajik (Tajikistan) 0x0428 tg-TJ-Cyrl
[<Literal>]
let private SublangTamazightAlgeriaLatin = 0x02us    // Tamazight (Latin, Algeria) 0x085f tzm-Latn-DZ
[<Literal>]
let private SublangTamazightMoroccoTifinagh = 0x04us    // Tamazight (Tifinagh) 0x105f tzm-Tfng-MA
[<Literal>]
let private SublangTamilIndia = 0x01us    // Tamil (India)
[<Literal>]
let private SublangTamilSriLanka = 0x02us    // Tamil (Sri Lanka) 0x0849 ta-LK
[<Literal>]
let private SublangTatarRussia = 0x01us    // Tatar (Russia) 0x0444 tt-RU
[<Literal>]
let private SublangTeluguIndia = 0x01us    // Telugu (India (Telugu Script)) 0x044a te-IN
[<Literal>]
let private SublangThaiThailand = 0x01us    // Thai (Thailand) 0x041e th-TH
[<Literal>]
let private SublangTibetanPRC = 0x01us    // Tibetan (PRC)
[<Literal>]
let private SublangTigrinyaEritrea = 0x02us    // Tigrinya (Eritrea) 0x0873 ti-ER (preferred spelling)
[<Literal>]
let private SublangTigrinyaEthiopia = 0x01us    // Tigrinya (Ethiopia) 0x0473 ti-ET
[<Literal>]
let private SublangTswanaBotswana = 0x02us    // Setswana / Tswana (Botswana) 0x0832 tn-BW
[<Literal>]
let private SublangTswanaSouthAfrica = 0x01us    // Setswana / Tswana (South Africa) 0x0432 tn-ZA
[<Literal>]
let private SublangTurkishTurkey = 0x01us    // Turkish (Turkey) 0x041f tr-TR
[<Literal>]
let private SublangTurkmenTurkmenistan = 0x01us    // Turkmen (Turkmenistan) 0x0442 tk-TM
[<Literal>]
let private SublangUighurPRC = 0x01us    // Uighur (PRC) 0x0480 ug-CN
[<Literal>]
let private SublangUkrainianUkraine = 0x01us    // Ukrainian (Ukraine) 0x0422 uk-UA
[<Literal>]
let private SublangUpperSorbianGermany = 0x01us    // Upper Sorbian (Germany) 0x042e wen-DE
[<Literal>]
let private SublangUrduPakistan = 0x01us    // Urdu (Pakistan)
[<Literal>]
let private SublangUrduIndia = 0x02us    // Urdu (India)
[<Literal>]
let private SublangUzbekLatin = 0x01us    // Uzbek (Latin)
[<Literal>]
let private SublangUzbekCyrillic = 0x02us    // Uzbek (Cyrillic)
[<Literal>]
let private SublangValencianValencia = 0x02us    // Valencian (Valencia) 0x0803 ca-ES-Valencia
[<Literal>]
let private SublangVietnameseVietnam = 0x01us    // Vietnamese (Vietnam) 0x042a vi-VN
[<Literal>]
let private SublangWelshUnitedKingdom = 0x01us    // Welsh (United Kingdom) 0x0452 cy-GB
[<Literal>]
let private SublangWolofSenegal = 0x01us    // Wolof (Senegal)
[<Literal>]
let private SublangXhosaSouthAfrica = 0x01us    // isiXhosa / Xhosa (South Africa) 0x0434 xh-ZA
[<Literal>]
let private SublangYakutRussia = 0x01us    // Deprecated: use SUBLANGSAKHARUSSIA instead
[<Literal>]
let private SublangYiPRC = 0x01us    // Yi (PRC)) 0x0478
[<Literal>]
let private SublangYorubaNigeria = 0x01us    // Yoruba (Nigeria) 046a yo-NG
[<Literal>]
let private SublangZuluSouthAfrica = 0x01us    // isiZulu / Zulu (South Africa) 0x0435 zu-ZA


let internal makeLangId(primary: uint16, sub: uint16) = 
    (sub <<< 10) ||| (primary &&& 0x3ffus)

let private iso639Dash1LanguageAndCountry(iso: string) = 
    let splits = iso.Split([|'-'|], StringSplitOptions.RemoveEmptyEntries)

    match splits with
    | [| l |] -> (Some(l.ToLower()), None)
    | [| l; c |] -> (Some(l.ToLower()), Some(c.ToUpper()))
    | [| l; c; _ |] -> (Some(l.ToLower()), Some(c.ToUpper()))
    | _ -> (None, None)

/// <summary>
/// Converts a Windows LANGID language id into the most appropriate
/// ISO-639-1 language code. If no mapping is available, None is returned.
/// </summary>
/// <param name="langid">the LANGID to convert</param>
let LANGIDToIso639Dash1(langid: uint16): string option = 
    match (langidPrimaryLanguage(langid), langidSubLanguage(langid)) with
    | (0us, _) -> 
        // Neutral language.
        None
    | (0x7fus, _) ->
        // Invariant language.
        None

    // The system default language and Bulgarian cannot be distinguished without
    // an associated locale ID. Given the context in which this is likely to
    // be used, we'll assume that encountering 0x02 as a primary language ID
    // indicates Bulgarian.
    // | (0x02us, _) ->

    | (LangAfrikaans, SublangAfrikaansSouthAfrica) -> Some("af-ZA")
    | (LangAfrikaans, _) -> Some("af")
    | (LangAlbanian, SublangAlbanianAlbania) -> Some("sq-AL")
    | (LangAlbanian, _) -> Some("sq")
    | (LangAlsatian, _) ->
        // Alsatian -- no mapping available in ISO-639-1
        None
    | (LangAmharic, SublangAmharicEthiopia) -> Some("am-ET")
    | (LangAmharic, _) -> Some("am")
    | (LangArabic, sublang) ->
        // Arabic grouping
        let countrySuffix = 
            match sublang with
            | SublangArabicAlgeria -> "-DZ"
            | SublangArabicBahrain -> "-BH"
            | SublangArabicEgypt -> "-EG"
            | SublangArabicIraq -> "-IQ"
            | SublangArabicJordan -> "-JO"
            | SublangArabicKuwait -> "-KW"
            | SublangArabicLebanon -> "-LB"
            | SublangArabicLibya -> "-LY"
            | SublangArabicMorocco -> "-MA"
            | SublangArabicOman -> "-OM"
            | SublangArabicQatar -> "-QA"
            | SublangArabicSaudiArabia -> "-SA"
            | SublangArabicSyria -> "-SY"
            | SublangArabicTunisia -> "-TN"
            | SublangArabicUAE -> "-AE"
            | SublangArabicYemen -> "-YE"
            | _ -> ""

        Some("ar" + countrySuffix)
    | (LangArmenian, SublangArmenianArmenia) -> Some("hy-AM")
    | (LangArmenian, _) -> Some("hy")
    | (LangAssamese, SublangAssameseIndia) -> Some("as-IN")
    | (LangAssamese, _) -> Some("as")
    | (LangAzeri, SublangAzeriCyrillic) | (LangAzeri, SublangAzeriLatin) -> 
        // ***FIXME: determine right way to handle scripts
        Some("az-AZ")
    | (LangAzeri, _) -> Some("az")
    | (LangBangla, SublangBanglaBangladesh) -> Some("bn-BD")
    | (LangBangla, SublangBanglaIndia) -> Some("bn-IN")
    | (LangBangla, _) -> Some("bn")
    | (LangBashkir, SublangBashkirRussia) -> Some("ba-RU")
    | (LangBashkir, _) -> Some("ba")
    | (LangBasque, SublangBasqueBasque) -> 
        // ***FIXME: determine right way to handle this for Basque
        Some("eu-")
    | (LangBasque, _) -> Some("eu")
    | (LangBelarusian, SublangBelarusianBelarus) -> Some("be-BY")
    | (LangBelarusian, _) -> Some("be")
    | (LangBosnian, SublangBosnianBosniaHerzegovinaCyrillic) | (LangBosnian, SublangBosnianBosniaHerzegovinaLatin) -> 
        // ***FIXME: can scripts be differentiated?
        Some("bs-BA")
    | (LangBreton, SublangBretonFrance) -> Some("br-FR")
    | (LangBreton, _) -> Some("br")
    | (LangBulgarian, SublangBulgarianBulgaria) -> Some("bg-BG")
    | (LangBulgarian, _) -> Some("bg")
    | (LangCentralKurdish, SublangCentralKurdishIraq) -> Some("ku-IQ")
    | (LangCentralKurdish, _) -> Some("ku")
    | (LangCherokee, _) ->
        // Cherokee cannot be represented in ISO-639-1
        None
    | (LangChinese, SublangChineseHongKong) -> Some("zh-HK")
    | (LangChinese, SublangChineseMacau) -> Some("zh-MO")
    | (LangChinese, SublangChineseSingapore) -> Some("zh-SG")
    | (LangChinese, _) ->
        // roll up simplified, traditional, and others since they can't be represented in ISO-639-1
        Some("zh")
    | (LangCorsican, SublangCorsicanFrance) -> Some("co-FR")
    | (LangCorsican, _) -> Some("co")
    | (LangCroatian, SublangCroatianBosniaHerzegovinaLatin) -> Some("hr-BA")
    | (LangCroatian, SublangCroatianCroatia) -> Some("hr-HR")
    | (LangCzech, SublangCzechCzechRepublic) -> Some("cs-CZ")
    | (LangCzech, _) -> Some("cs")
    | (LangDanish, SublangDanishDenmark) -> Some("da-DK")
    | (LangDanish, _) -> Some("da")
    | (LangDari, _) ->
        // Dari cannot be represented in ISO-639-1
        None
    | (LangDivehi, SublangDivehiMaldives) -> Some("dv-MV")
    | (LangDivehi, _) -> Some("dv")
    | (LangDutch, SublangDutchBelgian) -> Some("nl-BE")
    | (LangDutch, SublangDutch) -> Some("nl-NL")
    | (LangDutch, _) -> Some("nl")
    | (LangEnglish, sublang) ->
        let countrySuffix = 
            match sublang with
            | SublangEnglishAus -> "-AU"
            | SublangEnglishBelize -> "-BZ"
            | SublangEnglishCan -> "-CA"
            | SublangEnglishCaribbean -> 
                // Caribbean cannot be represented in ISO-639-1
                ""
            | SublangEnglishIndia -> "-IN"
            | SublangEnglishEire -> "-IE"
            | SublangEnglishJamaica -> "-JM"
            | SublangEnglishMalaysia -> "-MY"
            | SublangEnglishNZ -> "-NZ"
            | SublangEnglishPhilippines -> "-PH"
            | SublangEnglishSingapore -> "-SG"
            | SublangEnglishSouthAfrica -> "-ZA"
            | SublangEnglishTrinidad -> "-TT"
            | SublangEnglishUK -> "-GB"
            | SublangEnglishUS -> "-US"
            | SublangEnglishZimbabwe -> "-ZW"
            | _ -> ""

        Some("en" + countrySuffix)
    | (LangEstonian, SublangEstonianEstonia) -> Some("et-EE")
    | (LangEstonian, _) -> Some("et")
    | (LangFaroese, SublangFaeroeseFaroeIslands) -> Some("fo-FO")
    | (LangFaroese, _) -> Some("fo")
    | (LangFilipino, _) ->
        // Filipino cannot be represented in ISO-639-1
        None
    | (LangFinnish, SublangFinnishFinland) -> Some("fi-FI")
    | (LangFinnish, _) -> Some("fi")
    | (LangFrench, sublang) -> 
        let countrySuffix = 
            match sublang with
            | SublangFrenchBelgian -> "-BE"
            | SublangFrenchCanadian -> "-CA"
            | SublangFrench -> "-FR"
            | SublangFrenchLuxembourg -> "-LU"
            | SublangFrenchMonaco -> "-MC"
            | SublangFrenchSwiss -> "-CH"
            | _ -> ""

        Some("fr" + countrySuffix)
    | (LangFrisian, SublangFrisianNetherlands) -> Some("fy-NL")
    | (LangFrisian, _) -> Some("fy")
    | (LangGalician, SublangGalicianGalician) -> Some("gl-ES")
    | (LangGalician, _) -> Some("gl")
    | (LangGeorgian, SublangGeorgianGeorgia) -> Some("ka-GE")
    | (LangGeorgian, _) -> Some("ka")
    | (LangGerman, sublang) ->
        let countrySuffix = 
            match sublang with
            | SublangGermanAustrian -> "-AT"
            | SublangGerman -> "-DE"
            | SublangGermanLiechtenstein -> "-LI"
            | SublangGermanLuxembourg -> "-LU"
            | SublangGermanSwiss -> "-CH"
            | _ -> ""

        Some("de" + countrySuffix)
    | (LangGreek, SublangGreekGreece) -> Some("el-GR")
    | (LangGreek, _) -> Some("el")
    | (LangGreenlandic, SublangGreenlandicGreenland) -> Some("kl-GL")
    | (LangGreenlandic, _) -> Some("kl")
    | (LangGujarati, SublangGujaratiIndia) -> Some("gu-IN")
    | (LangGujarati, _) -> Some("gu")
    | (LangHausa, SublangHausaNigeriaLatin) -> Some("ha-NG")
    | (LangHausa, _) -> Some("ha")
    | (LangHawaiian, _) ->
        // Hawaiian cannot be represented in ISO-639-1
        None
    | (LangHebrew, SublangHebrewIsrael) -> Some("he-IL")
    | (LangHebrew, _) -> Some("he")
    | (LangHindi, SublangHindiIndia) -> Some("hi-IN")
    | (LangHindi, _) -> Some("hi")
    | (LangHungarian, SublangHungarianHungary) -> Some("hu-HU")
    | (LangHungarian, _) -> Some("hu")
    | (LangIcelandic, SublangIcelandicIceland) -> Some("is-IS")
    | (LangIcelandic, _) -> Some("is")
    | (LangIgbo, SublangIgboNigeria) -> Some("ig-NG")
    | (LangIgbo, _) -> Some("ig")
    | (LangIndonesian, SublangIndonesianIndonesia) -> Some("id-ID")
    | (LangIndonesian, _) -> Some("id")
    | (LangInuktitut, SublangInuktitutCanada) | (LangInuktitut, SublangInuktitutCanadaLatin) -> 
        // ***FIXME: check if there's some way to disambiguate scripts
        Some("iu-CA")
    | (LangInuktitut, _) -> Some("iu")
    | (LangIrish, SublangIrishIreland) -> Some("ga-IE")
    | (LangIrish, _) -> Some("ga")
    | (LangXhosa, SublangXhosaSouthAfrica) -> Some("xh-ZA")
    | (LangXhosa, _) -> Some("xh")
    | (LangZulu, SublangZuluSouthAfrica) -> Some("zu-ZA")
    | (LangZulu, _) -> Some("zu")
    | (LangItalian, SublangItalian) -> Some("it-IT")
    | (LangItalian, SublangItalianSwiss) -> Some("it-CH")
    | (LangItalian, _) -> Some("it")
    | (LangJapanese, SublangJapaneseJapan) -> Some("ja-JP")
    | (LangJapanese, _) -> Some("ja")
    | (LangKannada, SublangKannadaIndia) -> Some("kn-IN")
    | (LangKannada, _) -> Some("kn")
    | (LangKashmiri, _) -> Some("ks")
    | (LangKazak, SublangKazakKazakhstan) -> Some("kk-KZ")
    | (LangKazak, _) -> Some("kk")
    | (LangKhmer, SublangKhmerCambodia) -> Some("km-KH")
    | (LangKhmer, _) -> Some("km")
    | (LangKiche, _) ->
        // K'iche cannot be represented in ISO-639-1
        None
    | (LangKinyarwanda, SublangKinyarwandaRwanda) -> Some("rw-RW")
    | (LangKinyarwanda, _) -> Some("rw")
    | (LangKonkani, _) ->
        // Konkani cannot be represented in ISO-639-1
        None
    | (LangKorean, SublangKorean) -> Some("ko-KR")
    | (LangKorean, _) -> Some("ko")
    | (LangKyrgyz, SublangKyrgyzKyrgyzstan) -> Some("ky-KG")
    | (LangKyrgyz, _) -> Some("ky")
    | (LangLao, SublangLaoLao) -> Some("lo-LA")
    | (LangLao, _) -> Some("lo")
    | (LangLatvian, SublangLatvianLatvia) -> Some("lv-LV")
    | (LangLatvian, _) -> Some("lv")
    | (LangLithuanian, SublangLithuanian) -> Some("lt-LT")
    | (LangLithuanian, _) -> Some("lt")
    | (LangLowerSorbian, SublangLowerSorbianGermany) ->
        // Lower Sorbian cannot be represented in ISO-639-1
        None
    | (LangUpperSorbian, SublangUpperSorbianGermany) ->
        // Upper Sorbian cannot be represented in ISO-639-1
        None
    | (LangLowerSorbian, _) ->
        // Any other Sorbian variants cannot be represented in ISO-639-1
        None
    | (LangLuxembourgish, SublangLuxembourgishLuxembourg) -> Some("lb-LU")
    | (LangLuxembourgish, _) -> Some("lb")
    | (LangMacedonian, SublangMacedonianMacedonia) -> Some("mk-MK")
    | (LangMacedonian, _) -> Some("mk")
    | (LangMalay, SublangMalayMalaysia) -> Some("ms-MY")
    | (LangMalay, SublangMalayBruneiDarussalam) -> Some("ms-BN")
    | (LangMalay, _) -> Some("ms")
    | (LangMalayalam, SublangMalayalamIndia) -> Some("ml-IN")
    | (LangMalayalam, _) -> Some("ml")
    | (LangMaltese, SublangMalteseMalta) -> Some("mt-MT")
    | (LangMaltese, _) -> Some("mt")
    | (LangManipuri, _) ->
        // Manipuri cannot be represented in ISO-639-1
        None
    | (LangMaori, SublangMaoriNewZealand) -> Some("mi-NZ")
    | (LangMaori, _) -> Some("mi")
    | (LangMapudungun, _) ->
        // Mapudungun cannot be represented in ISO-639-1
        None
    | (LangMarathi, SublangMarathiIndia) -> Some("mr-IN")
    | (LangMarathi, _) -> Some("mr")
    | (LangMohawk, _) ->
        // Mohawk cannot be represented in ISO-639-1
        None
    | (LangMongolian, SublangMongolianCyrillicMongolia) | (LangMongolian, SublangMongolianPRC) -> 
        // ***FIXME: see if there's a way to disambiguate scripts
        Some("mn-MN")
    | (LangMongolian, _) -> Some("mn")
    | (LangNepali, SublangNepaliNepal) -> Some("ne-NP")
    | (LangNepali, SublangNepaliIndia) -> Some("ne-IN")
    | (LangNepali, _) -> Some("ne")
    | (LangNorwegian, SublangNorwegianBokmal) -> 
        // use the ISO-639-1 identifier for Bokmal
        Some("nb-NO")
    | (LangNorwegian, SublangNorwegianNynorsk) -> 
        // use the ISO-639-1 identifier for Nynorsk
        Some("nn-NO")
    | (LangNorwegian, _) -> 
        // default to the Norwegian ISO-639-1 macrolanguage
        Some("no")
    | (LangOccitan, SublangOccitanFrance) -> Some("oc-FR")
    | (LangOccitan, _) -> Some("oc")
    | (LangOriya, SublangOdiaIndia) -> Some("or-IN")
    | (LangOriya, _) -> Some("or")
    | (LangPashto, SublangPashtoAfghanistan) -> Some("ps-AF")
    | (LangPashto, _) -> Some("ps")
    | (LangPersian, SublangPersianIran) -> Some("fa-IR")
    | (LangPersian, _) -> Some("fa")
    | (LangPolish, SublangPolishPoland) -> Some("pl-PL")
    | (LangPolish, _) -> Some("pl")
    | (LangPortuguese, SublangPortugueseBrazilian) -> Some("pt-BR")
    | (LangPortuguese, SublangPortuguese) -> Some("pt-PT")
    | (LangPortuguese, _) -> Some("pt")
    | (LangPular, SublangPularSenegal) -> Some("ff-SN")
    | (LangPular, _) -> Some("ff")
    | (LangPunjabi, SublangPunjabiIndia) -> Some("pa-IN")
    | (LangPunjabi, SublangPunjabiPakistan) -> Some("pa-PK")
    | (LangPunjabi, _) -> Some("pa")
    | (LangQuechua, SublangQuechuaBolivia) -> Some("qu-BO")
    | (LangQuechua, SublangQuechuaEcuador) -> Some("qu-EC")
    | (LangQuechua, SublangQuechuaPeru) -> Some("qu-PE")
    | (LangQuechua, _) -> Some("qu")
    | (LangRomanian, SublangRomanianRomania) -> Some("ro-RO")
    | (LangRomanian, _) -> Some("ro")
    | (LangRomansh, SublangRomanshSwitzerland) -> Some("rm-CH")
    | (LangRomansh, _) -> Some("rm")
    | (LangRussian, SublangRussianRussia) -> Some("ru-RU")
    | (LangRussian, _) -> Some("ru")
    | (LangSakha, _) -> 
        // Sakha cannot be represented in ISO-639-1
        None
    | (LangSami, SublangSamiNorthernFinland) -> Some("se-FI")
    | (LangSami, SublangSamiNorthernNorway) -> Some("se-NO")
    | (LangSami, SublangSamiNorthernSweden) -> Some("se-SE")
    | (LangSami, _) -> 
        // Other Sami variants cannot be represented in ISO-639-1
        None
    | (LangSanskrit, SublangSanskritIndia) -> Some("sa-IN")
    | (LangSanskrit, _) -> Some("sa")
    | (LangSerbian, SublangSerbianBosniaHerzegovinaLatin) | (LangSerbian, SublangSerbianBosniaHerzegovinaCyrillic) -> 
        // ***FIXME: see if scripts can be disambiguated
        Some("sr-BA")

    | (LangSerbian, SublangSerbianCroatia) -> 
        // Unfortunately, Serbian and Croatian in Croatia are indistinguishable by primary and sub-language. Punt.
        None

    | (LangSerbian, SublangSerbianMontenegroCyrillic) | (LangSerbian, SublangSerbianMontenegroLatin) -> 
        // ***FIXME: see if scripts can be disambiguated
        Some("sr-CS")
    | (LangSotho, SublangSothoNorthernSouthAfrica) -> Some("st-ZA")
    | (LangSotho, _) -> Some("st")
    | (LangTswana, SublangTswanaSouthAfrica) -> Some("tn-ZA")
    | (LangTswana, SublangTswanaBotswana) -> Some("tn-BW")
    | (LangTswana, _) -> Some("tn")
    | (LangSindhi, SublangSindhiIndia) -> Some("sd-IN")
    | (LangSindhi, SublangSindhiPakistan) -> Some("sd-PK")
    | (LangSindhi, _) -> Some("sd")
    | (LangSinhalese, SublangSinhaleseSriLanka) -> Some("si-LK")
    | (LangSinhalese, _) -> Some("si")
    | (LangSlovak, SublangSlovakSlovakia) -> Some("sk-SK")
    | (LangSlovak, _) -> Some("sk")
    | (LangSlovenian, SublangSlovenianSlovenia) -> Some("sl-SI")
    | (LangSlovenian, _) -> Some("sl")
    | (LangSpanish, sublang) ->
        let countrySuffix = 
            match sublang with
            | SublangSpanishArgentina -> "-AR"
            | SublangSpanishBolivia -> "-BO"
            | SublangSpanishChile -> "-CL"
            | SublangSpanishColombia -> "-CO"
            | SublangSpanishCostaRica -> "-CR"
            | SublangSpanishDominicanRepublic -> "-DO"
            | SublangSpanishEcuador -> "-EC"
            | SublangSpanishElSalvador -> "-SV"
            | SublangSpanishGuatemala -> "-GT"
            | SublangSpanishHonduras -> "-HN"
            | SublangSpanishMexican -> "-MX"
            | SublangSpanishNicaragua -> "-NI"
            | SublangSpanishPanama -> "-PA"
            | SublangSpanishParaguay -> "-PY"
            | SublangSpanishPeru -> "-PE"
            | SublangSpanishPuertoRico -> "-PR"
            | SublangSpanishModern -> "-ES"
            | SublangSpanish -> "-ES"
            | SublangSpanishUS -> "-US"
            | SublangSpanishUruguay -> "-UY"
            | SublangSpanishVenezuela -> "-VE"
            | _ -> ""

        Some("es" + countrySuffix)
    | (LangSwahili, SublangSwahiliKenya) -> Some("sw-KE")
    | (LangSwahili, _) -> Some("sw")
    | (LangSwedish, SublangSwedish) -> Some("sv-SE")
    | (LangSwedish, SublangSwedishFinland) -> Some("sv-FI")
    | (LangSwedish, _) -> Some("sv")
    | (LangSyriac, _) ->
        // Syriac cannot be represented in ISO-639-1
        None
    | (LangTajik, SublangTajikTajikistan) -> Some("tg-TJ")
    | (LangTajik, _) -> Some("tg")
    | (LangTamazight, _) ->
        // Tamazight cannot be represented in ISO-639-1
        None
    | (LangTamil, SublangTamilIndia) -> Some("ta-IN")
    | (LangTamil, SublangTamilSriLanka) -> Some("ta-LK")
    | (LangTamil, _) -> Some("ta")
    | (LangTatar, SublangTatarRussia) -> Some("tt-RU")
    | (LangTatar, _) -> Some("tt")
    | (LangTelugu, SublangTeluguIndia) -> Some("te-IN")
    | (LangTelugu, _) -> Some("te")
    | (LangThai, SublangThaiThailand) -> Some("th-TH")
    | (LangThai, _) -> Some("th")
    | (LangTibetan, SublangTibetanPRC) -> Some("bo-CN")
    | (LangTibetan, _) -> Some("bo")
    | (LangTigrinya, SublangTigrinyaEthiopia) -> Some("ti-ET")
    | (LangTigrinya, SublangTigrinyaEritrea) -> Some("ti-ER")
    | (LangTigrinya, _) -> Some("ti")
    | (LangTurkish, SublangTurkishTurkey) -> Some("tr-TR")
    | (LangTurkish, _) -> Some("tr")
    | (LangTurkmen, SublangTurkmenTurkmenistan) -> Some("tk-TM")
    | (LangTurkmen, _) -> Some("tk")
    | (LangUkrainian, SublangUkrainianUkraine) -> Some("uk-UA")
    | (LangUkrainian, _) -> Some("uk")
    | (LangUrdu, SublangUrduPakistan) -> Some("ur-PK")
    | (LangUrdu, SublangUrduIndia) -> Some("ur-IN")
    | (LangUrdu, _) -> Some("ur")
    | (LangUighur, SublangUighurPRC) -> Some("ug-CN")
    | (LangUighur, _) -> Some("ug")
    | (LangUzbek, SublangUzbekCyrillic) | (LangUzbek, SublangUzbekLatin) -> 
        // ***FIXME: see if there's a way to disambiguate scripts
        Some("uz-UZ")
    | (LangUzbek, _) -> Some("uz")
    | (LangValencian, 0x01us) -> 
        // ***FIXME: does this have a sublang enum?
        Some("ca-ES")
    | (LangValencian, SublangValencianValencia) -> Some("ca-ES-Valencia")
    | (LangValencian, _) -> Some("ca")
    | (LangVietnamese, SublangVietnameseVietnam) -> Some("vi-VN")
    | (LangVietnamese, _) -> Some("vi")
    | (LangWelsh, SublangWelshUnitedKingdom) -> Some("cy-GB")
    | (LangWelsh, _) -> Some("cy")
    | (LangWolof, SublangWolofSenegal) -> Some("wo-SN")
    | (LangWolof, _) -> Some("wo")
    | (LangYi, SublangYiPRC) -> Some("ii-CN")
    | (LangYi, _) -> Some("ii")
    | (LangYoruba, SublangYorubaNigeria) -> Some("yo-NG")
    | (LangYoruba, _) -> Some("yo")
    | _ -> None

/// <summary>
/// Converts an ISO-639-1 language code to a Windows LANGID language id.
/// If no mapping is available, None is returned.
/// </summary>
/// <param name="iso">the ISO-639-1 language code to convert</param>
let Iso639Dash1ToLANGID(iso: string): uint16 option = 
    let (langOpt, countryOpt) = iso639Dash1LanguageAndCountry(iso)
    match (langOpt, countryOpt) with
    | (Some("ab"), _) -> None   // no representation of Abkhaz possible
    | (Some("aa"), _) -> None   // no representation of Afar possible
    | (Some("af"), Some("ZA")) -> Some(makeLangId(LangAfrikaans, SublangAfrikaansSouthAfrica))
    | (Some("af"), _) -> Some(makeLangId(LangAfrikaans, NeutralSubLanguage))
    | (Some("ak"), _) -> None   // no representation of Akan possible
    | (Some("sq"), Some("AL")) -> Some(makeLangId(LangAlbanian, SublangAlbanianAlbania))
    | (Some("sq"), _) -> Some(makeLangId(LangAlbanian, NeutralSubLanguage))
    | (Some("am"), Some("ET")) -> Some(makeLangId(LangAmharic, SublangAmharicEthiopia))
    | (Some("am"), _) -> Some(makeLangId(LangAmharic, NeutralSubLanguage))
    | (Some("ar"), Some("DZ")) -> Some(makeLangId(LangArabic, SublangArabicAlgeria))
    | (Some("ar"), Some("BH")) -> Some(makeLangId(LangArabic, SublangArabicBahrain))
    | (Some("ar"), Some("EG")) -> Some(makeLangId(LangArabic, SublangArabicEgypt))
    | (Some("ar"), Some("IQ")) -> Some(makeLangId(LangArabic, SublangArabicIraq))
    | (Some("ar"), Some("JO")) -> Some(makeLangId(LangArabic, SublangArabicJordan))
    | (Some("ar"), Some("KW")) -> Some(makeLangId(LangArabic, SublangArabicKuwait))
    | (Some("ar"), Some("LB")) -> Some(makeLangId(LangArabic, SublangArabicLebanon))
    | (Some("ar"), Some("LY")) -> Some(makeLangId(LangArabic, SublangArabicLibya))
    | (Some("ar"), Some("MA")) -> Some(makeLangId(LangArabic, SublangArabicMorocco))
    | (Some("ar"), Some("OM")) -> Some(makeLangId(LangArabic, SublangArabicOman))
    | (Some("ar"), Some("QA")) -> Some(makeLangId(LangArabic, SublangArabicQatar))
    | (Some("ar"), Some("SA")) -> Some(makeLangId(LangArabic, SublangArabicSaudiArabia))
    | (Some("ar"), Some("SY")) -> Some(makeLangId(LangArabic, SublangArabicSyria))
    | (Some("ar"), Some("TN")) -> Some(makeLangId(LangArabic, SublangArabicTunisia))
    | (Some("ar"), Some("AE")) -> Some(makeLangId(LangArabic, SublangArabicUAE))
    | (Some("ar"), Some("YE")) -> Some(makeLangId(LangArabic, SublangArabicYemen))
    | (Some("ar"), _) -> Some(makeLangId(LangArabic, NeutralSubLanguage))
    | (Some("an"), _) -> None   // no representation of Aragonese possible
    | (Some("hy"), Some("AM")) -> Some(makeLangId(LangArmenian, SublangArmenianArmenia))
    | (Some("hy"), _) -> Some(makeLangId(LangArmenian, NeutralSubLanguage))
    | (Some("as"), Some("IN")) -> Some(makeLangId(LangAssamese, SublangAssameseIndia))
    | (Some("as"), _) -> Some(makeLangId(LangAssamese, NeutralSubLanguage))
    | (Some("av"), _) -> None   // no representation of Avaric possible
    | (Some("ae"), _) -> None   // no representation of Avestan possible
    | (Some("ay"), _) -> None   // no representation of Aymara possible
    | (Some("az"), Some("AZ")) -> 
        // ***FIXME: see if there is a way to differentiate the Cyrillic and Latin scripts
        Some(makeLangId(LangAzeri, SublangAzeriLatin))
    | (Some("az"), _) -> Some(makeLangId(LangAzeri, NeutralSubLanguage))
    | (Some("bm"), _) -> None   // no representation of Bambara possible
    | (Some("ba"), Some("RU")) -> Some(makeLangId(LangBashkir, SublangBashkirRussia))
    | (Some("ba"), _) -> 
        // Unfortunately, Balochi and Bashkir appear to be overloaded in ISO-639-1.
        // Since we can't distinguish the two, let's punt if we don't know the country.
        None
    | (Some("eu"), _) -> 
        // ***FIXME: figure out if there are associated country codes that should be
        // mapped to sublanguage 0x01.
        Some(makeLangId(LangBasque, NeutralSubLanguage))
    | (Some("be"), Some("BY")) -> Some(makeLangId(LangBelarusian, SublangBelarusianBelarus))
    | (Some("be"), _) -> Some(makeLangId(LangBelarusian, NeutralSubLanguage))
    | (Some("bn"), Some("IN")) -> Some(makeLangId(LangBangla, SublangBanglaIndia))
    | (Some("bn"), Some("BD")) -> Some(makeLangId(LangBangla, SublangBanglaBangladesh))
    | (Some("bn"), _) -> Some(makeLangId(LangBangla, NeutralSubLanguage))
    | (Some("bh"), _) -> None   // no representation of Bihari possible
    | (Some("bi"), _) -> None   // no representation of Bislama possible
    | (Some("bs"), Some("BA")) -> 
        // ***FIXME: figure out if there is a way to differentiate Cyrillic and Latin scripts
        Some(makeLangId(LangBosnian, SublangBosnianBosniaHerzegovinaLatin))
    | (Some("bs"), _) ->
        // Unfortunately, because the LANGID identifiers for Bosnian, Croatian, and Serbian
        // are the same, there's no practical way to indicate a LANGID without a country for 
        // each of these languages. Punt.
        None
    | (Some("br"), Some("FR")) -> Some(makeLangId(LangBreton, SublangBretonFrance))
    | (Some("br"), _) -> Some(makeLangId(LangBreton, NeutralSubLanguage))
    | (Some("bg"), Some("BG")) -> Some(makeLangId(LangBulgarian, SublangBulgarianBulgaria))
    | (Some("bg"), _) -> Some(makeLangId(LangBulgarian, NeutralSubLanguage))
    | (Some("my"), _) -> None   // no representation of Burmese possible
    | (Some("ca"), Some("ES")) -> Some(makeLangId(LangCatalan, SublangCatalanCatalan))
    | (Some("ca"), _) -> Some(makeLangId(LangCatalan, NeutralSubLanguage))
    | (Some("ch"), _) -> None   // no representation of Chamorro possible
    | (Some("ce"), _) -> None   // no representation of Chechen possible
    | (Some("ny"), _) -> None   // no representation of Chichewa possible
    | (Some("zh"), Some("HK")) -> Some(makeLangId(LangChinese, SublangChineseHongKong))
    | (Some("zh"), Some("MO")) -> Some(makeLangId(LangChinese, SublangChineseMacau))
    | (Some("zh"), Some("SG")) -> Some(makeLangId(LangChinese, SublangChineseSingapore))
    | (Some("zh"), _) ->
        // ***FIXME: figure out if there is some way to differentiate between
        // simplified and traditional in ISO-639-1.
        Some(makeLangId(LangChinese, SublangChineseTraditional))
    | (Some("cv"), _) -> None   // no representation of Chuvash possible
    | (Some("kw"), _) -> None   // no representation of Cornish possible
    | (Some("co"), Some("FR")) -> Some(makeLangId(LangCorsican, SublangCorsicanFrance))
    | (Some("co"), _) -> Some(makeLangId(LangCorsican, NeutralSubLanguage))
    | (Some("cr"), _) -> None   // no representation of Cree possible
    | (Some("hr"), Some("BA")) -> Some(makeLangId(LangCroatian, SublangCroatianBosniaHerzegovinaLatin))
    | (Some("hr"), Some("HR")) -> Some(makeLangId(LangCroatian, SublangCroatianCroatia))
    | (Some("hr"), _) -> 
        // Unfortunately, because the LANGID identifiers for Bosnian, Croatian, and Serbian
        // are the same, there's no practical way to indicate a LANGID without a country for 
        // each of these languages. Punt.
        None
    | (Some("cs"), Some("CZ")) -> Some(makeLangId(LangCzech, SublangCzechCzechRepublic))
    | (Some("cs"), _) -> Some(makeLangId(LangCzech, NeutralSubLanguage))
    | (Some("da"), Some("DK")) -> Some(makeLangId(LangDanish, SublangDanishDenmark))
    | (Some("da"), _) -> Some(makeLangId(LangDanish, NeutralSubLanguage))
    | (Some("dv"), Some("MV")) -> Some(makeLangId(LangDivehi, SublangDivehiMaldives))
    | (Some("dv"), _) -> Some(makeLangId(LangDivehi, NeutralSubLanguage))
    | (Some("nl"), Some("BE")) -> Some(makeLangId(LangDutch, SublangDutchBelgian))
    | (Some("nl"), Some("NL")) -> Some(makeLangId(LangDutch, SublangDutch))
    | (Some("nl"), _) -> Some(makeLangId(LangDutch, NeutralSubLanguage))
    | (Some("dz"), _) -> None   // no representation of Dzongkha possible
    | (Some("en"), Some("AU")) -> Some(makeLangId(LangEnglish, SublangEnglishAus))
    | (Some("en"), Some("BZ")) -> Some(makeLangId(LangEnglish, SublangEnglishBelize))
    | (Some("en"), Some("CA")) -> Some(makeLangId(LangEnglish, SublangEnglishCan))
    | (Some("en"), Some("IN")) -> Some(makeLangId(LangEnglish, SublangEnglishIndia))
    | (Some("en"), Some("IE")) -> Some(makeLangId(LangEnglish, SublangEnglishEire))
    | (Some("en"), Some("JM")) -> Some(makeLangId(LangEnglish, SublangEnglishJamaica))
    | (Some("en"), Some("MY")) -> Some(makeLangId(LangEnglish, SublangEnglishMalaysia))
    | (Some("en"), Some("NZ")) -> Some(makeLangId(LangEnglish, SublangEnglishNZ))
    | (Some("en"), Some("PH")) -> Some(makeLangId(LangEnglish, SublangEnglishPhilippines))
    | (Some("en"), Some("SG")) -> Some(makeLangId(LangEnglish, SublangEnglishSingapore))
    | (Some("en"), Some("ZA")) -> Some(makeLangId(LangEnglish, SublangEnglishSouthAfrica))
    | (Some("en"), Some("TT")) -> Some(makeLangId(LangEnglish, SublangEnglishTrinidad))
    | (Some("en"), Some("GB")) -> Some(makeLangId(LangEnglish, SublangEnglishUK))
    | (Some("en"), Some("US")) -> Some(makeLangId(LangEnglish, SublangEnglishUS))
    | (Some("en"), Some("ZW")) -> Some(makeLangId(LangEnglish, SublangEnglishZimbabwe))
    | (Some("en"), _) -> Some(makeLangId(LangEnglish, NeutralSubLanguage))
    | (Some("eo"), _) -> None   // no representation of Esperanto possible
    | (Some("et"), Some("EE")) -> Some(makeLangId(LangEstonian, SublangEstonianEstonia))
    | (Some("et"), _) -> Some(makeLangId(LangEstonian, NeutralSubLanguage))
    | (Some("ee"), _) -> None
    | (Some("fo"), Some("FO")) -> Some(makeLangId(LangFaroese, SublangFaeroeseFaroeIslands))
    | (Some("fo"), _) -> Some(makeLangId(LangFaroese, NeutralSubLanguage))
    | (Some("fj"), _) -> None
    | (Some("fi"), Some("FI")) -> Some(makeLangId(LangFinnish, SublangFinnishFinland))
    | (Some("fi"), _) -> Some(makeLangId(LangFinnish, NeutralSubLanguage))
    | (Some("fr"), Some("BE")) -> Some(makeLangId(LangFrench, SublangFrenchBelgian))
    | (Some("fr"), Some("CA")) -> Some(makeLangId(LangFrench, SublangFrenchCanadian))
    | (Some("fr"), Some("FR")) -> Some(makeLangId(LangFrench, SublangFrench))
    | (Some("fr"), Some("LU")) -> Some(makeLangId(LangFrench, SublangFrenchLuxembourg))
    | (Some("fr"), Some("MC")) -> Some(makeLangId(LangFrench, SublangFrenchMonaco))
    | (Some("fr"), Some("CH")) -> Some(makeLangId(LangFrench, SublangFrenchSwiss))
    | (Some("fr"), _) -> Some(makeLangId(LangFrench, NeutralSubLanguage))
    | (Some("ff"), Some("SN")) -> Some(makeLangId(LangPular, SublangPularSenegal))
    | (Some("ff"), _) -> Some(makeLangId(LangPular, NeutralSubLanguage))
    | (Some("gl"), Some("ES")) -> Some(makeLangId(LangGalician, SublangGalicianGalician))
    | (Some("gl"), _) -> Some(makeLangId(LangGalician, NeutralSubLanguage))
    | (Some("ka"), Some("GE")) -> Some(makeLangId(LangGeorgian, SublangGeorgianGeorgia))
    | (Some("ka"), _) -> Some(makeLangId(LangGeorgian, NeutralSubLanguage))
    | (Some("de"), Some("AT")) -> Some(makeLangId(LangGerman, SublangGermanAustrian))
    | (Some("de"), Some("DE")) -> Some(makeLangId(LangGerman, SublangGerman))
    | (Some("de"), Some("LI")) -> Some(makeLangId(LangGerman, SublangGermanLiechtenstein))
    | (Some("de"), Some("LU")) -> Some(makeLangId(LangGerman, SublangGermanLuxembourg))
    | (Some("de"), Some("CH")) -> Some(makeLangId(LangGerman, SublangGermanSwiss))
    | (Some("de"), _) -> Some(makeLangId(LangGerman, NeutralSubLanguage))
    | (Some("el"), Some("GR")) -> Some(makeLangId(LangGreek, SublangGreekGreece))
    | (Some("el"), _) -> Some(makeLangId(LangGreek, NeutralSubLanguage))
    | (Some("gn"), _) -> None
    | (Some("gu"), Some("IN")) -> Some(makeLangId(LangGujarati, SublangGujaratiIndia))
    | (Some("gu"), _) -> Some(makeLangId(LangGujarati, NeutralSubLanguage))
    | (Some("ht"), _) -> None
    | (Some("ha"), Some("NG")) -> Some(makeLangId(LangHausa, SublangHausaNigeriaLatin))
    | (Some("ha"), _) -> Some(makeLangId(LangHausa, NeutralSubLanguage))
    | (Some("he"), Some("IL")) -> Some(makeLangId(LangHebrew, SublangHebrewIsrael))
    | (Some("he"), _) -> Some(makeLangId(LangHebrew, NeutralSubLanguage))
    | (Some("hz"), _) -> None
    | (Some("hi"), Some("IN")) -> Some(makeLangId(LangHindi, SublangHindiIndia))
    | (Some("hi"), _) -> Some(makeLangId(LangHindi, NeutralSubLanguage))
    | (Some("ho"), _) -> None
    | (Some("hu"), Some("HU")) -> Some(makeLangId(LangHungarian, SublangHungarianHungary))
    | (Some("hu"), _) -> Some(makeLangId(LangHungarian, NeutralSubLanguage))
    | (Some("ia"), _) -> None
    | (Some("id"), Some("ID")) -> Some(makeLangId(LangIndonesian, SublangIndonesianIndonesia))
    | (Some("id"), _) -> Some(makeLangId(LangIndonesian, NeutralSubLanguage))
    | (Some("ie"), _) -> None
    | (Some("ga"), Some("IE")) -> Some(makeLangId(LangIrish, SublangIrishIreland))
    | (Some("ga"), _) -> Some(makeLangId(LangIrish, NeutralSubLanguage))
    | (Some("ig"), Some("NG")) -> Some(makeLangId(LangIgbo, SublangIgboNigeria))
    | (Some("ig"), _) -> Some(makeLangId(LangIgbo, NeutralSubLanguage))
    | (Some("ik"), _) -> None
    | (Some("io"), _) -> None
    | (Some("is"), Some("IS")) -> Some(makeLangId(LangIcelandic, SublangIcelandicIceland))
    | (Some("is"), _) -> Some(makeLangId(LangIcelandic, NeutralSubLanguage))
    | (Some("it"), Some("IT")) -> Some(makeLangId(LangItalian, SublangItalian))
    | (Some("it"), Some("CH")) -> Some(makeLangId(LangItalian, SublangItalianSwiss))
    | (Some("it"), _) -> Some(makeLangId(LangItalian, NeutralSubLanguage))
    | (Some("iu"), Some("CA")) -> 
        // ***FIXME see if we can distinguish between Latin and Canadian Syllabics
        Some(makeLangId(LangInuktitut, SublangInuktitutCanadaLatin))
    | (Some("iu"), _) -> Some(makeLangId(LangInuktitut, NeutralSubLanguage))
    | (Some("ja"), Some("JP")) -> Some(makeLangId(LangJapanese, SublangJapaneseJapan))
    | (Some("ja"), _) -> Some(makeLangId(LangJapanese, NeutralSubLanguage))
    | (Some("jv"), _) -> None
    | (Some("kl"), Some("GL")) -> Some(makeLangId(LangGreenlandic, SublangGreenlandicGreenland))
    | (Some("kl"), _) -> Some(makeLangId(LangGreenlandic, NeutralSubLanguage))
    | (Some("kn"), Some("IN")) -> Some(makeLangId(LangKannada, SublangKannadaIndia))
    | (Some("kn"), _) -> Some(makeLangId(LangKannada, NeutralSubLanguage))
    | (Some("kr"), _) -> None
    | (Some("ks"), Some("IN")) -> Some(makeLangId(LangKashmiri, SublangKashmiriIndia))
    | (Some("ks"), _) -> Some(makeLangId(LangKashmiri, NeutralSubLanguage))
    | (Some("kk"), Some("KZ")) -> Some(makeLangId(LangKazak, SublangKazakKazakhstan))
    | (Some("kk"), _) -> Some(makeLangId(LangKazak, NeutralSubLanguage))
    | (Some("km"), Some("KH")) -> Some(makeLangId(LangKhmer, SublangKhmerCambodia))
    | (Some("km"), _) -> Some(makeLangId(LangKhmer, NeutralSubLanguage))
    | (Some("ki"), _) -> None
    | (Some("rw"), Some("RW")) -> Some(makeLangId(LangKinyarwanda, SublangKinyarwandaRwanda))
    | (Some("rw"), _) -> Some(makeLangId(LangKinyarwanda, NeutralSubLanguage))
    | (Some("ky"), Some("KG")) -> Some(makeLangId(LangKyrgyz, SublangKyrgyzKyrgyzstan))
    | (Some("ky"), _) -> Some(makeLangId(LangKyrgyz, NeutralSubLanguage))
    | (Some("kv"), _) -> None
    | (Some("kg"), _) -> None
    | (Some("ko"), Some("KR")) -> Some(makeLangId(LangKorean, SublangKorean))
    | (Some("ko"), _) -> Some(makeLangId(LangKorean, NeutralSubLanguage))
    | (Some("ku"), Some("IQ")) -> Some(makeLangId(LangCentralKurdish, SublangCentralKurdishIraq))
    | (Some("ku"), _) -> Some(makeLangId(LangCentralKurdish, NeutralSubLanguage))
    | (Some("kj"), _) -> None
    | (Some("la"), _) -> None
    | (Some("lb"), Some("LU")) -> Some(makeLangId(LangLuxembourgish, SublangLuxembourgishLuxembourg))
    | (Some("lb"), _) -> Some(makeLangId(LangLuxembourgish, NeutralSubLanguage))
    | (Some("lg"), _) -> None
    | (Some("li"), _) -> None
    | (Some("ln"), _) -> None
    | (Some("lo"), Some("LA")) -> Some(makeLangId(LangLao, SublangLaoLao))
    | (Some("lo"), _) -> Some(makeLangId(LangLao, NeutralSubLanguage))
    | (Some("lt"), Some("LT")) -> Some(makeLangId(LangLithuanian, SublangLithuanian))
    | (Some("lt"), _) -> Some(makeLangId(LangLithuanian, NeutralSubLanguage))
    | (Some("lu"), _) -> None
    | (Some("lv"), Some("LV")) -> Some(makeLangId(LangLatvian, SublangLatvianLatvia))
    | (Some("lv"), _) -> Some(makeLangId(LangLatvian, NeutralSubLanguage))
    | (Some("gv"), _) -> None
    | (Some("mk"), Some("MK")) -> Some(makeLangId(LangMacedonian, SublangMacedonianMacedonia))
    | (Some("mk"), _) -> Some(makeLangId(LangMacedonian, NeutralSubLanguage))
    | (Some("mg"), _) -> None
    | (Some("ms"), Some("BN")) -> Some(makeLangId(LangMalay, SublangMalayBruneiDarussalam))
    | (Some("ms"), Some("MY")) -> Some(makeLangId(LangMalay, SublangMalayMalaysia))
    | (Some("ms"), _) -> Some(makeLangId(LangMalay, NeutralSubLanguage))
    | (Some("ml"), Some("IN")) -> Some(makeLangId(LangMalayalam, SublangMalayalamIndia))
    | (Some("ml"), _) -> Some(makeLangId(LangMalayalam, NeutralSubLanguage))
    | (Some("mt"), Some("MT")) -> Some(makeLangId(LangMaltese, SublangMalteseMalta))
    | (Some("mt"), _) -> Some(makeLangId(LangMaltese, NeutralSubLanguage))
    | (Some("mi"), Some("NZ")) -> Some(makeLangId(LangMaori, SublangMaoriNewZealand))
    | (Some("mi"), _) -> Some(makeLangId(LangMaori, NeutralSubLanguage))
    | (Some("mr"), Some("IN")) -> Some(makeLangId(LangMarathi, SublangMarathiIndia))
    | (Some("mr"), _) -> Some(makeLangId(LangMarathi, NeutralSubLanguage))
    | (Some("mh"), _) -> None
    | (Some("mn"), Some("MN")) ->
        // ***FIXME: see if there is a way to differentiate the scripts
        Some(makeLangId(LangMongolian, SublangMongolianPRC))
    | (Some("mn"), _) -> Some(makeLangId(LangMongolian, NeutralSubLanguage))
    | (Some("na"), _) -> None
    | (Some("nv"), _) -> None
    | (Some("nd"), _) -> None
    | (Some("ne"), Some("NP")) -> Some(makeLangId(LangNepali, SublangNepaliNepal))
    | (Some("ne"), Some("IN")) -> Some(makeLangId(LangNepali, SublangNepaliIndia))
    | (Some("ne"), _) -> Some(makeLangId(LangNepali, NeutralSubLanguage))
    | (Some("ng"), _) -> None
    | (Some("nb"), _) -> Some(makeLangId(LangNorwegian, SublangNorwegianBokmal))
    | (Some("nn"), _) -> Some(makeLangId(LangNorwegian, SublangNorwegianNynorsk))
    | (Some("no"), _) ->
        // let the OS choose in the case of the 'no' macrolanguage
        Some(makeLangId(LangNorwegian, NeutralSubLanguage))
    | (Some("ii"), Some("CN")) -> Some(makeLangId(LangYi, SublangYiPRC))
    | (Some("ii"), _) -> Some(makeLangId(LangYi, NeutralSubLanguage))
    | (Some("nr"), _) -> None
    | (Some("oc"), Some("FR")) -> Some(makeLangId(LangOccitan, SublangOccitanFrance))
    | (Some("oc"), _) -> Some(makeLangId(LangOccitan, NeutralSubLanguage))
    | (Some("oj"), _) -> None
    | (Some("cu"), _) -> None
    | (Some("om"), _) -> None
    | (Some("or"), Some("IN")) -> Some(makeLangId(LangOriya, SublangOdiaIndia))
    | (Some("or"), _) -> Some(makeLangId(LangOriya, NeutralSubLanguage))
    | (Some("os"), _) -> None
    | (Some("pa"), Some("IN")) -> Some(makeLangId(LangPunjabi, SublangPunjabiIndia))
    | (Some("pa"), Some("PK")) -> Some(makeLangId(LangPunjabi, SublangPunjabiPakistan))
    | (Some("pa"), _) -> Some(makeLangId(LangPunjabi, NeutralSubLanguage))
    | (Some("pi"), _) -> None
    | (Some("fa"), Some("IR")) -> Some(makeLangId(LangPersian, SublangPersianIran))
    | (Some("fa"), _) -> Some(makeLangId(LangPersian, NeutralSubLanguage))
    | (Some("pl"), Some("PL")) -> Some(makeLangId(LangPolish, SublangPolishPoland))
    | (Some("pl"), _) -> Some(makeLangId(LangPolish, NeutralSubLanguage))
    | (Some("ps"), Some("AF")) -> Some(makeLangId(LangPashto, SublangPashtoAfghanistan))
    | (Some("ps"), _) -> Some(makeLangId(LangPashto, NeutralSubLanguage))
    | (Some("pt"), Some("BR")) -> Some(makeLangId(LangPortuguese, SublangPortugueseBrazilian))
    | (Some("pt"), Some("PT")) -> Some(makeLangId(LangPortuguese, SublangPortuguese))
    | (Some("pt"), _) -> Some(makeLangId(LangPortuguese, NeutralSubLanguage))
    | (Some("qu"), Some("BO")) -> Some(makeLangId(LangQuechua, SublangQuechuaBolivia))
    | (Some("qu"), Some("EC")) -> Some(makeLangId(LangQuechua, SublangQuechuaEcuador))
    | (Some("qu"), Some("PE")) -> Some(makeLangId(LangQuechua, SublangQuechuaPeru))
    | (Some("qu"), _) -> Some(makeLangId(LangQuechua, NeutralSubLanguage))
    | (Some("rm"), Some("CH")) -> Some(makeLangId(LangRomansh, SublangRomanshSwitzerland))
    | (Some("rm"), _) -> Some(makeLangId(LangRomansh, NeutralSubLanguage))
    | (Some("rn"), _) -> None
    | (Some("ro"), Some("RO")) -> Some(makeLangId(LangRomanian, SublangRomanianRomania))
    | (Some("ro"), _) -> Some(makeLangId(LangRomanian, NeutralSubLanguage))
    | (Some("ru"), Some("RU")) -> Some(makeLangId(LangRussian, SublangRussianRussia))
    | (Some("ru"), _) -> Some(makeLangId(LangRussian, NeutralSubLanguage))
    | (Some("sa"), Some("IN")) -> Some(makeLangId(LangSanskrit, SublangSanskritIndia))
    | (Some("sa"), _) -> Some(makeLangId(LangSanskrit, NeutralSubLanguage))
    | (Some("sc"), _) -> None
    | (Some("sd"), Some("PK")) -> Some(makeLangId(LangSindhi, SublangSindhiPakistan))
    | (Some("sd"), Some("AF")) -> Some(makeLangId(LangSindhi, SublangSindhiAfghanistan))
    | (Some("sd"), Some("IN")) -> Some(makeLangId(LangSindhi, SublangSindhiIndia))
    | (Some("sd"), _) -> Some(makeLangId(LangSindhi, NeutralSubLanguage))
    | (Some("se"), Some("FI")) -> Some(makeLangId(LangSami, SublangSamiNorthernFinland))
    | (Some("se"), Some("NO")) -> Some(makeLangId(LangSami, SublangSamiNorthernNorway))
    | (Some("se"), Some("SE")) -> Some(makeLangId(LangSami, SublangSamiNorthernSweden))
    | (Some("se"), _) -> Some(makeLangId(LangSami, NeutralSubLanguage))
    | (Some("sm"), _) -> None
    | (Some("sg"), _) -> None
    | (Some("sr"), Some("BA")) -> 
        // ***FIXME: see if there's a way to differentiate scripts
        Some(makeLangId(LangSerbian, SublangSerbianBosniaHerzegovinaLatin))
    | (Some("sr"), Some("HR")) -> Some(makeLangId(LangSerbian, SublangSerbianCroatia))
    | (Some("sr"), Some("CS")) ->
        // ***FIXME: see if there's a way to differentiate scripts
        Some(makeLangId(LangSerbian, SublangSerbianMontenegroLatin))
    | (Some("gd"), _) -> None
    | (Some("sn"), _) -> None
    | (Some("si"), Some("LK")) -> Some(makeLangId(LangSinhalese, SublangSinhaleseSriLanka))
    | (Some("si"), _) -> Some(makeLangId(LangSinhalese, NeutralSubLanguage))
    | (Some("sk"), Some("SK")) -> Some(makeLangId(LangSlovak, SublangSlovakSlovakia))
    | (Some("sk"), _) -> Some(makeLangId(LangSlovak, NeutralSubLanguage))
    | (Some("sl"), Some("SI")) -> Some(makeLangId(LangSlovenian, SublangSlovenianSlovenia))
    | (Some("sl"), _) -> Some(makeLangId(LangSlovenian, NeutralSubLanguage))
    | (Some("so"), _) -> None
    | (Some("st"), _) -> None
    | (Some("es"), Some("AR")) -> Some(makeLangId(LangSpanish, SublangSpanishArgentina))
    | (Some("es"), Some("BO")) -> Some(makeLangId(LangSpanish, SublangSpanishBolivia))
    | (Some("es"), Some("CL")) -> Some(makeLangId(LangSpanish, SublangSpanishChile))
    | (Some("es"), Some("CO")) -> Some(makeLangId(LangSpanish, SublangSpanishColombia))
    | (Some("es"), Some("CR")) -> Some(makeLangId(LangSpanish, SublangSpanishCostaRica))
    | (Some("es"), Some("DO")) -> Some(makeLangId(LangSpanish, SublangSpanishDominicanRepublic))
    | (Some("es"), Some("EC")) -> Some(makeLangId(LangSpanish, SublangSpanishEcuador))
    | (Some("es"), Some("SV")) -> Some(makeLangId(LangSpanish, SublangSpanishElSalvador))
    | (Some("es"), Some("GT")) -> Some(makeLangId(LangSpanish, SublangSpanishGuatemala))
    | (Some("es"), Some("HN")) -> Some(makeLangId(LangSpanish, SublangSpanishHonduras))
    | (Some("es"), Some("MX")) -> Some(makeLangId(LangSpanish, SublangSpanishMexican))
    | (Some("es"), Some("NI")) -> Some(makeLangId(LangSpanish, SublangSpanishNicaragua))
    | (Some("es"), Some("PA")) -> Some(makeLangId(LangSpanish, SublangSpanishPanama))
    | (Some("es"), Some("PY")) -> Some(makeLangId(LangSpanish, SublangSpanishParaguay))
    | (Some("es"), Some("PE")) -> Some(makeLangId(LangSpanish, SublangSpanishPeru))
    | (Some("es"), Some("PR")) -> Some(makeLangId(LangSpanish, SublangSpanishPuertoRico))
    | (Some("es"), Some("ES")) -> 
        // ***FIXME: check if there's a way to include sort?
        Some(makeLangId(LangSpanish, SublangSpanish))
    | (Some("es"), Some("US")) -> Some(makeLangId(LangSpanish, SublangSpanishUS))
    | (Some("es"), Some("UY")) -> Some(makeLangId(LangSpanish, SublangSpanishUruguay))
    | (Some("es"), Some("VE")) -> Some(makeLangId(LangSpanish, SublangSpanishVenezuela))
    | (Some("es"), _) -> Some(makeLangId(LangSpanish, NeutralSubLanguage))
    | (Some("su"), _) -> None
    | (Some("sw"), Some("KE")) -> Some(makeLangId(LangSwahili, SublangSwahiliKenya))
    | (Some("sw"), _) -> Some(makeLangId(LangSwahili, NeutralSubLanguage))
    | (Some("ss"), _) -> None
    | (Some("sv"), Some("FI")) -> Some(makeLangId(LangSwedish, SublangSwedishFinland))
    | (Some("sv"), Some("SE")) -> Some(makeLangId(LangSwedish, SublangSwedish))
    | (Some("sv"), _) -> Some(makeLangId(LangSwedish, NeutralSubLanguage))
    | (Some("ta"), Some("IN")) -> Some(makeLangId(LangTamil, SublangTamilIndia))
    | (Some("ta"), Some("LK")) -> Some(makeLangId(LangTamil, SublangTamilSriLanka))
    | (Some("ta"), _) -> Some(makeLangId(LangTamil, NeutralSubLanguage))
    | (Some("te"), Some("IN")) -> Some(makeLangId(LangTelugu, SublangTeluguIndia))
    | (Some("te"), _) -> Some(makeLangId(LangTelugu, NeutralSubLanguage))
    | (Some("tg"), Some("TJ")) -> Some(makeLangId(LangTajik, SublangTajikTajikistan))
    | (Some("tg"), _) -> Some(makeLangId(LangTajik, NeutralSubLanguage))
    | (Some("th"), Some("TH")) -> Some(makeLangId(LangThai, SublangThaiThailand))
    | (Some("th"), _) -> Some(makeLangId(LangThai, NeutralSubLanguage))
    | (Some("ti"), Some("ER")) -> Some(makeLangId(LangTigrinya, SublangTigrinyaEritrea))
    | (Some("ti"), Some("ET")) -> Some(makeLangId(LangTigrinya, SublangTigrinyaEthiopia))
    | (Some("ti"), _) -> Some(makeLangId(LangTigrinya, NeutralSubLanguage))
    | (Some("bo"), Some("CN")) -> Some(makeLangId(LangTibetan, SublangTibetanPRC))
    | (Some("bo"), _) -> Some(makeLangId(LangTibetan, NeutralSubLanguage))
    | (Some("tk"), Some("TM")) -> Some(makeLangId(LangTurkmen, SublangTurkmenTurkmenistan))
    | (Some("tk"), _) -> Some(makeLangId(LangTurkmen, NeutralSubLanguage))
    | (Some("tl"), _) -> None
    | (Some("tn"), Some("BW")) -> Some(makeLangId(LangTswana, SublangTswanaBotswana))
    | (Some("tn"), Some("ZA")) -> Some(makeLangId(LangTswana, SublangTswanaSouthAfrica))
    | (Some("tn"), _) -> Some(makeLangId(LangTswana, NeutralSubLanguage))
    | (Some("to"), _) -> None
    | (Some("tr"), Some("TR")) -> Some(makeLangId(LangTurkish, SublangTurkishTurkey))
    | (Some("tr"), _) -> Some(makeLangId(LangTurkish, NeutralSubLanguage))
    | (Some("ts"), _) -> None
    | (Some("tt"), Some("RU")) -> Some(makeLangId(LangTatar, SublangTatarRussia))
    | (Some("tt"), _) -> Some(makeLangId(LangTatar, NeutralSubLanguage))
    | (Some("tw"), _) -> None
    | (Some("ty"), _) -> None
    | (Some("ug"), Some("CN")) -> Some(makeLangId(LangUighur, SublangUighurPRC))
    | (Some("ug"), _) -> Some(makeLangId(LangUighur, NeutralSubLanguage))
    | (Some("uk"), Some("UA")) -> Some(makeLangId(LangUkrainian, SublangUkrainianUkraine))
    | (Some("uk"), _) -> Some(makeLangId(LangUkrainian, NeutralSubLanguage))
    | (Some("ur"), Some("IN")) -> Some(makeLangId(LangUrdu, SublangUrduIndia))
    | (Some("ur"), Some("PK")) -> Some(makeLangId(LangUrdu, SublangUrduPakistan))
    | (Some("ur"), _) -> Some(makeLangId(LangUrdu, NeutralSubLanguage))
    | (Some("uz"), Some("UZ")) -> 
        // ***FIXME: see if there's a way to differentiate scripts
        Some(makeLangId(LangUzbek, SublangUzbekLatin))
    | (Some("uz"), _) -> Some(makeLangId(LangUzbek, NeutralSubLanguage))
    | (Some("ve"), _) -> None
    | (Some("vi"), Some("VN")) -> Some(makeLangId(LangVietnamese, SublangVietnameseVietnam))
    | (Some("vi"), _) -> Some(makeLangId(LangVietnamese, NeutralSubLanguage))
    | (Some("vo"), _) -> None
    | (Some("wa"), _) -> None
    | (Some("cy"), Some("GB")) -> Some(makeLangId(LangWelsh, SublangWelshUnitedKingdom))
    | (Some("cy"), _) -> Some(makeLangId(LangWelsh, NeutralSubLanguage))
    | (Some("wo"), Some("SN")) -> Some(makeLangId(LangWolof, SublangWolofSenegal))
    | (Some("wo"), _) -> Some(makeLangId(LangWolof, NeutralSubLanguage))
    | (Some("fy"), Some("NL")) -> Some(makeLangId(LangFrisian, SublangFrisianNetherlands))
    | (Some("fy"), _) -> Some(makeLangId(LangFrisian, NeutralSubLanguage))
    | (Some("xh"), Some("ZA")) -> Some(makeLangId(LangXhosa, SublangXhosaSouthAfrica))
    | (Some("xh"), _) -> Some(makeLangId(LangXhosa, NeutralSubLanguage))
    | (Some("yi"), _) -> None
    | (Some("yo"), Some("NG")) -> Some(makeLangId(LangYoruba, SublangYorubaNigeria))
    | (Some("yo"), _) -> Some(makeLangId(LangYoruba, NeutralSubLanguage))
    | (Some("za"), _) -> None
    | (Some("zu"), Some("ZA")) -> Some(makeLangId(LangZulu, SublangZuluSouthAfrica))
    | (Some("zu"), _) -> Some(makeLangId(LangZulu, NeutralSubLanguage))
    | _ -> None
