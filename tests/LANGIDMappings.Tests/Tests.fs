module LANGIDMappings.Tests

open Expecto

let private langidEnglishUs = 0x0409us

[<Tests>]
let tests = 
  testList "LANGIDMappings" [
    testCase "makeLangId constructs proper LANGIDs from a language and sublanguage" <| 
      fun () -> Expect.equal 0x0409us (LANGIDMappings.makeLangId(0x09us, 0x01us)) "makeLangId should return 0x0409us"

    testCase "langIdPrimaryLanguage returns the correct primary language from a LANGID" <|
      fun () -> Expect.equal 0x09us (LANGIDMappings.langidPrimaryLanguage langidEnglishUs) "langidPrimaryLanguage should return 0x09us"

    testCase "langIdSubLanguage returns the correct sublanguage from a LANGID" <|
      fun () -> Expect.equal 0x01us (LANGIDMappings.langidSubLanguage langidEnglishUs) "langidSubLanguage should return 0x01us"

    testCase "converting a LANGID to ISO-639-1 without a mapping returns None" <|
      fun () -> Expect.equal None (LANGIDMappings.LANGIDToIso639Dash1 0xFFFFus) "LANGIDToIso639Dash1 should return None"

    testCase "can convert a LANGID mapping to an ISO-639-1 code" <|
      fun () ->
        Expect.equal (Some "en-US") (LANGIDMappings.LANGIDToIso639Dash1 langidEnglishUs) "LANGIDToIso639Dash1 should return the LANGID for US English"

    testCase "converting an ISO-639-1 code to a LANGID without a mapping returns None" <|
      fun () -> 
        Expect.equal None (LANGIDMappings.Iso639Dash1ToLANGID "zz-ZZ") "Iso639Dash1ToLANGID should return None for unknown languages"

    testCase "can convert an ISO-639-1 code to a LANGID mapping" <|
      fun () -> Expect.equal (Some langidEnglishUs) (LANGIDMappings.Iso639Dash1ToLANGID "en-US") "Iso639Dash1ToLANGID should return the LANGID for en-US"

    testCase "converting an ISO-639-1 code to a LANGID is case insensitive for the country" <|
      fun () -> Expect.equal (Some langidEnglishUs) (LANGIDMappings.Iso639Dash1ToLANGID "en-us") "Iso639Dash1ToLANGID should return the LANGID for en-US"

    testCase "converting an ISO-639-1 code to a LANGID is case insensitive for the language" <|
      fun () -> Expect.equal (Some langidEnglishUs) (LANGIDMappings.Iso639Dash1ToLANGID "EN-us") "Iso639Dash1ToLANGID should return the LANGID for en-US"

    testCase "can convert an ISO-639-1 code that only contains a language" <|
        fun () -> Expect.equal (Some (LANGIDMappings.makeLangId(0x09us, 0x00us))) (LANGIDMappings.Iso639Dash1ToLANGID "en") "Iso639Dash1ToLANGID should return English without a region"
  ]

