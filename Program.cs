using flow_control.Models;
using System;
using System.Collections;
using System.Diagnostics;

Storage StoreOne = new("Loja do Seu Ronny");

Console.WriteLine("Boas vindas! Qual operação deseja fazer? \n 1 - Adicionar item\n 2 - Listar Itens\n 3 - Remover item.");
string option = Console.ReadLine();

switch(option)
{
    case "1":
        Console.WriteLine("Digite o nome do item: ");
        string newItemName = Console.ReadLine();
        var NewItem = new Item(newItemName, DateTime.Now);
        StoreOne.AddItem(NewItem);
        break; 

    case "2":
        Console.WriteLine("Os items armazenados são: ");
        if (StoreOne.StoredItems.Count > 0)
        {
            StoreOne.ShowItems();
        }
        else
        {
            Console.WriteLine("Não existe item registrado.");
        }
        break;
    case "3":
        Console.WriteLine("Digite o nome do item que quer remover: ");
        string? itemToRemove = Console.ReadLine();
        if (StoreOne.StoredItems.Count > 0)
        {
            StoreOne.RemoveItem(itemToRemove);
        }
        else
        {
            Console.WriteLine("Não encontramos o item que deseja remover.");
        }
        break;

}

