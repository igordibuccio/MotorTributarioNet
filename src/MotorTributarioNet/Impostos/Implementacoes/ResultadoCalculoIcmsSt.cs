﻿//                      Projeto: Motor Tributario                                                  
//          Biblioteca C# para Cálculos Tributários Do Brasil
//                    NF-e, NFC-e, CT-e, SAT-Fiscal     
//                                                                                                                                           
//  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la 
// sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  
// Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) 
// qualquer versão posterior.                                                   
//                                                                              
//  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   
// NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      
// ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor
// do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              
//                                                                              
//  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto
// com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  
// no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          
// Você também pode obter uma copia da licença em:                              
// https://github.com/AutomacaoNet/MotorTributarioNet/blob/master/LICENSE      

using System;

namespace MotorTributarioNet.Impostos.Implementacoes
{
    public class ResultadoCalculoIcmsSt : IResultadoCalculoIcmsSt
    {
        public decimal BaseCalculoOperacaoPropria { get; }
        public decimal ValorIcmsProprio { get; }
        public decimal BaseCalculoIcmsSt { get; }
        public decimal ValorIcmsSt { get; }

        public ResultadoCalculoIcmsSt(decimal baseCalculoOperacaoPropria, decimal valorIcmsProprio, decimal baseCalculoIcmsSt, decimal valorIcmsSt)
        {
            BaseCalculoOperacaoPropria = Math.Round(baseCalculoOperacaoPropria, 2);
            ValorIcmsProprio = Math.Round(valorIcmsProprio, 2);
            BaseCalculoIcmsSt = Math.Round(baseCalculoIcmsSt, 2);
            ValorIcmsSt = Math.Round(valorIcmsSt, 2);
        }
    }
}