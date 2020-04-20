
s" digraphite.fs" included

 0 constant hermes
 6 constant jovian
12 constant copper
15 constant saturn
18 constant gemini
21 constant helios
27 constant silver
30 constant aquari
33 constant vulcan

variable digital 128 allot

create sequence 512 allot

create signat 256 allot

~H0 signat place  \ initialize

: tabout  4 spaces ;
: specie  signat count ;
: headed  specie digital @ /string sequence place ;
: tailed  specie hermes /string drop digital @ sequence +place ;
: scribe  sequence count type cr ;
: pegbox  tabout headed tailed scribe ;
: cyclop  0 ?do digital ! pegbox loop ;

: ennead  9 cyclop ;
: quarts  gemini vulcan copper silver jovian helios hermes saturn aquari ;
: matrix  quarts ennead ;

: hexad   6 cyclop ;
: eadgbe  copper silver jovian helios vulcan copper ;
: guitar  eadgbe hexad ;

: pentad  5 cyclop ;
: cgdae   hermes helios jovian silver copper ;
: cello   cgdae pentad ;

