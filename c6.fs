: NOT
 0= ;

: STAR
   ." *" ;

: STARS ( n -- )
   0 DO STAR LOOP ;

CR
10 STARS

: BOX ( width height -- )
   0 DO DUP STARS CR LOOP DROP ;

CR
CR 10 3 BOX

: SPACE
   ."  " ;

: SPACES ( n -- )
   0 DO SPACE LOOP ;

: \STARS ( height -- )
   0 DO
     I 1+ SPACES
     10 STARS CR
   LOOP ;

CR
3 \STARS

: /STARS ( height -- )
   DUP
   0 DO
     DUP I - SPACES
     10 STARS CR
   LOOP
   DROP ;

CR
3 /STARS

: /STARS2 ( height -- )
   BEGIN
     DUP SPACES
     10 STARS CR
   1- DUP 0= UNTIL
   DROP ;

CR
3 /STARS2

: DIAMOND ( width -- )
   2 + DUP
   1 DO
     DUP I - 2 / SPACES
     I STARS CR
   2 +LOOP
   2 - DUP
   1 SWAP DO
     DUP I - 2 + 2 / SPACES 
     I STARS CR
   -2 +LOOP
   DROP ;

: DIAMONDS ( count -- )
   0 DO
     19 DIAMOND
   LOOP ;

CR
2 DIAMONDS

: R% 10 */ 5 + 10 / ;

: DOUBLED
   21 1 DO CR
     ." year " I 2 U.R
     2DUP R% + DUP ."    balance " .
     DUP 2000 > IF CR CR ." more than doubled in "
                    I . ." years "  LEAVE  THEN
                                 LOOP 2DROP ;

CR
6 1000 DOUBLED

: ** ( n power -- )
    DUP 1 = NOT IF
      OVER ROT ROT 1 DO
        OVER *
      LOOP
      SWAP
    THEN
    DROP ;

CR CR
2 1 ** ." result is:" .  CR
2 2 ** ." result is:" .  CR
2 3 ** ." result is:" .  CR
2 4 ** ." result is:" .  CR
2 5 ** ." result is:" .  CR
2 6 ** ." result is:" .  CR

CR .S

