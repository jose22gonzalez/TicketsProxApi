﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketsProxApi.Data;

#nullable disable

namespace TicketsProxApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketsProxApi.Models.Asientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdSecciones")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Reservado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Asientos");
                });

            modelBuilder.Entity("TicketsProxApi.Models.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TicketsProxApi.Models.Eventos", b =>
                {
                    b.Property<int>("IdEventos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEventos"));

                    b.Property<int>("CapacidadTotal")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaEvento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LugarEvento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEvento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoEvento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEventos");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("TicketsProxApi.Models.Reservas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Asiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Evento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("TicketsProxApi.Models.Secciones", b =>
                {
                    b.Property<int>("IdSecciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSecciones"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<int>("IdEventos")
                        .HasColumnType("int");

                    b.Property<string>("NombreSeccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("IdSecciones");

                    b.ToTable("Secciones");
                });
#pragma warning restore 612, 618
        }
    }
}
