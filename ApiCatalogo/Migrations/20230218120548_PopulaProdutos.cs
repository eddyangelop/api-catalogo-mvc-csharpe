﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " + 
                "Values('Coca-cola Diet','Refrigerante de Cola 350ml',5.45,'cocacola.jpg', 50, now(), 1)");

            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Lanche de Atum','Sanduiche de Atum c/ maionese',8.50,'sanduiche.jpg', 10, now(), 2)");

            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
               "Values('Pudim 100g','Doce a base de leite condensado 100g',6.75,'pudim.jpg', 20, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
