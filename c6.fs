: star
   ." *" ;

: stars ( n -- )
   0 do star loop ;

cr
10 stars

: box ( width height -- )
   0 do dup stars cr loop drop ;

cr
cr 10 3 box

: space
   ."  " ;

: spaces ( n -- )
   0 do space loop ;

: \stars ( height -- )
   0 do
     i 1+ spaces
     10 stars cr
   loop ;

cr
3 \stars

: /stars ( height -- )
   dup
   0 do
     dup i - spaces
     10 stars cr
   loop
   drop ;

cr
3 /stars

: /stars2 ( height -- )
   begin
     dup spaces
     10 stars cr
   1- dup 0= until
   drop ;

cr
3 /stars2

: diamond ( width -- )
   2 + dup
   1 do
     dup i - 2 / spaces
     i stars cr
   2 +loop
   2 - dup
   1 swap do
     dup i - 2 + 2 / spaces 
     i stars cr
   -2 +loop
   drop ;

: diamonds ( count -- )
   0 do
     19 diamond
   loop ;

cr
2 diamonds

: r% 10 */ 5 + 10 / ;

: doubled
   21 1 do cr
     ." year " i 2 u.r
     2dup r% + dup ."    balance " .
     dup 2000 > if cr cr ." more than doubled in "
                    i . ." years "  leave  then
                                 loop 2drop ;

cr
6 1000 doubled

: ** ( n power -- )
    dup 1 <> if
      over rot rot 1 do
        over *
      loop
      swap
    then
    drop ;

cr cr
2 1 ** ." result is:" .  cr
2 2 ** ." result is:" .  cr
2 3 ** ." result is:" .  cr
2 4 ** ." result is:" .  cr
2 5 ** ." result is:" .  cr
2 6 ** ." result is:" .  cr

cr .s
