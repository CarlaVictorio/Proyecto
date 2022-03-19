#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[]) {
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	// Atenderemos peticiones infinitamente
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		// Ahora recibimos su peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibida una peticiÃ³n\n");
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		//Escribimos la peticion en la consola
		
		//Separamos el código del nombre de usuario
		printf ("La peticiÃ³n es: %s\n",peticion);
		char *p = strtok(peticion, "/");
		int codigo =  atoi (p);
		p = strtok( NULL, "/");
		char usuario[20];
		strcpy (usuario, p);
		printf ("Codigo: %d, Nombre: %s\n", codigo, usuario);
		
		if (codigo == 1){ //Piden el número de partidas ganadas del usuario
			
			//Se completa el servicio en la versión: VersionConNuevoServicio
		}
		else if (codigo == 2){ //Piden los tablones en los que ha jugado el usuario
			
			//Se completa el servicio en la versión: VersionConNuevoServicio
			
		}
		else if (codigo == 3){ //Piden el id del usuario
			
			//Se completa el servicio en la versión: VersionConNuevoServicio
			
		}			
			// Enviamos la respuesta
			write (sock_conn,respuesta, strlen(respuesta));
			
			// Se acabo el servicio para este cliente
			close(sock_conn); 
	}
	
}

