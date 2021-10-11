using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sator.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tamanos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPedidos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposProductos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposProductos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    num_fijo = table.Column<int>(type: "int", nullable: false),
                    num_cel = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    cartaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sucursales_Cartas_cartaid",
                        column: x => x.cartaid,
                        principalTable: "Cartas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoidid = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fec_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    generoid = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    num_cel = table.Column<float>(type: "real", nullable: false),
                    admin = table.Column<bool>(type: "bit", nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Generos_generoid",
                        column: x => x.generoid,
                        principalTable: "Generos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_TiposIds_tipoidid",
                        column: x => x.tipoidid,
                        principalTable: "TiposIds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoproductoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Productos_TiposProductos_tipoproductoid",
                        column: x => x.tipoproductoid,
                        principalTable: "TiposProductos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horapedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaentrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoid = table.Column<int>(type: "int", nullable: true),
                    empleadoid = table.Column<int>(type: "int", nullable: true),
                    formapagoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_FormaPagos_formapagoid",
                        column: x => x.formapagoid,
                        principalTable: "FormaPagos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Personas_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Personas_empleadoid",
                        column: x => x.empleadoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_TipoPedidos_tipoid",
                        column: x => x.tipoid,
                        principalTable: "TipoPedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<float>(type: "real", nullable: false),
                    Productoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ingredientes_Productos_Productoid",
                        column: x => x.Productoid,
                        principalTable: "Productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductosTamanos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tamanoid = table.Column<int>(type: "int", nullable: true),
                    precio = table.Column<int>(type: "int", nullable: false),
                    Cartaid = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: true),
                    Pedidoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosTamanos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductosTamanos_Cartas_Cartaid",
                        column: x => x.Cartaid,
                        principalTable: "Cartas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductosTamanos_Pedidos_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductosTamanos_Tamanos_tamanoid",
                        column: x => x.tamanoid,
                        principalTable: "Tamanos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredientes_Productoid",
                table: "Ingredientes",
                column: "Productoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteid",
                table: "Pedidos",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_empleadoid",
                table: "Pedidos",
                column: "empleadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_formapagoid",
                table: "Pedidos",
                column: "formapagoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_tipoid",
                table: "Pedidos",
                column: "tipoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_generoid",
                table: "Personas",
                column: "generoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_tipoidid",
                table: "Personas",
                column: "tipoidid");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_tipoproductoid",
                table: "Productos",
                column: "tipoproductoid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosTamanos_Cartaid",
                table: "ProductosTamanos",
                column: "Cartaid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosTamanos_Pedidoid",
                table: "ProductosTamanos",
                column: "Pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosTamanos_tamanoid",
                table: "ProductosTamanos",
                column: "tamanoid");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_cartaid",
                table: "Sucursales",
                column: "cartaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "ProductosTamanos");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Tamanos");

            migrationBuilder.DropTable(
                name: "Cartas");

            migrationBuilder.DropTable(
                name: "TiposProductos");

            migrationBuilder.DropTable(
                name: "FormaPagos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TipoPedidos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "TiposIds");
        }
    }
}
