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

\ Problem 5, An array of executable words

CR CR

: FIRST
   ." HELLO, I SPEAK FORTH." ;

: SECOND
   10 0 DO I . LOOP ;

: STAR
   [CHAR] * EMIT ;

: STARS
   0 DO STAR LOOP ;

: THIRD
   CR
   5 0 DO
      10 STARS CR
   LOOP ;

: FOURTH
   4 4 + DROP ;

: FIFTH
   5 5 + DROP ;

VARIABLE 'SOMETHING 4 CELLS ALLOT

: SOMETHING-CELL
   CELLS 'SOMETHING + ;

' FIRST 0 SOMETHING-CELL !
' SECOND 1 SOMETHING-CELL !
' THIRD 2 SOMETHING-CELL !
' FOURTH 3 SOMETHING-CELL !
' FIFTH 4 SOMETHING-CELL !

: DO-SOMETHING
   1- SOMETHING-CELL @ EXECUTE ;

1 DO-SOMETHING CR
2 DO-SOMETHING CR
3 DO-SOMETHING CR
4 DO-SOMETHING CR
5 DO-SOMETHING CR

.S

