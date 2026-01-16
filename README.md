# 💳 Validador de Bandeiras de Cartão de Crédito – C# .NET 10.0.2

Projeto desenvolvido em **C# (.NET 10.0.2)** com o objetivo de **validar números de cartões de crédito** e **identificar automaticamente suas bandeiras**, utilizando regras reais de mercado e padrões disponíveis no gerador de cartões da **4Devs**.

> ⚠️ **Aviso Importante:**  
> Este projeto é **exclusivamente para fins educacionais**, testes e finalização de curso.  
> **Não deve ser utilizado em ambientes de produção ou para validação financeira real.**

---

## 📌 Funcionalidades

✔ Identificação automática da bandeira do cartão  
✔ Validação do número utilizando o **Algoritmo de Luhn**  
✔ Suporte a múltiplas bandeiras  
✔ Normalização de entrada (remove espaços e hífens)  
✔ Aplicação Console simples e didática  
✔ Código limpo e extensível  

---

## 🏦 Bandeiras Suportadas

As bandeiras abaixo seguem os padrões utilizados no site **4devs.com.br**:

- Visa
- Mastercard
- American Express
- Elo
- Hipercard
- Diners Club
- Discover
- JCB

---

## 🗂️ Estrutura do Projeto

```text
CreditCardValidator/
├── src/
│   └── CreditCardValidator/
│       ├── Program.cs
│       └── Validators/
│           ├── CreditCardValidator.cs
│           └── CardBrand.cs
├── CreditCardValidator.sln
└── README.md
```
---

## 🚀 Como Executar o Projeto

Pré-requisitos

- .NET SDK 10.0.2 ou superior
- Terminal ou prompt de comando

```
dotnet restore
dotnet build
dotnet run --project src/CreditCardValidator
```