Neste pacote se encontram o script para a cria��o do banco de dados MySql("Script cria��o banco.sql"), uma pasta com os arquivos .csv e .xml para serem importados pela aplica��o("Arquivos para importar"), um pacote zipado com a aplica��o j� compilada e suas respectivas  DLLs e arquivos de configura��o e o c�digo fonte do projeto dentro da pasta "Importador".
O projeto esta configurado para se conectar com um banco de dados MySql em localhost, com o usu�rio root e sem senha, caso seja necess�rio alterar a conex�o com o banco � preciso alterar a connectionstring que se encontra dentro do arquivo "Connection.vb" do projeto.
Lembrando que antes de executar a aplica��o o banco de dados deve estar criado, caso contrario a aplica��o exibir� um erro tratado de falha ao se conectar com a base de dados e ir� encerrar a aplica��o.

Atenciosamente
Felipe Novaes Medeiros