module LANGIDMappings.Tests

open LANGIDMappings
open Xunit

let private langidEnglishUs = 0x0409us

[<Fact>]
let ``makeLangId constructs proper LANGIDs from a language and sublanguage`` () = 
    Assert.Equal(0x0409us, LANGIDMappings.makeLangId(0x09us, 0x01us))

[<Fact>]
let ``langIdPrimaryLanguage returns the correct primary language from a LANGID`` () = 
    Assert.Equal(0x09us, LANGIDMappings.langidPrimaryLanguage(langidEnglishUs))

[<Fact>]
let ``langIdSubLanguage returns the correct sublanguage from a LANGID`` () = 
    Assert.Equal(0x01us, LANGIDMappings.langidSubLanguage(langidEnglishUs))

[<Fact>]
let ``converting a LANGID to ISO-639-1 without a mapping returns None`` () = 
    Assert.Equal(None, LANGIDMappings.LANGIDToIso639Dash1(0xFFFFus))

[<Fact>]
let ``can convert a LANGID mapping to an ISO-639-1 code`` () =
    let isoCodeOpt = LANGIDMappings.LANGIDToIso639Dash1(langidEnglishUs)
    Assert.Equal(Some("en-US"), isoCodeOpt)

[<Fact>]
let ``converting an ISO-639-1 code to a LANGID without a mapping returns None`` () = 
    Assert.Equal(None, LANGIDMappings.Iso639Dash1ToLANGID("zz-ZZ"))

[<Fact>]
let ``can convert an ISO-639-1 code to a LANGID mapping`` () = 
   let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en-US")
   Assert.Equal(Some(langidEnglishUs), langIdOpt)

[<Fact>]
let ``converting an ISO-639-1 code to a LANGID is case insensitive for the country`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en-us")
    Assert.Equal(Some(langidEnglishUs), langIdOpt)

[<Fact>]
let ``converting an ISO-639-1 code to a LANGID is case insensitive for the language`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("EN-us")
    Assert.Equal(Some(langidEnglishUs), langIdOpt)

[<Fact>]
let ``can convert an ISO-639-1 code that only contains a language`` () = 
    let langIdOpt = LANGIDMappings.Iso639Dash1ToLANGID("en")
    Assert.Equal(Some(LANGIDMappings.makeLangId(0x09us, 0x00us)), langIdOpt)
