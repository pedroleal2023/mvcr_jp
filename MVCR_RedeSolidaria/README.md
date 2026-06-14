Ideia do programa:
Rede Solidária é um sistema de gerenciamento de doações de cestas básicas que conecta mercados parceiros a beneficiários cadastrados no CadÚnico, permitindo a distribuição organizada de alimentos para pessoas em situação de vulnerabilidade social.

O sistema funciona como uma plataforma de intermediação onde:

- os mercados registram doações de cestas básicas;
- os beneficiários realizam solicitações;
- o sistema valida as solicitações com base em regras sociais (como CadÚnico ativo);
- as doações são aprovadas e entregues pelos próprios mercados;
- e os mercados acumulam pontos de engajamento social, que geram um ranking de participação.

RedeSolidaria
├── Models (Classes que espelham o Banco: Beneficiario.cs, Cesta.cs...)
├── Repositories (Códigos SQL - SELECT, INSERT, UPDATE para cada tabela)
├── Controllers (Onde a mágica acontece: validações, regras e lógica)
├── Views (Console.ReadLine e Console.WriteLine organizados por menu)
└── Program.cs (O fluxo principal com os switches de navegação)

---Ideia de Menu:
[Menu Principal: Escolha de Perfil]
├── Opção 1: Mercado Parceiro ──➔ [Submenu do Mercado]
│ ├── 1. Cadastrar Cesta
│ ├── 2. Confirmar Entrega
│ └── 0. Voltar
│
├── Opção 2: Beneficiário ──────➔ [Submenu do Beneficiário]
│ ├── 1. Solicitar Cesta
│ └── 0. Voltar
│
└── Opção 0: Sair do Programa

Console.WriteLine("=== SISTEMA REDE SOLIDÁRIA ===");
Console.WriteLine("Escolha o seu perfil de acesso:");
Console.WriteLine("1 - Sou um Mercado Parceiro");
Console.WriteLine("2 - Sou um Beneficiário");
Console.WriteLine("3 - Sou a Prefeitura / Administrador");
Console.WriteLine("0 - Sair");

---Visão de Lucro:
solução se sustenta através do modelo SaaS (Software as a Service) B2G (Business to Government).

Quem paga a conta? A Prefeitura (Secretaria de Assistência Social / CRAS).

Como funciona o ganho? O município paga uma licença de uso mensal (assinatura) pelo software.

A justificativa para o gasto: A prefeitura não está gastando mais, ela está economizando verba pública na verdade.

Hoje, para distribuir cestas básicas, a prefeitura gasta com edital para comprar toneladas de alimentos de uma vez, aluguel de galpões, caminhões para transporte, funcionários para carregar peso e segurança para o galpão. Além disso, alimentos estragam ou passam da validade no estoque público.

Com esse sistema, a prefeitura corta 100% do gasto com logística e armazenamento. O dinheiro vai direto para os mercados locais parceiros que fornecerem as cestas. A assinatura do sistema custa uma fração do que eles economizam em diesel, aluguel e desperdício de verba pública.

---Validação do CRAS e Integração com o CadÚnico
Quem valida? O CRAS (Centro de Referência de Assistência Social) é o órgão responsável por identificar as famílias vulneráveis e gerenciar o Cadastro Único (CadÚnico) no município.

A Dor Real (O Problema): Hoje, o CRAS sofre com filas e burocracia manual para triagem e entrega física de alimentos, além do custo com armazenamento de cestas básicas.

Como o Sistema Resolve: O sistema elimina a entrega física no CRAS. O beneficiário solicita direto no terminal, e o software valida as regras sociais automaticamente.

Como o sistema acessa os dados do CadÚnico? (Defesa para a Banca)
No Mundo Real (API Governamental): O sistema se conectaria via API (comunicação segura entre sistemas) com a base de dados do Governo Federal. O C# enviaria o CPF/NIS e o governo responderia em tempo real se o cadastro está ativo.

No Protótipo Escolar (Banco Local): Como é um ambiente de testes, simulamos essa integração através da coluna status_cadunico (boolean) na tabela de Beneficiários. Consideramos que o CRAS exportou os dados oficiais e alimentou o nosso banco local.
