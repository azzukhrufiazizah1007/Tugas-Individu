const txtElement=['Mahasiswi','Santri','Organisatoris'];
Let count=0;
Let currentTxt='';
Let words='';

(function ngetik(){

if (count==txtElement.lenght){
count=0;}

currentTxt=txtElement[count];
words = currentTxt.slice(0,++txtIndex);
document.querySelector('.efek-ngetik').textContent=words;
if(words.lenght==currentTxt.lenght){
count++;
txtIndex=0;
}

setTimeout(ngetik, 500);

})();