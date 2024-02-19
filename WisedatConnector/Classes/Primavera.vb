Imports System.ComponentModel
Imports System.Runtime.Intrinsics.Arm
Public Class Primavera
    Public Enum OpcaoSN
        <Description("Sim")>
        S
        <Description("Não")>
        N
    End Enum

    Public Enum TipoLinha
        <Description("F- Financeira")>
        F
        <Description("A - Analítico")>
        A
        <Description("O - Centros de Custo")>
        O
        <Description("C - Plano Funcional")>
        C
        <Description("M - Linha de pendente")>
        M
    End Enum

    Public Enum TipoModulo
        <Description("V - Vendas")>
        V
        <Description("S - Stocks")>
        S
        <Description("C - Compras")>
        C
        <Description("M - Contas Correntes")>
        M
        <Description("B – Bancos")>
        B
        <Description("P – Recursos Humanos")>
        P
        <Description("I - Imobilizado")>
        I
        <Description("L- Contabilidade (Sempre que forem documentos de módulos terceiros)")>
        L
    End Enum

    Public Enum NaturezaDoc
        <Description("D - Débito")>
        D
        <Description("C - Crédito")>
        C
    End Enum

    Public Enum TipoEntidade
        <Description("C - Cliente")>
        C
        <Description("F - Fornecedor")>
        F
        <Description("D – Outro Devedor")>
        D
        <Description("R – Outro Credor")>
        R
        <Description("B – Conta Bancária")>
        B
        <Description("S – Sócio")>
        S
        <Description("E – Entidade Pública")>
        E
        <Description("I – Fornecedor de Imobilizado")>
        I
        <Description("T – Consultor")>
        T
        <Description("A – Subscritor de Capital")>
        A
        <Description("G – Obrigacionista")>
        G
        <Description("L – Credor Subscritores Não Liberadas")>
        L
        <Description("U – Funcionário")>
        U
        <Description("N – Sindicato")>
        N
        <Description("P – Independente. Esta propriedade, em conjugação com a anterior, indica qual o código do tipo de entidade em causa.")>
        P
    End Enum

    Public Enum TipoTerceiro
        <Description("C - Cliente")>
        C
        <Description("F - Fornecedor")>
        F
        <Description("O - Outros")>
        O
    End Enum

    Public Enum TipoOperacao
        <Description("0 - Vendas de meios de transporte")>
        Zero = 0
        <Description("1 - Não compreendidas no tipo 4")>
        Um = 1
        <Description("4 - Operações triangulares")>
        Quatro = 4
    End Enum


    Public Property Versao As String = "CBLLP10.03"
    Public Property Reflete_Classes_de_IVA As OpcaoSN
    Public Property Reflete_Analitica As OpcaoSN
    Public Property Reflete_Centros_de_Custo As OpcaoSN
    Public Property Tipo_de_Linha As TipoLinha
    Public Property Modulo As TipoModulo
    Public Property Data As String ' Formato: DDMM
    Public Property Conta_a_movimentar As String
    Public Property Diario As String
    Public Property Num_Diario As String
    Public Property Documento As String
    Public Property Num_Documento As String = "-1" ' Se negativo (-1), é numerado p/ CBL.
    Public Property Descricao As String
    Public Property Valor_Origem As String
    Public Property Natureza As NaturezaDoc
    Public Property Entidade As String
    Public Property Tipo_de_Entidade As String
    Public Property Classe_IVA As String
    Public Property Conta_Origem As String
    Public Property Lote As String
    Public Property Classe_Selo As String
    Public Property Quantidade_de_Selo As String
    Public Property Reflete_Classes_de_Selo As OpcaoSN
    Public Property Reflete_Plano_Funcional As OpcaoSN
    Public Property Terceiro As String
    Public Property Tipo_Terceiro As TipoTerceiro
    Public Property Mes_de_Recolha As String
    Public Property Tipo_Operacao As TipoOperacao
    Public Property Ano As String
    Public Property Moeda_Origem As String
    Public Property Cambio_Origem As String = "EUR"
    Public Property Cambio_Base As String
    Public Property Cambio_Alternativo As String
    Public Property Tipo_Afectacao As String
    Public Property Reflete_Fluxos As String
    Public Property Classe_IVA_Auto_Liquidacao As String
    Public Property Percentagem_Nao_Dedutivel As String
    Public Property Tipo_de_Lancamento As String
    Public Property Data_do_Documento As String
    Public Property Num_do_Documento_Externo As String
    Public Property Observacoes As String
    Public Property Item_de_Tesouraria As String
    Public Property Reflete_COPE As String
    Public Property COPE_Classificacao_Estatistica As String
    Public Property COPE_Tipo_de_Conta As String
    Public Property COPE_Conta_Bancaria As String
    Public Property COPE_Pais_da_Entidade_ou_Contraparte As String
    Public Property COPE_Pais_da_Entidade_do_Ativo_Financeiro As String
    Public Property COPE_NPC_do_2_Interveniente As String
    Public Property COPE_Entidade_do_Ativo As String
    Public Property COPE_Montante As String
    Public Property Codigo_do_Projeto_da_Linha As String
    Public Property Elemento_PEP_da_Linha As String
    Public Property Serie_do_Documento As String
    Public Property Pendentes_Descricao_do_Documento As String
    Public Property Pendentes_Filial_do_Documento As String
    Public Property Pendentes_Numero_da_Prestacao_do_documetno As String
    Public Property pendentes_Valor_do_Documento As String
    Public Property Pendentes_Valor_do_documento_na_Moeda_Base As String
    Public Property Pendentes_Valor_do_Documento_na_Moeda_Alternativa As String
    Public Property Pendentes_Moeda_do_Documento As String
    Public Property pendentes_Modulo_do_Documento As String
    Public Property Data_de_Operacao As String
    Public Property Data_de_Expedicao As String
    Public Property Data_de_Recepcao As String
    Public Property NIF As String
    Public Property Designacao_Fical As String
    Public Property Pais As String
    Public Property Documento_Rectificado As String
    Public Property Taxa_de_IVA As String
    Public Property Modo_de_Pagamento As String
    Public Property Base_de_Incidencia As String
    Public Property IVA_Nao_Dedutivel As String
    Public Property Tipo_de_Operacao As String
    Public Property NIF_da_Entidade As String
    Public Property Nome_Fiscal_da_Entidade As String
    Public Property Pais_da_Entidade As String
    Public Property NIF_do_Terceiro As String
    Public Property Nome_Fiscal_do_Terceiro As String
    Public Property Pais_do_Terceiro As String
    Public Property Tipo_de_Recolha As String
    Public Property DocumentoOrigem As String
    Public Property Recapitulativo As String


End Class
