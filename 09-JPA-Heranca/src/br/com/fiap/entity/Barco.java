package br.com.fiap.entity;

import javax.persistence.Column;
import javax.persistence.DiscriminatorValue;
import javax.persistence.Entity;
import javax.persistence.Table;

@DiscriminatorValue("B")

@Entity
@Table(name="T_BARCO")
public class Barco extends Veiculo {

	@Column(name="nr_pes")
	private double pes;
	
	@Column(name="ds_tipo_barco")
	private TipoBarco tipo;

	public Barco() {
		super();
	}

	public Barco(double velocidade, String nome, 
								double pes, TipoBarco tipo) {
		super(velocidade, nome);
		this.pes = pes;
		this.tipo = tipo;
	}

	public double getPes() {
		return pes;
	}

	public void setPes(double pes) {
		this.pes = pes;
	}

	public TipoBarco getTipo() {
		return tipo;
	}

	public void setTipo(TipoBarco tipo) {
		this.tipo = tipo;
	}
	
}
