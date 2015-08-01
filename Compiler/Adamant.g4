grammar Adamant;

import AdamantPreprocessor;

options
{
	language=CSharp;
}

compilationUnit
	: usingStatement*
	  // globalAttribute*
	  namespaceMemberDeclaration*
	  EOF
	;

usingStatement
	: 'using' namespaceName ';'
	;

namespaceName
	: Identifier ('.' Identifier)*
	;

namespaceMemberDeclaration
	: namespaceDeclaration
	//| typeDeclaration
	;

namespaceDeclaration
	: 'namespace' namespaceName '{' usingStatement* namespaceMemberDeclaration* '}'
	;