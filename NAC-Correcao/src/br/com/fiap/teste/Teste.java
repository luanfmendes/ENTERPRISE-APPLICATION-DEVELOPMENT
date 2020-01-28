package br.com.fiap.teste;

import static org.junit.jupiter.api.Assertions.*;

import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.List;

import javax.persistence.EntityManagerFactory;

import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;

import br.com.fiap.dao.LocacaoDAO;
import br.com.fiap.dao.impl.LocacaoDAOImpl;
import br.com.fiap.entity.Cliente;
import br.com.fiap.entity.Genero;
import br.com.fiap.entity.Imovel;
import br.com.fiap.entity.Locacao;
import br.com.fiap.singleton.EntityManagerFactorySingleton;

class Teste {

	private static LocacaoDAO dao;
	
	@BeforeAll
	public static void inicializar() {
		EntityManagerFactory fabrica = 
				EntityManagerFactorySingleton.getInstance();
		dao = new LocacaoDAOImpl(fabrica.createEntityManager());
	}
	
	@Test
	void buscarTeste() {
		Calendar inicio = new GregorianCalendar(2018, Calendar.JANUARY, 1);
		Calendar fim = new GregorianCalendar(2020, Calendar.JANUARY, 1);
		List<Locacao> lista = dao.buscarPorData(inicio, fim);
		
		assertNotEquals(0, lista.size());
	}
	
	@Test
	void contarTeste() {
		long qtd = dao.contarPorCliente(1);
		assertEquals(1, qtd);
	}
	
	@Test
	void test() {
		Cliente cliente = new Cliente("Bruna", Genero.FEMININO,
					Calendar.getInstance());
		Imovel imovel = new Imovel(null, "2 Quartos", 
					"Av Paulista", 120121);
		Locacao locacao = new Locacao(cliente, imovel, 
					Calendar.getInstance(), 3000);

		try {
			dao.cadastrar(locacao);
			dao.commit();
		}catch(Exception e) {
			e.printStackTrace();
			fail("Erro");
		}
	}

}




