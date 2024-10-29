package br.ifes.projetosistemas.calculadora.dto;

public class RequestDTO {
    private String operacao;
    private int valor1;
    private int valor2;

    public RequestDTO(String operacao, int valor1, int valor2) {
        this.operacao = operacao;
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public String getOperacao() {
        return operacao;
    }

    public void setOperacao(String operacao) {
        this.operacao = operacao;
    }

    public int getValor1() {
        return valor1;
    }

    public void setValor1(int valor1) {
        this.valor1 = valor1;
    }

    public int getValor2() {
        return valor2;
    }

    public void setValor2(int valor2) {
        this.valor2 = valor2;
    }
}
