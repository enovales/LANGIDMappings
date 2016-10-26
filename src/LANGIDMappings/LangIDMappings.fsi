module LANGIDMappings

// Public interfaces
val LANGIDToIso639Dash1 : langid:uint16 -> string option
val Iso639Dash1ToLANGID : iso:string -> uint16 option

// Test-related functions
val internal langidPrimaryLanguage : langid:uint16 -> uint16
val internal langidSubLanguage : langid:uint16 -> uint16
val internal makeLangId : primary:uint16 * sub:uint16 -> uint16


