# tcc-prefeitura


# Adicionando migrations
1.	cd Prefeitura.Geral.Persistencia
2.	dotnet ef migrations add init 
3.	dotnet ef database update


# Publicando imagem de api no heroku
heroku container:push web -a prefeitura-geral-api
heroku container:release web -a prefeitura-geral-api

# Publicando imagem de front no heroku
heroku container:push web -a prefeitura-front
heroku container:release web -a prefeitura-front


