using ConsumerViaCep;
using static System.Console;

WriteLine("Digite o CEP que deseja consultar: ");
var cep = ReadLine();
var enderecoUrl = $"https://viacep.com.br/ws/{cep}/json/";

WriteLine("Consultando o endereço na url: " + enderecoUrl);

var httpClient = new HttpClient();

try
{
    //Classe para mensagem de resposta HTTP
    //await e asyns são usados para não travar a aplicação enquanto aguarda a resposta da API
    //Como as consultas não são instantâneas, o await permite que a aplicação continue executando outras tarefas enquanto aguarda a resposta da API

    //Bloco abaixo é um exemplo de como consumir uma api de forma assíncrona, utilizando o HttpClient para enviar uma requisição GET e receber a resposta da API. A resposta é então lida como uma string e exibida no console.
    HttpResponseMessage response = await httpClient.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();
    //WriteLine("Resposta da API: " + respostaApi);

    //deserializando a resposta da API para um objeto do tipo Endereço
    Endereco endereco = System.Text.Json.JsonSerializer.Deserialize<Endereco>(respostaApi);

    WriteLine("Endereço consultado: ");
    WriteLine("CEP: " + endereco.cep);
    WriteLine("Logradouro: " + endereco.logradouro);
    WriteLine("Complemento: " + endereco.complemento);
    WriteLine("Bairro: " + endereco.bairro);
    WriteLine("Cidade: " + endereco.localidade);
    WriteLine("UF: " + endereco.uf);
    WriteLine("Estado: " + endereco.estado);
}
catch (Exception ex)
{
    WriteLine("Ocorreu um erro ao consultar o endereço: " + ex.Message);
}