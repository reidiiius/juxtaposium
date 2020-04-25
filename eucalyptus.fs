
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
  attune ." -h" serial @ . cr ;

: layout
  cr tabout type diadem instru ;

: engrave
  signat place layout ;

: epoch?
  utime drop ;

: miller
  epoch? serial ! ;

miller  \ initialize

: scarlet
  cr
  .\" \t ~J136L7  ~J167L2 ~J17    ~J17L2 ~J2     ~J23   ~J236    \n"
  .\" \t ~J23K6   ~J246L3 ~J26    ~J26L3 ~J26L34 ~J2K56 ~J2K56M4 \n"
  .\" \t ~J2K6    ~J2K6M5 ~J2K6L3 ~J2L3  ~J3     ~J34K6 ~J36     \n"
  .\" \t ~J3K56M4 ~J3K5M4 ~J3K6   ~J6    ~K157M6 ~K1J6  ~K256    \n"
  .\" \t ~K26     ~K26M5  ~K2J17  ~K2J6  ~K56    ~K56M4 ~K6      \n"
  .\" \t ~K6M5    ~N0     ~N167M4 ~N26L5 ~N345   ~N45L2 ~N5L2    \n"
  ;

: emerald
  cr
  .\" \t ~K135M4  ~K345M2 ~K34    ~K34M2 ~K2     ~K12   ~K125    \n"
  .\" \t ~K12J5   ~K257M1 ~K25    ~K25M1 ~K25M17 ~K2J56 ~K2J56L7 \n"
  .\" \t ~K2J5    ~K2J5L6 ~K2J5M1 ~K2M1  ~K1     ~K17J5 ~K15     \n"
  .\" \t ~K1J56L7 ~K1J6L7 ~K1J5   ~K5    ~J346L5 ~J3K5  ~J256    \n"
  .\" \t ~J25     ~J25L6  ~J2K34  ~J2K5  ~J56    ~J56L7 ~J5      \n"
  .\" \t ~J5L6    ~N0     ~N345L7 ~N25M6 ~N167   ~N67M2 ~N6M2    \n"
  ;

: catalog
  scarlet emerald ;

: help
  catalog cr
  .\" \t Example: \n"
  .\" \t\t miller s\" n0\" ~N0 cr engrave cr \n\n" ;

