
@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@100;300;400;500;600&display=swap');

:root {
  --green: #27ae60;
  --dark-color: #219150;
  --black: #444;
  --light-color: #666;
  --border: 0.1rem solid rgba(0, 0, 0, 0.1);
  --border-hover: 0.1rem solid var(--black);
  --box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.1);
}

* {
  font-family: 'Poppins', sans-serif;
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  outline: none;
  border: none;
  text-decoration: none;
  text-transform: capitalize;
  transition: all 0.2s linear;
  transition: width none;
}

html {
  font-size: 62.5%;
  overflow-x: hidden;
  scroll-padding-top: 5rem;
  scroll-behavior: smooth;
}

html::-webkit-scrollbar-thumb {
  background: #fff;
  padding: 1.5rem 9%;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.header .header-1 .logo {
  font-size: 2.5rem;
  font-weight: bolder;
  color: var(--black);
}

.btn {
  margin-top: 1rem;
  display: inline-block;
  padding: 0.9rem 3rem;
  border-radius: 0.5rem;
  color: #fff;
  background: var(--green);
  font-size: 1.7rem;
  font-weight: 500;
  cursor: pointer;
}

.btn:hover {
  background: var(--dark-color);
}

.header .header-1 .logo i {
  color: var(--green);
}

.header .header-1 .searchform {
  width: 50rem;
  height: 5rem;
  border: var(--border);
  overflow: hidden;
  background: #fff;
  display: flex;
  align-items: center;
  border-radius: 5rem;
}

.header .header-1 .searchform input {
  font-size: 1.6rem;
  padding: 0 1.2rem;
  height: 100%;
  width: 100%;
  text-transform: none;
  color: var(--black);
}

.header .header-1 .searchform label {
  font-size: 2.5rem;
  padding-right: 1.5rem;
  color: var(--black);
  cursor: pointer;
}

.header .header-1 .searchform label:hover {
  color: var(--green);
}

.header .header-1 .
