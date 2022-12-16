// Cria uma nova instância do objeto XMLHttpRequest
var xhttp = new XMLHttpRequest();

// Configura a solicitação para usar o método GET e enviar a solicitação para o URL especificado
xhttp.open("GET", "https://www.example.com/api/data", true);

// Define uma função de retorno de chamada para ser executada quando a resposta estiver pronta
xhttp.onreadystatechange = function() {
  if (this.readyState == 4 && this.status == 200) {
    // Executa a lógica desejada com os dados recebidos na resposta
  }
};

// Envia a solicitação
xhttp.send();