programa
{
	//Crie um programa que leia o nome e a nota de um aluno e diga se ele foi aprovado
    //(nota maior ou igual a 6) ou reprovado.
	funcao inicio()
	{
	real nota
	cadeia nome
	
		escreva("Digite o seu nome: ")
		leia(nome)

		escreva("Digite a sua nota: ")
		leia(nota)

		se(nota >= 6){

			escreva("Aluno Aprovado")
		}
		senao{
			escreva("Aluno Reprovado")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 376; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */