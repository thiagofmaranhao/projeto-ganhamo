# projeto-ganhamo
Projeto de estudo com objetivo de utilizar a seguinte Stack de Tecnologias

- Asp.Net Core 5 Web API
- .Net Core 5 Background Services
- GCP Cloud Storage
- GCP BigTable
- GCP Pub/Sub
- MongoDB 
- Datadog
- Conteinerização

## Diagrama de Componentes do Projeto

Para o projeto de estudo foi escolhido o desenvolvimento de um serviço de Pedidos, organizado da seguinte forma:

1. API exposta na internet recebendo requisições de novos pedidos
    - API armazena o request no GCP Cloud Storage e publica mensagem no tópico do GCP Pub/Sub
2. Worker responsável pelo processamento do pedido
    - Worker assina o tópico do GCP Pub/Sub para obter a mensagem envidada pela API, com a chave do pedido obtém a requisição no GCP Cloud Storage para processar o pedido.
    - O pedido é armazenado no GCP BigTable e no MongoDB

![Arquitetura proposta](/docs/projeto-ganhamo-diagrama.png "Arquitetura proposta")