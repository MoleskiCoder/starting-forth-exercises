: C5P1 ( a b c -- )
   */ NEGATE ;

CR
CR ." (should be -4) " 5 6 7 C5P1 .

: LARGEST
   MAX MAX MAX ;

CR
CR ." (should be 123) " 6 70 123 45 LARGEST .

: F>C ( F -- C )
   32 - 5 9 */ ;

: C>F ( C -- F )
   9 5 */ 32 + ;

: C>K ( C -- K )
   273 + ;

: K>C ( K -- C )
   273 - ;

: F>K ( F -- K )
   F>C C>K ;

: K>F ( K -- F )
   K>C C>F ;

CR
CR ." (should be -17.7) " 0 F>C .
CR ." (should be 100) " 212 F>C .
CR ." (should be -35.5) " -32 F>C .
CR ." (should be 60.8) " 16 C>F .
CR ." (should be -40) " 233 K>C .

CR .S

