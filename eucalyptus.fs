
s" digraphite.fs" required

: tabout
  4 spaces ;

: specie
  signat count ;

: headed
  specie digita @ /string sequen place ;

: tailed
  specie hermit /string drop digita @ sequen +place ;

: scribe
  sequen count type cr ;

: pegbox
  tabout headed tailed scribe ;

: cyclop
  0
  ?do    digita ! pegbox
  loop ;

: ennead
  9 cyclop ;

: quarts
  gemini vulcan copper silver jovian helios hermit saturn aquari ;

: matrix
  quarts ennead ;

: hexad
  6 cyclop ;

: eadgbe
  copper silver jovian helios vulcan copper ;

: guitar
  eadgbe hexad ;

: pentad
  5 cyclop ;

: cgdae
  hermit helios jovian silver copper ;

: cello
  cgdae pentad ;

: instru
  guitar ;  \ select tuning

: attune
  ." -eadgbe" ;  \ display tuning

: diadem
  attune ." -h" serial ? cr ;

: layout
  cr tabout type diadem instru ;

: engrave
  signat place layout ;

: epoch?
  utime drop ;

: miller
  epoch? serial ! ;

miller  \ initialize

: catalog
  scarlet emerald ;

: help
  catalog cr
  .\" \t Example: \n"
  .\" \t\t miller s\" n0\" ~N0 cr engrave cr \n\n" ;

