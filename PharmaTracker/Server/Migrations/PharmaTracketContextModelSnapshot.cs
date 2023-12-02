﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmaTracker.Server.DAL;

#nullable disable

namespace PharmaTracker.Server.Migrations
{
    [DbContext(typeof(PharmaTracketContext))]
    partial class PharmaTracketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("PharmaTracker.Shared.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            Contraseña = "admin",
                            Dirección = "Calle 789",
                            Email = "admin@gmail.com",
                            Nombre = "Admin"
                        });
                });

            modelBuilder.Entity("PharmaTracker.Shared.AdminDetalle", b =>
                {
                    b.Property<int>("AdminDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdminTelefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminTipos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminDetalleId");

                    b.HasIndex("AdminId");

                    b.ToTable("AdminDetalle");
                });

            modelBuilder.Entity("PharmaTracker.Shared.CestaDCompra", b =>
                {
                    b.Property<int>("CestaDCompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Pago")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrecioTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TotalProductos")
                        .HasColumnType("INTEGER");

                    b.HasKey("CestaDCompraId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProductoId");

                    b.ToTable("CestaDCompra");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Contraseña = "cliente",
                            Dirección = "Calle 123",
                            Email = "cliente@gmail.com",
                            Nombre = "Juan Perez",
                            Teléfono = "1234567890"
                        });
                });

            modelBuilder.Entity("PharmaTracker.Shared.DetalleLaboratorioProducto", b =>
                {
                    b.Property<int>("DetalleLaboratorioProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Laboratorios")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductosProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleLaboratorioProductoId");

                    b.HasIndex("ProductosProductoId");

                    b.ToTable("DetalleLaboratorioProducto");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Facturas", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("NCF")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoFactura")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("FacturaId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CestaDCompraId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Existencia")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FacturasFacturaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Precio")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.HasIndex("CestaDCompraId");

                    b.HasIndex("FacturasFacturaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedor");

                    b.HasData(
                        new
                        {
                            VendedorId = 1,
                            Contraseña = "vendedor",
                            Dirección = "Calle 456",
                            Email = "vendedor@gmail.com",
                            Nombre = "Pedro Castillo"
                        });
                });

            modelBuilder.Entity("PharmaTracker.Shared.VendedorDetalle", b =>
                {
                    b.Property<int>("VendedorDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendedorIdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendedorTelefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VendedorTipos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VendedorDetalleId");

                    b.HasIndex("VendedorId");

                    b.ToTable("VendedorDetalle");
                });

            modelBuilder.Entity("PharmaTracker.Shared.AdminDetalle", b =>
                {
                    b.HasOne("PharmaTracker.Shared.Admin", null)
                        .WithMany("AdminDetalle")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmaTracker.Shared.CestaDCompra", b =>
                {
                    b.HasOne("PharmaTracker.Shared.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaTracker.Shared.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Cliente");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("PharmaTracker.Shared.DetalleLaboratorioProducto", b =>
                {
                    b.HasOne("PharmaTracker.Shared.Productos", null)
                        .WithMany("detalleLabProducto")
                        .HasForeignKey("ProductosProductoId");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Productos", b =>
                {
                    b.HasOne("PharmaTracker.Shared.CestaDCompra", null)
                        .WithMany("productos")
                        .HasForeignKey("CestaDCompraId");

                    b.HasOne("PharmaTracker.Shared.Facturas", null)
                        .WithMany("ListaProductos")
                        .HasForeignKey("FacturasFacturaId");
                });

            modelBuilder.Entity("PharmaTracker.Shared.VendedorDetalle", b =>
                {
                    b.HasOne("PharmaTracker.Shared.Vendedor", null)
                        .WithMany("VendedorDetalle")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Admin", b =>
                {
                    b.Navigation("AdminDetalle");
                });

            modelBuilder.Entity("PharmaTracker.Shared.CestaDCompra", b =>
                {
                    b.Navigation("productos");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Facturas", b =>
                {
                    b.Navigation("ListaProductos");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Productos", b =>
                {
                    b.Navigation("detalleLabProducto");
                });

            modelBuilder.Entity("PharmaTracker.Shared.Vendedor", b =>
                {
                    b.Navigation("VendedorDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
