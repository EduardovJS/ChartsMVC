using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraficosASPNETMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Nome", "Valor", "Tipo" },
                values: new object[] { "Mouse Gamer Sem Fio Logitech G PRO X SUPERLIGHT", "R$ 649,90", "Mouse" }
                );
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Nome", "Valor", "Tipo" },
                values: new object[] { "Razer Mouse para jogos sem fio DeathAdder V3 Pro", "R$ 1.597,90", "Mouse" }
                );
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Nome", "Valor", "Tipo" },
                values: new object[] { "ATTACK SHARK Mouse para jogos sem fio R1", "R$ 191,00", "Mouse" }
                );
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Nome", "Valor", "Tipo" },
                values: new object[] { "Teclado Wooting 60he - 60% Analog Keyboard Lacrado", "R$ 2.499,99", "Teclado" }
                );
            migrationBuilder.InsertData(
               table: "Produtos",
               columns: new[] { "Nome", "Valor", "Tipo" },
               values: new object[] { "Hyper X, TECLADO MECANICO HYPERX ALLOY ORIGINS 60, Preto com iluminação RGB, HKBO1S-RB-US/G", "R$ 549,99", "Teclado" }
               );


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
          table: "Produtos",
          keyColumn: "Nome",
          keyValues: new object[] { "Mouse", "Teclado", "Headset" });
        }
    }

}
