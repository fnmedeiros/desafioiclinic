Neste pacote se encontram o script para a criação do banco de dados MySql("Script criação banco.sql"), uma pasta com os arquivos .csv e .xml para serem importados pela aplicação("Arquivos para importar"), um pacote zipado com a aplicação já compilada e suas respectivas  DLLs e arquivos de configuração e o código fonte do projeto dentro da pasta "Importador".
O projeto esta configurado para se conectar com um banco de dados MySql em localhost, com o usuário root e sem senha, caso seja necessário alterar a conexão com o banco é preciso alterar a connectionstring que se encontra dentro do arquivo "Connection.vb" do projeto.
Lembrando que antes de executar a aplicação o banco de dados deve estar criado, caso contrario a aplicação exibirá um erro tratado de falha ao se conectar com a base de dados e irá encerrar a aplicação.

Atenciosamente
Felipe Novaes Medeiros