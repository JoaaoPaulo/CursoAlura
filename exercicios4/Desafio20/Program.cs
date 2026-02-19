ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");  
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X"); 

Console.WriteLine(@$"
Bem-vindo, cliente VIP: {cliente1.Nome}
Idade: {cliente1.Idade}
Nível de Fidelidade: {cliente1.Fidelidade}
Código VIP: {cliente1.Codigo}
")

Console.WriteLine(@$"
Bem-vindo, cliente VIP: {cliente2.Nome}
Idade: {cliente2.Idade}
Nível de Fidelidade: {cliente2.Fidelidade}
Código VIP: {cliente2.Codigo}
")