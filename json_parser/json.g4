grammar json;

@header {
	using antlr_test.Abstract;
	using antlr_test.Builders;
	namespace Math_so;
}
@members {
	IValueBuilder _builder;
}
/*
 * Parser Rules   tokens
 */ 
 compileUnit
	:	value* EOF {_builder = $value.builder;};  

value returns [IValueBuilder builder]:					
	  object	{ $builder = $object.builder; }
	| array		{ $builder = $array.builder; }
	| literal	{ $builder = $literal.builder; };

object returns [IValueBuilder builder]	//scope { ObjectBuilder objBuilder; }
	   locals [ObjectBuilder objBuilder = new ObjectBuilder()]
	   //{ $builder = $object::objBuilder = new ObjectBuilder(); }				
		@init {
			$builder = $objBuilder;
		}:	
	'{' 
		objectProperty? 
		(',' objectProperty)*  
	'}'; 
objectProperty:
	key=(IDENT | STRING)  
	':' value {
	$object::objBuilder.SetProperty($key.text, $value.builder);
};

array returns [IValueBuilder builder]:
{$builder = new ArrayBuilder();}					
	'[' 
		(a=value { ((ArrayBuilder)$builder).Push($a.builder); })? 
		(',' b=value { ((ArrayBuilder)$builder).Push($b.builder); })* 
	']';

literal returns [IValueBuilder builder]:
	  NUMBER	{ $builder = new ConstantBuilder(float.Parse($NUMBER.text));	}
	| STRING	{ $builder = new ConstantBuilder($STRING.text.Substring(1,$STRING.text.Length-2));	}
	| TRUE		{ $builder = new ConstantBuilder(true);	}
	| FALSE		{ $builder = new ConstantBuilder(false); };

  
/*
 * Lexer Rules
 */
STRING:					'\'' (~('\n'|'\r'|'\''))*'\''	|
						'"' (~('\n'|'\r'|'"'))*'"';
TRUE:					T R U E;
FALSE:					F A L S E;
IDENT:					IDENT_START IDENT_MID*; 
NUMBER:					DIGIT+ | DIGIT* '.' DIGIT*; 

WHITESPACE:				('\t' | ' ' | '\r' | '\n')+ -> channel(HIDDEN);
fragment IDENT_START:	'_' | LETTER;
fragment IDENT_MID:		IDENT_START | DIGIT;
fragment LETTER:		'a'..'z' | 'A'..'Z'; 
fragment DIGIT:			'0'..'9';

fragment T:				'T' | 't';	
fragment R:				'R' | 'r';	
fragment U:				'U' | 'u';	
fragment E:				'E' | 'e';	

fragment F:				'F' | 'f';	
fragment A:				'A' | 'a';	
fragment L:				'L' | 'l';	
fragment S:				'S' | 's';	
// E in true

