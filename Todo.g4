grammar Todo;

// Parser rules

compileUnit: expression (NEWLINE | EOF);

expression:
    create
    | show 
    | delete
    | finish;

show: 'show';
create: 'add' description 'finish' 'at' time;
finish: 'finish' '#' id;
delete: 'delete' '#' id;

filter: 
    'all' (filterTime | filterCompletion)?
    | (filterTime filterCompletion);
filterTime: 'today' | 'yesterday';
filterCompletion: 'complete' | 'incomplete';
description: TEXT;
time: TIME;
id: NUMBER;

// Lexer rules

fragment LOWERCASE: [a-z];
fragment UPPERCASE: [A-Z];
fragment DIGIT: [0-9];

NUMBER: (DIGIT)+;
TIME: DIGIT DIGIT ':' DIGIT DIGIT;
WORD: (LOWERCASE | UPPERCASE | DIGIT)+;
TEXT: '"' .*? '"';
WHITESPACE: (' '|'\t')+ -> skip;
NEWLINE: ('\r'? '\n' | '\r')+;