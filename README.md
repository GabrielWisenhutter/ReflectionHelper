# Instanciação de Propriedades Somente Leitura

## 📚 Descrição

Este projeto apresenta uma solução para instanciar valores em propriedades de uma classe que são somente leitura, ou seja, que possuem apenas um getter e não têm um setter. Isso é especialmente útil em cenários de testes de unidade, onde pode ser necessário definir valores para essas propriedades.

## 🔍 Problema

Em muitas situações, especialmente em testes, pode ser complicado trabalhar com propriedades que não podem ser modificadas diretamente devido à ausência de métodos setters. Isso pode dificultar a criação de instâncias de classes para fins de teste.

## 💡 Solução

A abordagem apresentada neste projeto permite a definição de valores para propriedades somente leitura durante a instância da classe, de maneira eficiente e simples.

## 🚀 Exemplo de Uso

```csharp
public class Example
{
    public User InitializeUserProperties()
    {
        var user = ReflectionHelper.CreateWithPrivateProperties<User>(
            (nameof(User.Name), "Gabriel Wisenhutter"),
            (nameof(User.Email), "gabrielwisenhutter2015@gmail.com")
        );

        return user;
    }
}
