module LANGIDMappings.Tests

open LANGIDMappings
open NUnit.Framework

let private langidEnglishUs = 0x0409us

[<Test>]
let ``makeLangId constructs proper LANGIDs from a language and sublanguage`` () = 
    Assert.AreEqual(0x0409us, LANGIDMappings.makeLangId(0x09us, 0x01us))

[<Test>]
let ``langIdPrimaryLanguage returns the correct primary language from a LANGID`` () = 
    Assert.AreEqual(0x09us, LANGIDMappings.langidPrimaryLanguage(langidEnglishUs))

[<Test>]
let ``langIdSubLanguage returns the correct sublanguage from a LANGID`` () = 
    Assert.AreEqual(0x01us, LANGIDMappings.langidSubLanguage(langidEnglishUs))

[<Test>]
let ``converting a LANGID to ISO-639-1 without a mapping returns None`` () = 
    Assert.AreEqual(None, LANGIDMappings.LANGIDToIso639Dash1(0xFFFFus))

[<Test>]
let ``can convert a LANGID mapping to an ISO-639-1 code`` () =
  let isoCodeOpt = LANGIDMappings.LANGIDToIso639Dash1(langidEnglishUs)
  Assert.AreEqual(Some("en-US"), isoCodeOpt)

[<Test>]
let ``converting an ISO-639-1 code to a LANGID without a mapping returns None`` () = 
    Assert.AreEqual(None, LANGIDMappings.Iso639Dash1ToLANGID("zz-ZZ"))

[<Test>]
let ``can convert an ISO-639-1 code to a LANGID mapping`` () = 
   let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en-US")
   Assert.AreEqual(Some(langidEnglishUs), langIdOpt)

[<Test>]
let ``converting an ISO-639-1 code to a LANGID is case insensitive for the country`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en-us")
    Assert.AreEqual(Some(langidEnglishUs), langIdOpt)

[<Test>]
let ``converting an ISO-639-1 code to a LANGID is case insensitive for the language`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("EN-us")
    Assert.AreEqual(Some(langidEnglishUs), langIdOpt)

[<Test>]
let ``can convert an ISO-639-1 code that only contains a language`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en")
    Assert.AreEqual(Some(LANGIDMappings.makeLangId(0x09us, 0x00us)), langIdOpt)
