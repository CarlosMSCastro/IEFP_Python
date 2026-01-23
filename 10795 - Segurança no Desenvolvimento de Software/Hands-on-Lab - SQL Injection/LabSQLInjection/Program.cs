
using LabSQLInjection;

Console.WriteLine("=== LAB SQL INJECTION ===\n");

var service = new LoginService();
var searchService = new SearchService();

// 
// 1 - LOGIN INSEGURO
// ==========================================
Console.WriteLine("--- EXERCÍCIO 1: Login Inseguro ---");

// Teste 1: Login normal
Console.WriteLine("\n[Teste Normal]");
Console.WriteLine("Username: admin");
Console.WriteLine("Password: admin123");
var user1 = service.LoginInseguro("admin", "admin123");
if (user1 != null)
    Console.WriteLine($"Login com Sucesso: {user1.Username} ({user1.Role})");
else
    Console.WriteLine("Login falhou");

// Teste 2: SQL Injection
Console.WriteLine("\n[Teste com SQL INJECTION]");
Console.WriteLine("Username: ' OR '1'='1");
Console.WriteLine("Password: ' OR '1'='1");
var user2 = service.LoginInseguro("' OR '1'='1", "' OR '1'='1");
if (user2 != null)
{
    Console.WriteLine($"Login como: {user2.Username} ({user2.Role})");
    Console.WriteLine("SQL Injection funcionou!");
}
else
    Console.WriteLine("Ataque falhou");

// 
// 2 - LOGIN SEGURO COM PARÂMETROS
// ==========================================

// Teste com ataque
Console.WriteLine("\n[Tentativa com SQL INJECTION]");
Console.WriteLine("Username: ' OR '1'='1");
Console.WriteLine("Password: ' OR '1'='1");
var user3 = service.LoginSeguroComParametros("' OR '1'='1", "' OR '1'='1");
if (user3 != null)
    Console.WriteLine($"Ataque funcionou! {user3.Username}");
else
    Console.WriteLine("Ataque falhou");

// 
// 3 - LOGIN SEGURO COM LINQ
// ==========================================

// Teste com ataque
Console.WriteLine("\n[Tentativa de SQL INJECTION]");
Console.WriteLine("Username: ' OR '1'='1");
Console.WriteLine("Password: ' OR '1'='1");
var user4 = service.LoginSeguroComLINQ("' OR '1'='1", "' OR '1'='1");
if (user4 != null)
    Console.WriteLine($"Ataque funcionou! {user4.Username}");
else
    Console.WriteLine("Ataque falhou!");


// EXERCÍCIO 4 - SEARCH COM LIKE
// ==========================================

// Teste normal
Console.WriteLine("\n[Pesquisa Normal]");
var resultados1 = searchService.SearchSeguroComLINQ("admin");
Console.WriteLine($"Encontrados: {resultados1.Count} users");

// Ataque no método inseguro
Console.WriteLine("\n[ATAQUE no método INSEGURO]");
try
{
    var resultados2 = searchService.SearchInseguro("%' OR '1'='1");
    Console.WriteLine($"VULNERÁVEL! Retornou {resultados2.Count} users");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// Mesmo ataque no método seguro
Console.WriteLine("\n[ATAQUE no método SEGURO com Parâmetros]");
var resultados3 = searchService.SearchSeguroComParametros("%' OR '1'='1");
Console.WriteLine($"PROTEGIDO! Retornou {resultados3.Count} users)");

Console.WriteLine("\n[ATAQUE no método SEGURO com LINQ]");
var resultados4 = searchService.SearchSeguroComLINQ("%' OR '1'='1");
Console.WriteLine($"PROTEGIDO! Retornou {resultados4.Count} users");

// EXERCÍCIO 5 - VALIDAÇÃO DE ENTRADA
// ==========================================

// Teste com ID válido
Console.WriteLine("\n[ID válido]");
try
{
    var user5 = searchService.GetByIdSeguro("1");
    if (user5 != null)
        Console.WriteLine($"User encontrado: {user5.Username}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// Teste com ID inválido no método INSEGURO
Console.WriteLine("\n[ID inválido no método INSEGURO]");
try
{
    var user6 = searchService.GetByIdInseguro("abc");
    Console.WriteLine($"User: {user6?.Username}");
}
catch (Exception ex)
{
    Console.WriteLine($"CRASH!: {ex.Message}");
}

// Teste com ID inválido no método SEGURO
Console.WriteLine("\n[ID inválido no método SEGURO");
try
{
    var user7 = searchService.GetByIdSeguro("abc");
    Console.WriteLine($"User: {user7?.Username}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"PROTEGIDO! Erro: {ex.Message}");
}


// DESAFIO FINAL - GetByRole
// ==========================================
Console.WriteLine("\n\n--- DESAFIO FINAL: GetByRole ---");

// Teste normal
Console.WriteLine("\n[Pesquisa normal por Role: 'Admin']");
var admins1 = searchService.GetByRoleSeguroComLINQ("Admin");
Console.WriteLine($"Encontrados: {admins1.Count} admins");
foreach (var admin in admins1)
    Console.WriteLine($"  - {admin.Username} ({admin.Role})");

// Ataque no método VULNERÁVEL
Console.WriteLine("\n[ATAQUE no método VULNERÁVEL - Role: ' OR '1'='1]");
try
{
    var admins2 = searchService.GetByRoleInseguro("' OR '1'='1");
    Console.WriteLine($"VULNERÁVEL! Retornou {admins2.Count})");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// Ataque no método SEGURO com Parâmetros
Console.WriteLine("\n[Mesmo ATAQUE no método SEGURO com Parâmetros]");
var admins3 = searchService.GetByRoleSeguroComParametros("' OR '1'='1");
Console.WriteLine($"PROTEGIDO! Retornou {admins3.Count} users");

// aAtaque no método SEGURO com LINQ
Console.WriteLine("\n[Mesmo ATAQUE no método SEGURO com LINQ]");
var admins4 = searchService.GetByRoleSeguroComLINQ("' OR '1'='1");
Console.WriteLine($"PROTEGIDO! Retornou {admins4.Count} users");

Console.WriteLine("\n\n=== FIM DOS TESTES ===");
Console.ReadKey();

