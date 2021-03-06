lexer grammar Unicode;

// Warning many of the definitions in this file are actually incomplete

fragment Unicode_Zs
	: '\u0020' // SPACE
	| '\u00A0' // NO_BREAK SPACE
	| '\u1680' // OGHAM SPACE MARK
	| '\u180E' // MONGOLIAN VOWEL SEPARATOR
	| '\u2000' // EN QUAD
	| '\u2001' // EM QUAD
	| '\u2002' // EN SPACE
	| '\u2003' // EM SPACE
	| '\u2004' // THREE_PER_EM SPACE
	| '\u2005' // FOUR_PER_EM SPACE
	| '\u2006' // SIX_PER_EM SPACE
	| '\u2007' // FIGURE SPACE
	| '\u2008' // PUNCTUATION SPACE
	| '\u2009' // THIN SPACE
	| '\u200A' // HAIR SPACE
	| '\u202F' // NARROW NO_BREAK SPACE
	| '\u205F' // MEDIUM MATHEMATICAL SPACE
	| '\u3000' // IDEOGRAPHIC SPACE
	;


fragment Unicode_Lu
	: '\u0041'..'\u005A' // LATIN CAPITAL LETTER A_Z
	| '\u00C0'..'\u00DE' // ACCENTED CAPITAL LETTERS
	| '\u0391'..'\u039A' // GREEK CAPITAL LETTERS
	;

fragment Unicode_Ll
	: '\u0061'..'\u007A' // LATIN SMALL LETTER a_z
	| '\u03B1'..'\u03C9' // GREEK SMALL LETTERS
	;

fragment Unicode_Lt
	: '\u01C5' // LATIN CAPITAL LETTER D WITH SMALL LETTER Z WITH CARON
	| '\u01C8' // LATIN CAPITAL LETTER L WITH SMALL LETTER J
	| '\u01CB' // LATIN CAPITAL LETTER N WITH SMALL LETTER J
	| '\u01F2' // LATIN CAPITAL LETTER D WITH SMALL LETTER Z
	;

fragment Unicode_Lm
	: '\u02B0'..'\u02EE' // MODIFIER LETTERS
	;

fragment Unicode_Lo
	: '\u01BB' // LATIN LETTER TWO WITH STROKE
	| '\u01C0' // LATIN LETTER DENTAL CLICK
	| '\u01C1' // LATIN LETTER LATERAL CLICK
	| '\u01C2' // LATIN LETTER ALVEOLAR CLICK
	| '\u01C3' // LATIN LETTER RETROFLEX CLICK
	| '\u0294' // LATIN LETTER GLOTTAL STOP
	;

fragment Unicode_Nl
	: '\u16EE' // RUNIC ARLAUG SYMBOL
	| '\u16EF' // RUNIC TVIMADUR SYMBOL
	| '\u16F0' // RUNIC BELGTHOR SYMBOL
	| '\u2160' // ROMAN NUMERAL ONE
	| '\u2161' // ROMAN NUMERAL TWO
	| '\u2162' // ROMAN NUMERAL THREE
	| '\u2163' // ROMAN NUMERAL FOUR
	| '\u2164' // ROMAN NUMERAL FIVE
	| '\u2165' // ROMAN NUMERAL SIX
	| '\u2166' // ROMAN NUMERAL SEVEN
	| '\u2167' // ROMAN NUMERAL EIGHT
	| '\u2168' // ROMAN NUMERAL NINE
	| '\u2169' // ROMAN NUMERAL TEN
	| '\u216A' // ROMAN NUMERAL ELEVEN
	| '\u216B' // ROMAN NUMERAL TWELVE
	| '\u216C' // ROMAN NUMERAL FIFTY
	| '\u216D' // ROMAN NUMERAL ONE HUNDRED
	| '\u216E' // ROMAN NUMERAL FIVE HUNDRED
	| '\u216F' // ROMAN NUMERAL ONE THOUSAND
	;

fragment Unicode_Mn
	: '\u0300' // COMBINING GRAVE ACCENT
	| '\u0301' // COMBINING ACUTE ACCENT
	| '\u0302' // COMBINING CIRCUMFLEX ACCENT
	| '\u0303' // COMBINING TILDE
	| '\u0304' // COMBINING MACRON
	| '\u0305' // COMBINING OVERLINE
	| '\u0306' // COMBINING BREVE
	| '\u0307' // COMBINING DOT ABOVE
	| '\u0308' // COMBINING DIAERESIS
	| '\u0309' // COMBINING HOOK ABOVE
	| '\u030A' // COMBINING RING ABOVE
	| '\u030B' // COMBINING DOUBLE ACUTE ACCENT
	| '\u030C' // COMBINING CARON
	| '\u030D' // COMBINING VERTICAL LINE ABOVE
	| '\u030E' // COMBINING DOUBLE VERTICAL LINE ABOVE
	| '\u030F' // COMBINING DOUBLE GRAVE ACCENT
	| '\u0310' // COMBINING CANDRABINDU
	;

fragment Unicode_Mc
	: '\u0903' // DEVANAGARI SIGN VISARGA
	| '\u093E' // DEVANAGARI VOWEL SIGN AA
	| '\u093F' // DEVANAGARI VOWEL SIGN I
	| '\u0940' // DEVANAGARI VOWEL SIGN II
	| '\u0949' // DEVANAGARI VOWEL SIGN CANDRA O
	| '\u094A' // DEVANAGARI VOWEL SIGN SHORT O
	| '\u094B' // DEVANAGARI VOWEL SIGN O
	| '\u094C' // DEVANAGARI VOWEL SIGN AU
	;

fragment Unicode_Cf
	: '\u00AD' // SOFT HYPHEN
	| '\u0600' // ARABIC NUMBER SIGN
	| '\u0601' // ARABIC SIGN SANAH
	| '\u0602' // ARABIC FOOTNOTE MARKER
	| '\u0603' // ARABIC SIGN SAFHA
	| '\u06DD' // ARABIC END OF AYAH
	;

fragment Unicode_Pc
	: '\u005F' // LOW LINE
	| '\u203F' // UNDERTIE
	| '\u2040' // CHARACTER TIE
	| '\u2054' // INVERTED UNDERTIE
	| '\uFE33' // PRESENTATION FORM FOR VERTICAL LOW LINE
	| '\uFE34' // PRESENTATION FORM FOR VERTICAL WAVY LOW LINE
	| '\uFE4D' // DASHED LOW LINE
	| '\uFE4E' // CENTRELINE LOW LINE
	| '\uFE4F' // WAVY LOW LINE
	| '\uFF3F' // FULLWIDTH LOW LINE
	;

fragment Unicode_Nd
	: '\u0030' // DIGIT ZERO
	| '\u0031' // DIGIT ONE
	| '\u0032' // DIGIT TWO
	| '\u0033' // DIGIT THREE
	| '\u0034' // DIGIT FOUR
	| '\u0035' // DIGIT FIVE
	| '\u0036' // DIGIT SIX
	| '\u0037' // DIGIT SEVEN
	| '\u0038' // DIGIT EIGHT
	| '\u0039' // DIGIT NINE
	;