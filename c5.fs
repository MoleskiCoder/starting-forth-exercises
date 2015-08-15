: c5p1 ( a b c -- )
   */ negate ;

cr
cr ." (should be -4) " 5 6 7 c5p1 .

: largest
   max max max ;

cr
cr ." (should be 123) " 6 70 123 45 largest .

: f>c ( f -- c )
   32 - 5 9 */ ;

: c>f ( c -- f )
   9 5 */ 32 + ;

: c>k ( c -- k )
   273 + ;

: k>c ( k -- c )
   273 - ;

: f>k ( f -- k )
   f>c c>k ;

: k>f ( k -- f )
   k>c c>f ;

cr
cr ." (should be -17.7) " 0 f>c .
cr ." (should be 100) " 212 f>c .
cr ." (should be -35.5) " -32 f>c .
cr ." (should be 60.8) " 16 c>f .
cr ." (should be -40) " 233 k>c .

cr .s
