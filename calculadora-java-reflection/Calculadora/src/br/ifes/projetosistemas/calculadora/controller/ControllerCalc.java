package br.ifes.projetosistemas.calculadora.controller;

import br.ifes.projetosistemas.calculadora.dto.RequestDTO;
import br.ifes.projetosistemas.calculadora.dto.ResponseDTO;
import br.ifes.projetosistemas.calculadora.model.Calc;
import br.ifes.projetosistemas.calculadora.model.ICalc;
import br.ifes.projetosistemas.calculadora.model.operation.*;

public class ControllerCalc {
    public ResponseDTO calc(RequestDTO requestDTO){
        int result = 0;
        ICalc calc = new Calc();
        String operationClassName = requestDTO.getOperacao();

        IOperation operation = null;

        try {
            // usando reflection com nome da classe obtido no request
            Class<?> classe = Class.forName("br.ifes.projetosistemas.calculadora.model.operation." + operationClassName);
            operation = (IOperation) classe.getDeclaredConstructor().newInstance();
        } catch (Exception e) {
            e.printStackTrace();
            System.out.println("Erro ao instanciar operação: " + e.getMessage());
        }

        result = calc.calculation(operation, requestDTO.getValor1(), requestDTO.getValor2());
        return new ResponseDTO(result);
    }
}
