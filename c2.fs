: 4reverse
   swap 2swap swap ;

cr 1 2 3 4 4reverse .s 2drop 2drop

: 3dup
   dup 2over rot ;

cr 1 2 3 3dup .s 2drop 2drop 2drop

: four ( c a b -- result )
   swap ( c b a )
   dup dup ( c b a a a )
   * ( c b a a^2 )
   swap ( c b a^2 a )
   rot ( c a^2 a b )
   * ( c a^2 a*b )
   + + ;

cr 4 2 3 four .

: five ( a b -- result )
   2dup ( a b a b )
   - ( a b a-b )
   rot ( b a-b a )
   rot ( a-b a b )
   + ( a-b a+b )
   / ;

cr 2 1 five .
cr 3 2 five .

: convicted-of 0 ;
: homicide 20 + ;
: arson 10 + ;
: bookmaking 2 + ;
: tax-evasion 5 + ;

: will-serve . ."  years" ;

convicted-of arson homicide tax-evasion
will-serve

: egg-cartons
   12 /mod cr . ." cartons and " . ." left over." ;

12 egg-cartons
24 egg-cartons
5 egg-cartons
25 egg-cartons

