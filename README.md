# 🚀 CashFlow API — Gestão de Despesas com .NET 7, DDD e Testes de Unidade

---

## 🧭 Visão Geral

O **CashFlow API** é uma solução back-end desenvolvida com **.NET 7**, focada no gerenciamento de despesas pessoais. O projeto adota os princípios do **Domain-Driven Design (DDD)** para oferecer uma estrutura organizada, eficaz e de fácil manutenção.

A aplicação permite que os usuários registrem suas despesas detalhadamente (título, data, valor, tipo de pagamento) com persistência em um banco de dados **MySQL**. Além da gestão de dados, o sistema oferece funcionalidades avançadas como a geração de relatórios inteligentes em **PDF** e **Excel**.

---

## ⚙️ Funcionalidades e Arquitetura

### 🏗️ 1. Domain-Driven Design (DDD)
* Estrutura modular focada no domínio da aplicação.
* Separação clara de responsabilidades entre camadas (API, Application, Domain, Infrastructure).
* Facilidade de evolução e escalabilidade do software.

---

### 🧪 2. Testes de Unidade e Qualidade
* Implementação de testes abrangentes para garantir a funcionalidade e a qualidade do código.
* Uso do **FluentAssertions** para criar verificações mais legíveis e compreensíveis.
* Garantia de que as regras de negócio permaneçam íntegras durante o desenvolvimento.

---

### 📊 3. Geração de Relatórios
* Capacidade de exportar relatórios detalhados para análise de gastos.
* **PDF:** Relatórios formatados para visualização rápida e impressão.
* **Excel:** Exportação de dados para manipulação analítica e cálculos externos.

---

### 🛠️ 4. Persistência e Validação
* **Entity Framework (ORM):** Simplifica a interação com o banco de dados MySQL utilizando objetos .NET, eliminando a necessidade de consultas SQL manuais.
* **FluentValidation:** Implementação de regras de validação de forma simples e intuitiva, mantendo o código limpo.
* **AutoMapper:** Responsável pelo mapeamento entre objetos de domínio e DTOs (Request/Response), reduzindo a repetição de código.

---

### 🌐 5. RESTful API com Swagger
* Interface baseada em métodos HTTP padrão para comunicação eficiente.
* Documentação interativa com **Swagger**, proporcionando uma interface gráfica para explorar e testar os endpoints com facilidade.

---

## 🧰 Tecnologias Utilizadas

* **C# / .NET 7**
* **MySQL** (Banco de dados relacional)
* **Entity Framework Core** (ORM)
* **Domain-Driven Design (DDD)**
* **AutoMapper** (Mapeamento de objetos)
* **FluentValidation** (Validação de dados)
* **FluentAssertions** (Testes de unidade)
* **Swagger / UI** (Documentação da API)

---

## 🧠 Conceitos Principais Dominados

* Arquitetura de software baseada em camadas e DDD.
* Desenvolvimento de APIs REST profissionais com .NET 7.
* Princípios de **Clean Code** e separação de responsabilidades.
* Implementação de testes automatizados.
* Geração de documentos e relatórios programaticamente.
* Manipulação de bancos de dados relacionais com migrations.

---

## 🏁 Conclusão

A **CashFlow API** demonstra como construir uma aplicação robusta e profissional, focando na qualidade da arquitetura e na experiência do desenvolvedor. Este projeto serve como uma base sólida para sistemas que exigem alta organização, segurança e ferramentas de análise de dados.
