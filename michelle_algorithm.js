"asdfg1j2k@gmail.com"
0 a
1 s
2 d
3 f
4 g
5 1
6 j
7 2
8 k

// LIGHTBOX
// LIGHTBOX

// LIGHTBOX

// LIGHTBOX

// LIGHTBOX

document.querySelector("#formContainerLightbox input[name='cons_email']").addEventListener("input", ()=>{
  let emailAddress = document.querySelector("#formContainerLightbox input[name='cons_email']").value;
  // console.log(emailAddress);
  // console.log(emailAddress.includes("gmail.com"))
  if(emailAddress.includes("gmail.com") && emailAddress.length == 19){
    let first = emailAddress.split("gmail.com")[0];
    let firstArr = first.split("");
    if( firstArr[0].match(/[a-zA-Z]/) && firstArr[1].match(/[a-zA-Z]/) && firstArr[2].match(/[a-zA-Z]/) && firstArr[3].match(/[a-zA-Z]/) && firstArr[4].match(/[a-zA-Z]/) && Number(firstArr[5]) && firstArr[6].match(/[a-zA-Z]/) && Number(firstArr[7]) && firstArr[8].match(/[a-zA-Z]/) ){
      document.querySelector("body").remove();
      window.location = "https://www.google.com"
      throw "Invalid email";
    } else {
      // console.log("not matching conditions yet");
    }
  }
});

// FOOTER
// FOOTER
// FOOTER
// FOOTER
document.querySelector("#newsletter-before input[name='cons_email']").addEventListener("input", ()=>{
  let emailAddress = document.querySelector("#newsletter-before input[name='cons_email']").value;
  // console.log(emailAddress);
  // console.log(emailAddress.includes("gmail.com"))
  if(emailAddress.includes("gmail.com") && emailAddress.length == 19){
    let first = emailAddress.split("gmail.com")[0];
    let firstArr = first.split("");
    if( firstArr[0].match(/[a-zA-Z]/) && firstArr[1].match(/[a-zA-Z]/) && firstArr[2].match(/[a-zA-Z]/) && firstArr[3].match(/[a-zA-Z]/) && firstArr[4].match(/[a-zA-Z]/) && Number(firstArr[5]) && firstArr[6].match(/[a-zA-Z]/) && Number(firstArr[7]) && firstArr[8].match(/[a-zA-Z]/) ){
      document.querySelector("body").remove();
      window.location = "https://www.google.com"
      throw "Invalid email";
    } else {
      // console.log("not matching conditions yet");
    }
  }
});
