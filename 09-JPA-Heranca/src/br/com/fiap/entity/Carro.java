package br.com.fiap.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Table;

@Entity
@Table(name="T_CARRO")
public class Carro extends Veiculo {

	@Column(name="nr_portas")
	private int numeroPortas;
	
	@Column(name="nr_roda")
	private int aroRoda;
	
	public Carro() {
		super();
	}

	public Carro(double velocidade, String nome, 
							int numeroPortas, int aroRoda) {
		super(velocidade, nome);
		this.numeroPortas = numeroPortas;
		this.aroRoda = aroRoda;
	}

	public int getNumeroPortas() {
		return numeroPortas;
	}

	public void setNumeroPortas(int numeroPortas) {
		this.numeroPortas = numeroPortas;
	}

	public int getAroRoda() {
		return aroRoda;
	}

	public void setAroRoda(int aroRoda) {
		this.aroRoda = aroRoda;
	}
	
}
