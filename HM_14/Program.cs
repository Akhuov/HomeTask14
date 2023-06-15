using H_m_lib;

var Ramis = new Person();
var Nigora= new Person();
Ramis.Name = "Ramis";
Nigora.Name = "Nigora";
Ramis.jinsi = true;
Nigora.jinsi = false;


int a = 0;
const int b = 1;


Ramis.Marry(Nigora);

Person.divorse(Ramis,Nigora);

Person.Marry(Ramis, Nigora);