# Curso Alura — Desafios de C#

Resolução dos desafios de orientação a objetos em C# propostos no curso da Alura. Cada desafio é um projeto de console .NET independente, com seu próprio `.csproj`.

## Como rodar

Pré-requisito: [SDK do .NET](https://dotnet.microsoft.com/download).

Entre na pasta do desafio e execute:

```bash
cd exercicios1/Desafio1
dotnet run
```

## Conteúdo

### `exercicios1` — Classes e objetos

| Desafio | Classes |
| --- | --- |
| Desafio1 | `Livro` (título e autor) |
| Desafio2 | `Passagem` (passageiro e destino) |
| Desafio3 | `Conta` (número e saldo) |
| Desafio4 | `Funcionario` (nome e cargo) |
| Desafio5 | `Retangulo` (cálculo de área) |
| Desafio6 | `Filme` |
| Desafio7 | `Produto` |
| Desafio8 | `Pedido` |
| Desafio9 | `Consulta` |

### `exercicios2` — Herança, classes abstratas e sobrescrita

| Desafio | Tema |
| --- | --- |
| Desafio10 | Classe abstrata `FormaGeometrica` com `Quadrado` e `Circulo` |
| Desafio11 | `Funcionario` e as especializações `Gerente`, `Programador` e `Analista` |
| Desafio12 | `ContaBancaria` com `ContaCorrente` e `ContaPoupanca` |
| Desafio13 | `Animal` e sobrescrita de `EmitirSom` em `Mamifero`, `Ave` e `Peixe` |
| Desafio14 | `ProdutoEletronico` com `Smartphone` e `Tablet` |

### `exercicios3` — Interfaces

| Desafio | Tema |
| --- | --- |
| Desafio15 | Interface de forma com `Circulo` e `Retangulo` |
| Desafio16 | Uma classe implementando duas interfaces (`IPitolavel` e `IVoavel`) |
| Desafio17 | `IPagavel` com `Produto` e `Servico` |
| Desafio18 | `INotificavel` com `Email` e `SMS` |
| Desafio19 | `IArmazenavel` com `Arquivo` e `BancoDeDados` |

### `exercicios4` — Herança, interfaces e composição

| Desafio | Classes |
| --- | --- |
| Desafio20 | `Pessoa`, `ClienteVIP` |
| Desafio21 | `Funcionario`, `Freelancer`, `Interno` |
| Desafio22 | `Pessoa`, `Passageiro` |
| Desafio23 | `Profissao`, `Analista`, `Docente`, `Certificado` |
| Desafio24 | `ItemDigital`, `Pergaminho` |
| Desafio25 | `ISensor`, `SensorTemperatura`, `SensorPresenca` |
| Desafio26 | `Computador` composto por `PlacaMae` e `Processador` |
| Desafio27 | `IPagamento`, `PagamentoBoleto`, `PagamentoCredito` |
| Desafio28 | `IServico`, `Consultoria`, `Manutencao` |
| Desafio29 | `ICurso`, `CursoDesign`, `CursoProgramacao`, `Instrutor` |

### `exercicios5` — Encapsulamento e relacionamento entre classes

| Desafio | Classes |
| --- | --- |
| Desafio30 | `Veiculo` (velocidade controlada) |
| Desafio31 | `Avaliacao` (nota com `private set`) |
| Desafio32 | `Paciente`, `HistoricoMedico` |
| Desafio33 | `Funcionario` (salário encapsulado) |
| Desafio34 | `Projeto` (lista de tarefas) |
| Desafio35 | `ContaBancaria`, `SegurancaConta` |
| Desafio36 | `Agenda`, `Contato` |
| Desafio37 | `Estudante` (cálculo de média) |
| Desafio38 | `Curso`, `Estudante` (matrículas) |
| Desafio39 | `Hospede`, `Quarto`, `Reserva` |

### `exercicios6` — Polimorfismo

| Desafio | Tema |
| --- | --- |
| Desafio40 | `Calculadora` com sobrecarga do método `Somar` |
| Desafio41 | `Funcionario`, `Desenvolvedor`, `Gerente` |
| Desafio42 | `INotificacao` com `Email`, `Sms` e `Push` |
| Desafio43 | `TarefaAgenda` com `Backup`, `Limpeza` e `Relatorio` |
| Desafio44 | `Midia` com `Imagem` e `Video` |
| Desafio45 | `Reserva` com `ReservaOnline` e `ReservaPresencial` |
| Desafio46 | `Conteudo` com `AulaGravada` e `MaterialComplementar` |
| Desafio47 | `Transporte` com `Bicicleta`, `Metro` e `Onibus` (tempo de viagem) |
| Desafio48 | `IEmprestimo` com perfis de aposentado, empresário e estudante |
| Desafio49 | Projeto iniciado (apenas o template) |
