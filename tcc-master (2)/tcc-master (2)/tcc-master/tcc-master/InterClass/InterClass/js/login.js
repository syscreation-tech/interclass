const ulSquares = document.querySelector("ul.squares");
for (let i = 0; i < 11; i++) {
    const li = document.createElement("li")
    const random = (min, max)=> Math.random() * (max - min) + min;
    const size = Math.floor(random(10 - 120));
    const position = random(1, 99);
    const delay = random(5, 0.1);
    const duration = random(24, 12);
    li.style.width = `${size}px`;
    li.style.height = `${size}px`;
    li.style.bottom = `-${size}px`;
    li.style.left = `${position}%`;
    //    li.style.width =  ';
    li.style.animationDelay = `${delay}s`;
    li.style.animationDuration = `${delay}s`;
    ulSquares.appendChild(li);

}
alert();
const btnLogin = document.querySelector('.btn-login');
const form = document.querySelector("form");

btnLogin.addEventListener("click", event => {
    event.preventDefault();
    form.classList.add("form-hide");
}); 