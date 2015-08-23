\ pies

variable pies

: RESET-PIES
   0 pies !  ;

: BAKE-PIE
   1 pies +! ;

: EAT-PIE
   pies @ 0= if
     ." what pie?"
   else
     -1 pies +!
     ." thank you!"
   then ;

cr
reset-pies
eat-pie
bake-pie
eat-pie

variable frozen-pies

: reset-frozen-pies
   0 frozen-pies ! ;

: freeze-pies
   pies @ reset-pies frozen-pies ! ;
   
cr
reset-frozen-pies
bake-pie cr
bake-pie cr
freeze-pies cr
pies ?
frozen-pies ? cr

\ current forth number base

: .base
   base @ dup
   decimal .
   base ! ;

cr
decimal .base cr
hex .base cr

decimal

\ pencils

0 constant red
1 constant blue
2 constant green
3 constant orange

variable pencil-store 3 cells allot

: pencils
   cells pencil-store + ;

23 red pencils !
15 blue pencils !
12 green pencils !
0 orange pencils !

cr
red pencils ? cr
blue pencils ? cr
green pencils ? cr
orange pencils ? cr

\ histogram display

variable histogram 9 cells allot

: histogram-element
   cells histogram + ;

: star
   [char] * emit ;

: stars
   0 do star loop ;

: histogram-row
   histogram-element @ stars ;

: plot-row
   dup 1+ . histogram-row cr ;

: plot
   10 0 do i plot-row loop ;

2 0 histogram-element !
4 1 histogram-element !
6 2 histogram-element !
8 3 histogram-element !
10 4 histogram-element !
20 5 histogram-element !
30 6 histogram-element !
40 7 histogram-element !
25 8 histogram-element !
15 9 histogram-element !

cr
plot

\ oxo board

variable oxo-data 8 allot

: new-oxo-game ( -- )
   oxo-data 9 erase ;

: oxo-element ( index -- address )
   oxo-data + ;

: x-piece ( -- )
   [char] x emit ;

: o-piece ( -- )
   [char] o emit ;

: bar ( -- )
   [char] | emit ;

: hyphen ( -- )
   [char] - emit ;

: hyphens ( n -- )
   0 do hyphen loop ;

: oxo-element? ( n -- )
   ( cannot test against -1 because we store as a byte 255 )
   oxo-element c@ dup
   0= if space drop else
   1 = if x-piece else
     o-piece
   then then ;

: hyphen-row ( -- )
   11 hyphens ;

: oxo? ( -- )
   9 0 do
     space i oxo-element?
     i 1+ 3 mod 0= if
       cr
       i 7 < if hyphen-row cr then
     else
       space bar
     then
   loop
   cr ;

: player! ( index value -- )
   swap oxo-element c! oxo? cr ;

: x! ( n -- )
   1- 1 player! ;

: o! ( n -- )
   1- -1 player! ;

cr

new-oxo-game

4 x!
3 o!

.s
