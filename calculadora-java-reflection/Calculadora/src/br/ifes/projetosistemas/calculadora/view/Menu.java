package br.ifes.projetosistemas.calculadora.view;

import br.ifes.projetosistemas.calculadora.dto.RequestDTO;
import br.ifes.projetosistemas.calculadora.dto.ResponseDTO;

import java.util.Scanner;

public class Menu {
    public RequestDTO show(){
        this.showMenu();
        return this.captureValues();
    }

    private RequestDTO captureValues (){
        Scanner input = new Scanner(System.in);
        String operacao = "";

        // Validação para garantir que o usuário insira uma operação válida
        while (true) {
            operacao = input.nextLine().trim();

            if (operacaoValida(operacao)) {
                break;
            } else {
                System.out.println("Operacao invalida, digite novamente.");
            }
        }

        if (operacao.equals("Sair")) {
            System.exit(0);
        }

        System.out.println("Informe o primeiro valor:");
        int valor1 = input.nextInt();
        System.out.println("Informe o segundo valor:");
        int valor2 = input.nextInt();

        return new RequestDTO(operacao, valor1, valor2);
    }

    private boolean operacaoValida(String operacao) {
        return operacao.equals("Somar") ||
                operacao.equals("Subtrair") ||
                operacao.equals("Multiplicar") ||
                operacao.equals("Dividir") ||
                operacao.equals("Sair");
    }

    private void showMenu(){
        System.out.println("Digite 'exatamente' uma das operacoes:");
        System.out.println("Somar, Subtrair, Multiplicar, Dividir");
        System.out.println("Ou digita Sair para encerrar.");
    }

    public void showResult (ResponseDTO responseDTO){
        System.out.println("O Resultado é: " + responseDTO.getResult());
    }
}
