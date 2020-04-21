
require digraphite.fs

 0 constant hermes
 6 constant jovian
12 constant copper
15 constant saturn
18 constant gemini
21 constant helios
27 constant silver
30 constant aquari
33 constant vulcan

create digita 128 allot
create kronic 128 allot

create signat 256 allot
create serial 384 allot
create sequen 512 allot

~N0 signat place  \ initialize

: tabout  4 spaces ;
: specie  signat count ;
: headed  specie digita @ /string sequen place ;
: tailed  specie hermes /string drop digita @ sequen +place ;
: scribe  sequen count type cr ;
: pegbox  tabout headed tailed scribe ;
: cyclop  0 ?do digita ! pegbox loop ;
: epoch?  utime drop ;

: ennead  9 cyclop ;
: quarts  gemini vulcan copper silver jovian helios hermes saturn aquari ;
: matrix  quarts ennead ;

: hexad   6 cyclop ;
: eadgbe  copper silver jovian helios vulcan copper ;
: guitar  eadgbe hexad ;

: pentad  5 cyclop ;
: cgdae   hermes helios jovian silver copper ;
: cello   cgdae pentad ;

