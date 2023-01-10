# GerenciadorFolhaPagamento_Frontend
  A aplicação frontend também segue uma arquitetura simplificada como a API, contendo apenas a camada web, uma de services que define as chamadas para a API e objetos esperados, uma de domínio apenas as interfaces dos services e viewmodels, e uma camada client que manipula as conexões com a API usando HttpClient. Referente ao desafio realizei algumas mudanças de acordo com o andamento e necessidade:

- Uma delas foi que projetei o sistema para trabalhar com arquivos no formato .xlsx, pois infelizmente eu deixei escapar nos requisitos que o formato era CSV e já havia codificado bastante. Porém como a entrada de dados é praticamente a mesma, mantive no formato excel .xlsx

- O sistema possuí um menu de parâmetros em que deve ser preenhcido o diretório onde os arquivos estão prontos para processamento:

![image](https://user-images.githubusercontent.com/45474333/211456612-a976a34c-ce8a-425e-85e7-d836dd3b8893.png)

  Para processar os arquivos basta ir no menu "Processamentos" e iniciar a execução:
  
  ![image](https://user-images.githubusercontent.com/45474333/211456951-529391d8-e7f5-4a79-8112-88a9727723c7.png)


  O resultado dos processamentos será exibido num texto json conforme solicitado, conforme imagem a seguir:
  
  ![image](https://user-images.githubusercontent.com/45474333/211457111-e1f10a08-a3d1-4fe7-af9f-726c805c7b1a.png)
  
  Há também um botão para limpar os dados para poder reiniciar o processo. As principais tecnologias usadas neste projeto front foi .NET 5, css e javascript com jQuery. Na api esta presente a string de conexão com o banco, fiquem a vontade para poder acessar é somente um banco teste criado para o desafio técnico.
