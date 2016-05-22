## MAC a PSW, algorítmo utilizado en algún Banco para las claves de administrador local.

C# + Xamarin Studio.

la clave de administrador se basa en la dirección fisica de red del equipo, se manda como politica gpo desde un servidor active directory de la organización. Para mantener el control de las claves, se calcula de la siguiente forma:

Si tenemos una MAC Address la cual por ejemplo es:

12-34-56-78-90-AB

Invertimos el orden de todos los char:

BA-09-87-65-43-21

Sumamos 2 char a cada char, excepto al numero 8, y 9:

DC-29-89-87-65-43

Luego Agregamos una E Uppercase luego del Segundo bloque de 6 bits, y un 4 luego del 4 bloque, quedando así:

DC29E876544321 <- Tu Clave.