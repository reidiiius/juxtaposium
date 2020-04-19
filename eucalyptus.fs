\ eucalyptus.fs
\ gforth 0.7.2

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

: signat  #H0 ;  \ retrieve specie from databank
: tabout  4 spaces ;
: specie  signat type cr ;
: headed  signat digital @ /string sequence place ;
: tailed  signat hermes /string drop digital @ sequence +place ;
: scribe  sequence count type cr ;
: pegbox  tabout headed tailed scribe ;
: ennead  9 0 ?do digital ! pegbox loop ;
: quarts  gemini vulcan copper silver jovian helios hermes saturn aquari ;
: matrix  quarts ennead ;


