function reklamalas(){
    let email = document.getElementById('email').value;
    let panasz = document.getElementById('panasz').value;

    if (email == "" || panasz == "") {
        alert("Nem adott meg minden adatot! ")
    }
    else{
        console.log(email);
        console.log(panasz);
    }
  
}