using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Gabriel_TCM
{
    public static class Mensagem
    {
        public enum TipoMensagem
        {
            Alerta = 1,
            Sucesso = 2,
            Erro = 3,
            Enviado= 4,
        }
        public static void ExibirAlerta(this System.Web.UI.Page page,TipoMensagem tipo, string texto)
        {
            switch (tipo)
            {
                case Mensagem.TipoMensagem.Alerta:
                    texto = "ATENÇÂO! \\n\\n" + texto;
                    break;
                case Mensagem.TipoMensagem.Erro:
                    texto = "ERRO! \\n\\n" + texto;
                    break;
                case Mensagem.TipoMensagem.Sucesso:
                    texto = "SUCESSO! \\n\\n" + texto;
                    break;
                case Mensagem.TipoMensagem.Enviado:
                    texto = "Parabéns!\\n\\n" + texto;
                    break;
            }
            string script = "alert('" + texto + "');";
            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "Alert", script, true);
        }
    }
}