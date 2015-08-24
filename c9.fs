\ Code from Chapter 2, problem 6
\ Untouched!

: CONVICTED-OF 0 ;
: HOMICIDE 20 + ;
: ARSON 10 + ;
: BOOKMAKING 2 + ;
: TAX-EVASION 5 + ;

: WILL-SERVE
   . ." YEARS" ;

CR
CONVICTED-OF ARSON HOMICIDE TAX-EVASION
WILL-SERVE

\ Problem 1, Multiply next word to give "counts"

: COUNTS ( total n -- total )
   ' ( total n vector )
   ROT ( n vector total )
   ROT ( vector total n )
   ( vector total n ) 0 DO ( vector total )
      ( vector total ) OVER ( vector total vector )
      ( vector total vector ) EXECUTE ( vector total )
   LOOP
   SWAP ( total vector )
   DROP ; ( total )

CR
CONVICTED-OF BOOKMAKING 3 COUNTS TAX-EVASION
WILL-SERVE
