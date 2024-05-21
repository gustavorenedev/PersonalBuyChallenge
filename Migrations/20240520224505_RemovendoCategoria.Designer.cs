﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using PersonalBuy.Data;

#nullable disable

namespace PersonalBuy.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240520224505_RemovendoCategoria")]
    partial class RemovendoCategoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonalBuy.Models.CategoriaProduto", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("descricao_categoria");

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("nome_categoria");

                    b.HasKey("CategoriaId");

                    b.ToTable("TB_CategoriaProduto");
                });

            modelBuilder.Entity("PersonalBuy.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("cep_cliente");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("cpf_cliente");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("email_cliente");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("endereco_cliente");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("nome_cliente");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("telefone_cliente");

                    b.HasKey("ClienteId");

                    b.ToTable("TB_Cliente");
                });

            modelBuilder.Entity("PersonalBuy.Models.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompraId"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("data_compra");

                    b.Property<int>("PedidoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CompraId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("TB_Compra");
                });

            modelBuilder.Entity("PersonalBuy.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("data_pedido");

                    b.Property<int>("StatusPedido")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("status_pedido");

                    b.Property<double>("TotalPedido")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("total_pedido");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("TB_Pedido");
                });

            modelBuilder.Entity("PersonalBuy.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("descricao_produto");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("nome_produto");

                    b.Property<double>("PrecoProduto")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("preco_produto");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("TB_Produto");
                });

            modelBuilder.Entity("PersonalBuy.Models.Compra", b =>
                {
                    b.HasOne("PersonalBuy.Models.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonalBuy.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("PersonalBuy.Models.Pedido", b =>
                {
                    b.HasOne("PersonalBuy.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("PersonalBuy.Models.Produto", b =>
                {
                    b.HasOne("PersonalBuy.Models.CategoriaProduto", "CategoriaProduto")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
