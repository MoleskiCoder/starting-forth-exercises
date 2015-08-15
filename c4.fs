: not 0= ;

cr
cr 1 0= not . ." should be true"
cr 0 0= not . ." should be false"
cr 200 0= not . ." should be true"

: card ( n -- )
   18 >= if
     ." alcoholic beverages permitted"
   else
     ." under age"
   then ;

cr
cr 10 dup . card
cr 17 dup . card
cr 18 dup . card
cr 19 dup . card

: sign.test ( n -- )
   dup 0> if ." positive" then
   dup 0= if ." zero" then
       0< if ." negative" then ;

cr
cr ." (should be negative) " -1 sign.test
cr ." (should be zero) " 0 sign.test
cr ." (should be positive) " 1 sign.test

: star ( -- )
   42 emit ;

: stars ( n -- )
   dup 0= if drop else 0 do star loop then ;

cr
cr 0 stars
cr 1 stars
cr 5 stars

: within ( n low-limit high-limit -- within )
   rot dup rot < ( ll n lt )
   rot rot < ( lt ht )
   and ;

cr
cr ." (should be true) " 5 4 6 within .
cr ." (should be false) " 4 5 8 within .

: guess ( secret guess -- secret / secret guess -- )
   2dup < if ." too high" then
   2dup > if ." too low" then
   over = if drop ." success!" then
   cr ;

: speller ( n -- )
   dup abs
   dup rot
       = not if ." negative " then
   dup 4 = if ." four" drop else
   dup 3 = if ." three" drop else
   dup 2 = if ." two" drop else
   dup 1 = if ." one" drop else
       0= if ." zero" drop else
         ." out of range"
   then then then then then ;

cr
cr ." (should be two) " 2 speller
cr ." (should be negative four) " -4 speller
cr ." (should be out of range) " 7 speller

: trap ( secret low high -- secret )
   2dup ( secret low high low high )
   = if
     ." you got it!"
     2drop drop ( -- )
   else
     rot dup >r
     rot rot
     within if
       ." between "
     else
       ." not between"
     then
     r>
   then ;

cr
391
cr ." (should be between) " 0 1000 trap
cr ." (should be between) " 330 660 trap
cr ." (should be not between) " 440 550 trap
cr ." (should be between) " 330 440 trap
cr ." (should be you got it!) " 391 391 trap

cr .s
