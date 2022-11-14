# Principais protocolos de comunicação da internet

## Protocolos http | Web Socket

## PROTOCOLO HTTP

HyperText Transfer Protocol (HTTP)

O HTTP faz a comunicação entre o `Cliente` e o `Servidor`

O `Browser` -> Implementa o cliente HTTP
O `Servidor` -> Host objetos web

## MENSAGENS HTTP - `Request & Response`

- `GET` - Solicita um recurso do servidor
- `HEAD` - GET sem corpo de resposta
- `POST` - Submete uma entidade a um recurso
- `PUT` - Substituição de recursos pelos dados da requisição
- `DELETE` - Remoção de um recurso
- `TRACE` - Chamada de loop-back a um determinado recurso
- `OPTION` - Opções de comunicação com recurso
- `CONNECT` - Tunelamento identificado pelo recurso
- `PATCH` - Modificação parcial

## HTTP Response
- `200 OK` - Request bem sucedida e objeto enviado
- `301 Moved Permanently` - Objeto realocado nova URL no campo Location
- `400 Bad Request` - Resposta genérica - Servidor não endenteu a mensagem
- `404 Not Found` - O documento solicitado é inexistente
- `505 HTTP Version Not Supported:` - Versão do protocolo não suportada pelo servidor
  
# Classificação do `Status Code`

- `Information` response (`100 - 199`)
- `Sucessful` response (`200 - 299`)
- `Redirection` response (`300 - 399`)
- `Client error` response (`400 - 400`)
- `Server error` response (`500 - 599`)

## Web Distributed Authoring and Versioning - `WebDav`

- 102 - Processing
- 207 - Multi-status
- 208 - Already Reported
- 422 - Unprecessable Entity
- 423 - Locked
- 424 - Failed Dependecy
  
 ## Para que serve Cookie e Cache?

 ### O que são Cookies?
 Pequenos pedaços ou blocos de dados criados e utilizados pelo servidor para persistir dados no dispositivo do cliente.

 `ESPECIFICAÇÃO: RFC 6265`

 ### Web Cache?

 Web Cache é o mesmo que Proxy server

 
 