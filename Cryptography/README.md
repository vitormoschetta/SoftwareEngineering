# Criptografia com Hash

1. busca de elementos em bases de dados
2. verificação de integridade de dados grandes
3. armazenamento de senhas com segurança

Não é possível decriptar um Hash. O que pode ser feito é pegar uma entrada de dados, gerar um hash e comparar  
com outro já gerado. Assim é feito o processo de autenticação, pois uma mesma entranda de dados sempre irá
gerar a mesma saída.

Não sendo possível decriptar um Hash, Crackers utilizam o que chamamos de 'Ataque de Força Bruta' para identificar 
padrões nos Hashs. Primeiro eles verificam se existe no banco de dados Hashs iguais. Se houver, sabem que aqueles 
usuários estão utilizando senhas fracas, do tipo '123456' ou 'admin123'. Logo, forçam o login com diversas
senhas usuais, e conseguem quebrar a segurança. 

Usam também o 'Paralelismo'. O atacante pega um monte de senhas protegidas com hash. Digita uma senha em potencial
e gera um Hash para si. Depois compara o seu Hash com outros Hash no banco de dados. Se encontrar algum igual
já sabe qual a senha. 

Pode também usar tabelas de hashes pré-calculadas (dicionário de hash). Ou seja, outros Hackers já deixaram listados 
o hash e a senha referente em uma tabela. É só fazer o ataque comparando os Hashs.

De todas as formas acima, sempre será necessário comparar um hash com outro.


SOLUÇÕES:

01. Uma forma muito usada é concatenar ao Hash um valor aletatório (randomico), denominado
'Salt'. Esse valor deve ser salvo no banco junto com o hash resultante da concatenacao da 'senha' e do 'salt'.
Chamamos essa operação de 'Salgar a senha'.
    salva no banco => Salt + HASH(Salt & senha)
    
02. Atribuir um outro valor 'pessoal' do usuário ao Hash, além da senha. Um valor dentre os campos existente
na tabela. Ex: CPF. Tem que ser um valor unico e obrigatório. Desta forma, não precisamos criar um novo 
campo com a informação aleatória 'Salt', que pode gerar alguma pista ao atacante.

03. Parecido com a solução anterior (02), porém usa um segundo campo na tela da aplicação pedindo uma segunda
informação (chave) do usuário. Essa informação substituiria o valor pessoal da solução anterior, fazendo com
que essa informação pessoal/salt nem exista na tabela. 

Obs: Podemos implementar a mudança do Salt a cada login, gerando a cada login um novo Hash


Veja que o objetivo é dificultar ao atacante. Ele ainda pode conseguir quebrar? Pode, mas isso demandará
muito mais tempo e muito mais recurso computacional, se tornando, dependendo do caso, inviável ou intratável. 


CENÁRIO: Com a computação quântica tudo isso deve mudar. O que seria intratável na computação clássica, será
possível com computadores quânticos, pois o poder de processamento é exponencialmente maior. Os algoritmos
atuais de criptografia ficarão certamente ultrapassados, devendo ser descartados. Novos algoritmos serão 
necessários na éra quântica. 




Melhores algoritmos de criptografia (2015):
Argon2 
PBKDF2 => Usado pelo asp.net Core
SCRYPT 
BCRYPT 
Lyra2 => Desenvolvido pelo Prof da UNIR, Dr EWERTON R. ANDRADE





Estrutura no asp.net Core para a solução 01:

```
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

public class Hash  
{  
    public static string Create(string value, byte[] salt)  
    {  
        var hashed  = KeyDerivation.Pbkdf2(  
                            password: value,  
                            salt: salt,  
                            prf: KeyDerivationPrf.HMACSHA1,  
                            iterationCount: 10000,  
                            numBytesRequested: 256 / 8);  

        return Convert.ToBase64String(hashed);  
    }  

    public static bool Validate(string value, byte[] salt, string hash)  
        => Create(value, salt) == hash;  
} 


public class Salt  
{  
    public static byte[] Create()  
    {  
        byte[] salt = new byte[128 / 8];  
        using (var generator = RandomNumberGenerator.Create())  
        {
            //Retorna o valor aletatorio 'generator' em Bytes:  
            generator.GetBytes(salt);  

            /* Converter byte para string:
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            var salt_string = enc.GetString(salt);*/
            return salt;
        }  
    }  
} 
    
    
    
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create([Bind("Id,Nome,Email,Cpf,Senha,Ativo,Perfil_Id")] Usuario usuario)
{
    if (ModelState.IsValid){   
        var salt = Salt.Create();//retorna em byte[]
        var hash = Hash.Create(usuario.Senha, salt);  // retorna em string

        if (Hash.Validate(usuario.Senha, salt, hash) == true){
            usuario.Senha = hash;
            usuario.Salt = Convert.ToBase64String(salt);//converte salt de byte[]  para string para salvar no banco

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
    return View(usuario);
}
        
        
        
[HttpPost]
public async Task<IActionResult> Login(string Login, string Senha)
{
    Usuario user = SaltUsuarioExists(Login); //verifica se o login(nome, cpf ou email) existe na tabela usuario

    if(user != null){
        var salt_tabela = user.Salt;//pega o valor salt da tabela

        byte[] salt = Convert.FromBase64String(salt_tabela); // Conver o valor salt que está no tipo string em byte[]
        var hash = Hash.Create(Senha, salt); // Gera o Hash para comparar com o hash da tabela do usuario

        // Agora sim verifica se o hash da senha é igual
        var usuario = await _context.Usuario.SingleOrDefaultAsync(u => ((u.Cpf == Login || u.Email == Login)|| u.Nome == Login) && u.Senha == hash); 

        if (usuario != null){
            HttpContext.Session.SetString("Usuario", usuario.Cpf);
            HttpContext.Session.SetInt32("UsuarioPerfil", usuario.Perfil_Id);
            return RedirectToAction("Index", "Home");
        }
        else{
            ViewBag.Mensagem = "Senha incorreta";
        }
    }
    else{
        ViewBag.Mensagem = "Usuario não encontrado";
    }                                                  

    return View();
}


private Usuario SaltUsuarioExists(string Login)
{
    Usuario usuario = _context.Usuario.SingleOrDefault(u => u.Cpf == Login || u.Email == Login || u.Nome == Login);                                        
    return usuario;
}
```