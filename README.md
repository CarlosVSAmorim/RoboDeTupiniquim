# 🤖 Robô Tupiniquim - Academia do Programador 2025

Este projeto simula a movimentação de um robô explorador em Marte, controlado por comandos simples dentro de um grid retangular. Foi desenvolvido como parte da **Academia do Programador 2025** em parceria com a **Agência Espacial Brasileira (AEB)**.

## 🧭 Descrição

O sistema controla um ou mais robôs que se movem sobre um grid cartesiano, com base em comandos fornecidos pelo usuário. A cada execução, o robô deve registrar sua posição final e direção após seguir todas as instruções.

## 📌 Regras básicas

- O robô começa em uma coordenada inicial (X, Y) e uma direção (N, S, L, O);
- Ele recebe uma sequência de comandos (E, D, M);
  - E: gira 90° à esquerda;
  - D: gira 90° à direita;
  - M: move-se uma posição para frente, na direção atual;
- O robô **não pode ultrapassar os limites do grid**.

![Demonstração do Robô em ação](https://i.imgur.com/fJiBeFG.gif)
