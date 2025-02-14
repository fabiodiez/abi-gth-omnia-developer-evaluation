#!/bin/bash

# Aguarda o PostgreSQL estar pronto (ajuste o tempo conforme necessário)
sleep 10

# Tenta executar as migrations repetidamente
until dotnet ef database update --connection "Server=ambev.developerevaluation.database;Database=developer_evaluation;User Id=developer;Password=ev@luAt10n;" --project "src/Ambev.DeveloperEvaluation.ORM" --startup-project "src/Ambev.DeveloperEvaluation.WebApi"
do
  echo "Tentando aplicar as migrations novamente..."
  sleep 5
done

echo "Migrations aplicadas com sucesso!"

# Inicia a aplicação .NET
dotnet src/Ambev.DeveloperEvaluation.WebApi/Ambev.DeveloperEvaluation.WebApi.dll