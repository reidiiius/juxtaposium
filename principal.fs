
require eucalyptus.fs

epoch? kronic !

: instru  guitar ;
: attune  s" -eadgbe-m" ;
: diadem  attune serial ! serial @ type kronic @ . cr ;

cr cr
tabout s" h0" type diadem
~H0 signat place instru
cr cr
tabout s" j3" type diadem
~j3 signat place instru
cr cr

bye

