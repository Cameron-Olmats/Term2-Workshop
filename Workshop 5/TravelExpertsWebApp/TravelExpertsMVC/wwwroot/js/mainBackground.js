const [red, green, blue] = [69, 111, 225];
const main = document.querySelector('.main');

window.addEventListener('scroll', () => {
    const y = 1 + (window.scrollY || window.pageYOffset) / 400;
    const [r, g, b] = [red / y, green / y, blue / y].map(Math.round);
    main.style.backgroundColor = `rgb(${r}, ${g}, ${b})`;
});