package br.com.fiap.teste;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

import br.com.fiap.bo.CalculadoraBO;

public class RMIClientTeste {

	public static void main(String[] args) throws Exception {
		//Chamar o método que está implementado no projeto 13
		CalculadoraBO bo = (CalculadoraBO) 
				Naming.lookup("rmi://10.3.8.37:1234/churros");
		
		int soma = bo.somar(10, 10);
		
		System.out.println(soma);
		
	}
	
}
