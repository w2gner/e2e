
<h2>Configuração</h1>
<li>Importar solução no Visual Studio</li>
<li>Compilar solução para baixar os pacotes do Nuget</li>

<h2>Documentação</h2>
<li>Foram criados 4 testes consumindo a API do <code>jsonplaceholder</code></li>
<li>Os testes fazem requisições <code>http</code> dos tipos: <code>GET</code>, <code>POST</code>, <code>PUT</code> e <code>Delete</code> validando o resultado da resposta e o conteúdo</li>
<li>Adicionalmente foram criados 2 testes utilizando o <code>selenium</code>, o primeiro acessa página <link>https://jsonplaceholder.typicode.com<link> e verifca se o título da página é exibido, o segundo teste navega por alguns locais para validar a navegação pelo site.

<h5>OBS: A ideia original seria seguir o padrão de page objects na criação dos testes e executar seguindo <code>BDD</code> usando <code>Cucumber</code>, porém infelizmente não foi possível 😢.</h3>
