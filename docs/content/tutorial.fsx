(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
LANGID Mappings Tutorial
========================

*)

#r "LANGIDMappings.dll"

open LANGIDMappings

LANGIDMappings.LANGIDToIso639Dash1(0x0409us) // returns Some("en-US")
LANGIDMappings.LANGIDToIso639Dash1(0xFFFFus) // returns None
LANGIDMappings.Iso639Dash1ToLANGID("en-US")  // returns Some(0x0409us)
LANGIDMappings.Iso639Dash1ToLANGID("zz-ZZ")  // returns None
