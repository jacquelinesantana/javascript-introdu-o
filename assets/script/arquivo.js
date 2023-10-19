let valor = 3
//variavel number 

let valor2 = "3"
//variavel string

let nome = "João Maia"

//constante 
const url = "http://google.com.br"
const porcentagem = 3

//saída do valor no console
console.log(valor)
console.log(typeof(valor))

console.log(typeof(valor2))

console.log(url)

//função sem parametros
function ola(){
    console.log("olá mundo")
}
ola() // chamando a função

//função com parametros
function soma(numero1,numero2){
    return numero1+numero2
}
//chamando a função com os parametros conforme a assinatura da mesma
console.log(soma(3,5))

//arrow function - escrita resumida de uma function
//estamos criando uma constante que realiza o mesmo que a função ola
const olaMundo = () => console.log("olá mundo 2")
//chamando a função acima
olaMundo()

let somaNum = (num1,num2) => num1+num2
console.log(somaNum(45,54))
