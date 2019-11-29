grammar Penguinese;
/*
 * Parser Rules
 */
// ? = 0 o 1
// * = 0 o muchos
// + = 1 o muchos

//	inicio
start			: FUNC MAIN OP CP OCB bloqueCodigo CCB ;	//func main() { <codigo> }

//	bloque de codigo
bloqueCodigo	: ( expresion )+ ;	//	por ahora requiere por lo menos una expresion
expresion		: ( declararVar | math | ciclo | imprimirValor | escribirValor |HALT ) TERM ;	// ciclos terminan con ';' tambien
declararVar		: ( decVar | asignVar ) ;
asignVar		: tipoVarS nombreVar EQUALS valorVar #asignarValor
				| tipoVarS nombreVar EQUALS variable #asignarVariable; 
asignSimple		: variable EQUALS (valorNum | variable ) ;

//	definicion de variables
decVar			: tipoVar nombreVar ( COM nombreVar)* ;	//	number x , y , z, ..... n
tipoVar			: ARRAYOF tipoVarS OBR NUMERAL CBR 
				| tipoVarS ;
tipoVarS		: (CHARACTER | DOUBLE | BOOLEAN | NUMBER | TEXT) ;
nombreVar		: (WORD | LETTER) ;
variable		: nombreVar #nombreSimple
				| nombreVar OBR (nombreVar | valorEntero) CBR #nombreArreglo ;

//	inicializacion variables
valorVar		: ( valorEntero | valorDec | valorChar | valorString |valorBool ) ;
valorEntero		: NUMERAL ;
valorDec		: NUMERAL DEC NUMERAL ;
valorChar		: CHAR ;
valorString		: STRING ;
valorBool		: (TRUE | FALSE) ;

//	operaciones matematicas
math			: variable EQUALS valorNum (mathSeq)+
				| variable EQUALS variable (mathSeq)+ ;
mathSeq			: OPERATOR valorNum #seqNum
				| OPERATOR variable #seqVar ;
valorNum		: valorEntero | valorDec ;

//	ciclos de codigo
ciclo			: IF OP condicional CP THEN OCB bloqueCodigo CCB #cicloIf
				| WHILE OP condicional CP THEN OCB bloqueCodigo CCB  #cicloWhile
				| FOR OP seccionFor CP OCB bloqueCodigo CCB	#cicloFor ;
condicional		: valorCond COND valorCond (condSeq)* ;
valorCond		: ( variable | NUMERAL | valorChar | valorString | valorDec ) ;
condSeq			: SepCOND valorCond COND valorCond ;
seccionFor		: asignVar TERM condicional TERM math ;

//	in/out
imprimirValor	: READ COL COL ( variable | valorString ) ;
//nombreValores	: ( variable | valorString ) ( imprimirSeq )* ;
//imprimirSeq		: PLUS ( variable | valorString ) ;
escribirValor	: WRITE COL COL ( variable ) ;

/*
 * Lexer Rules
 */
fragment LOWERCASE  : [a-z] ;
fragment UPPERCASE  : [A-Z] ;
NUMERAL				: [0-9]+ ;	//	any number of digits
OPERATOR			: ( '+' | '-' | '*' | '/' ) ;
PLUS				: '+' ;
COND				: ( '=>' | '==' | '<=' | '<' | '>=' | '>' | '!=' );
SepCOND				: ( '&&' | '||' );
TERM				: ';' ;
COM					: ',' ;
OP					: '(' ;
CP					: ')' ;
OBR					: '[' ;
CBR					: ']' ;
OCB					: '{' ;
CCB					: '}' ;
DEC					: '.' ;
EQUALS				: '=' ;
COL					: ':' ;
TRUE				: 'true' ;
FALSE				: 'false' ;
IF					: 'if' ;
THEN				: 'then' ;
WHILE				: 'while' ;
FOR					: 'for' ;
FUNC				: 'func' ;
MAIN				: 'main' ;
DOUBLE				: 'double' ;
CHARACTER			: 'character' ;
TEXT				: 'text' ;
NUMBER				: 'number' ;
ARRAYOF				: 'arrayof' ;
BOOLEAN				: 'boolean' ;
HALT				: 'NOOT NOOT' ;
RETURN				: 'regresar' ;
READ				: 'imprimirVar' ;
WRITE				: 'escribirVar';
LETTER              : (LOWERCASE | UPPERCASE) ;
CHAR				: '"' LETTER '"' ;
WORD                : (LOWERCASE | UPPERCASE | NUMERAL)* ;
STRING				: '"' .*? '"' ;//	anything betwixt '"'s
WHITESPACE          : (' '|'\t'|'\r'? '\n' | '\r')+ -> skip ;


//math			: variable EQUALS valorNum (mathSeqMD)* (mathSeqPM)* #operacionVeN
//				| variable EQUALS variable (mathSeqMD)* (mathSeqPM)* #operacionVeV ;
//mathSeqMD		: OPERATORMD valorNum #seqNum
//				| OPERATORMD variable #seqVar ;
//mathSeqMD		: OPERATORPM valorNum 
//				| OPERATORPM variable ;
//OPERATORMD			: ( '*' | '/' ) ;
//OPERATORPM			: ( '+' | '-' ) ;