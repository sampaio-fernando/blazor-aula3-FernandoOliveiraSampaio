# blazor-aula3-FernandoOliveiraSampaio
Atividade realizada em Blazor e C# para prática de criação de componentes

# Por que o FormProduto não adiciona o produto direto na lista? Quem faz isso, e como ele fica sabendo que precisa fazer?
R: O FormProduto não adiciona o produto direto na lista porque ela está definina no componente pai. A lista é recebida pelo componente filho, porém ele não sabe do que será composta a lista. Quem adiciona o produto na lista é um componente pai, através do método de AdicionarProduto. Ele fica sabendo porque o formulário é validado pelo FormProduto e enviado o objeto pelo mesmo.
