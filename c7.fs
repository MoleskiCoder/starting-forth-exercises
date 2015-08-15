: n-max
   0 begin
     1+ dup
   0< until
   1- ;

cr
n-max . cr

: ring
  7 emit ." beep" cr ;

: rings
  0 do ring loop ;

cr
3 rings

: f>c ( f -- c )
   -320 m+ 5 9 m*/ ;

: c>f ( c -- f )
   9 5 m*/ 320 m+ ;

: c>k ( c -- k )
   2732 m+ ;

: k>c ( k -- c )
   -2732 m+ ;

: f>k ( f -- k )
   f>c c>k ;

: k>f ( k -- f )
   k>c c>f ;

cr
\ cr ." (should be -17.7) " 0.0 f>c .
\ cr ." (should be 100) " 212.0 f>c .
\ cr ." (should be -35.5) " -32.0 f>c .
\ cr ." (should be 60.8) " 16.0 c>f .
\ cr ." (should be -40) " 233.0 k>c .

( 7x^2 + 20x + 5 )
: quadratic ( n -- n )
   dup 20 * 5 + swap
   dup * 7 *
   + ;

cr
2 quadratic . cr
3 quadratic . cr
4 quadratic . cr
5 quadratic . cr
6 quadratic . cr

.s cr
