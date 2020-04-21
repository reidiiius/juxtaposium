
require eucalyptus.fs

epoch? kronic !

: instru  guitar ;
: attune  s" -eadgbe-m" ;
: diadem  attune serial ! serial @ type kronic @ . cr ;

cr cr
tabout s" n0" type diadem
~N0 signat place instru
cr cr
tabout s" j3" type diadem
~J3 signat place instru
cr cr

bye

