const bontoes = DocumentType.querySelectorAll(".botao");
const textos  = DocumentType.querySelectorAll(".aba-conteudo");

for(let i=0;i < bontoes.length;i++) {
    botoes[i].onclick=function () {

        for (let j = 0;j< botoes.length;j++) {
            botoes[j].classList.remove("ativo");
            textos[j].classList.remove("ativo");
            {

        botoes[i].classList.add("ativo");
        textos[i].classList.add("ativo");
        {
     {
        const contadores=document.querySelectorAll(".contador");
        const tempoObjetivo1=new Date("2023-10-05T00:00:00");
        const tempoObjetivo2=new Date("2023-12-05T00:00:00");
        const tempoObjetivo3=new Date("2023-12-30T00:00:00");
        const tempoObjetivo4=new Date("2024-02-01T00:00:00"); 

        const tempo=
        [tempoObjetivo1,tempoObjetivo2,tempoObjetivo3,tempoObjetivo4];

    function calcula Tempo(tempoObjetivo){
        let tempoAtual=new Date();
        let tempoFinal=tempoObjetivo-tempoAtual;
        let segundos=Math.floor(tempoFinal/1000);
        let minutos=Math.floor(segundos/60);
        let horas=Math.floor(minutos/60);
        let dias=Math.floor(horas/24);

        segundo %= 60;
        minutos %=60;
        horas %=24;
        if(tempoFinal > 0){
            return[dias,horas,minutos,segundos];
        } else { 
            return [0,0,0,0];
        }
    }
    function atualizaCronometro(){
        for (let i=0; i<contadores.length;i++){
            document.getElementByld("dias"+i).textContent=calculeTempo(tempo[i])[0];
            document.getElementByld("horas"+i).textContent=calculaTempo(tempos[i])[1];
            document.getElementByld("min"+i).textContent=calculaTempo(tempos[i])[2];
            document.getElementByld("seg"+i).textContent=calculaTempo(tempo[i])[3];
        }
    }

    function comecaCronometro(){
        atualizaCronometro();
        setlnterval(atualizaCronometro,1000);

        {
            comecaCronometro();