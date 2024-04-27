@import url('https://fonts.googleapis.com/css2?family=Chakra+Petch:wght@400;700&display=swap&#39;);

:root {
--cor-de-fundo: #1E1E1E;
--verde: #6FFF57;
--branco: #FFFFFF;
--botao-ativo: #3A375E;
--botao-inativo: rgba(58, 55, 94, 0.5);
--texto-fundo: rgba(58, 55, 94, 0.3);
}

body {
background-color: var(--cor-de-fundo);
color: var(--branco);
font-family: 'Chakra Petch', sans-serif;
}


.conteudo-principal {
display: flex;
flex-direction: column;
justify-content: center;
align-items: center;
max-width: 1200px;
width: 100%;
margin: 0 auto;
}

.titulo-principal {
text-align: left;
width: 100%;
font-size: 32px;
}

.titulo-principal span {
color: var(--verde);
}

.botao {
font-family: "Crakra Petch", sans-serif;
background-color: var(--botao-inativo);
color: var(--branco);
display: flex;
justify-content: center;
padding: 1em;
font-size: 18px;
align-items: center;
width: 100%;
border-bottom: 4px solid var(--botao-ativo);
border-left: 2px solid var(--botao-ativo);
border-right: 2px solid var(--botao-ativo);
border-top: none;
}

.botao:first-child {
border-radius: 40px 40px 0 0;
}

.botoes {
display: block;
}
.botao,ativo {
   background-color: var (--botao-ativo);
   border-bottom: 4px solid var(--verde);
}

.abas-texto{
  background-verde: var(--texto-fundo);
 border-radius; 0 0 40px 40px;
}

.aba-conteudo.ativo{
  display: block;
}

.aba-conteudo-titulo-principal{
     font-siz: 28px;
     text-aling: center;
}

.aba-conteudo-titulo-secundario{
      text-aling: center;
      color: var(--verde);
      text-transform: uppercase;
}
 .contador{

.aba-conteudo{
     display: none;
}
@media screen and (min-width: 768px) {
.botoes {
display: flex;
}

.botao:first-child {
border-radius: 40px 0 0 0;
}

.botao:last-child {
border-radius: 0 40px 0 0;
}
}
