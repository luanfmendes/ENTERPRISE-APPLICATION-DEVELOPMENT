package br.com.fiap.bo.impl;

import java.util.ArrayList;
import java.util.List;

import javax.ejb.Singleton;
import javax.ejb.Stateful;

import br.com.fiap.bo.NacBO;

@Singleton
public class NacBOImpl implements NacBO {

	private List<Double> nacs = new ArrayList<>();
	
	@Override
	public void adicionarNac(double nac) {
		nacs.add(nac);
	}

	@Override
	public List<Double> pesquisar() {
		return nacs;
	}
	
}
