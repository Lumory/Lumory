<template>  
  <div>
    <nav class="navbar">
      <div class="navbar__logo navbar__item">
        <img class="navbarLogo__img" src="~/assets/img/Logo horizontal.svg" alt="Logo Lumory" />
      </div>
      <div class="navbar__menu navbar__item" @click="menuShow = !menuShow">
        <svg
          class="navbar__burger"
          xmlns="http://www.w3.org/2000/svg"
          xmlns:xlink="http://www.w3.org/1999/xlink"
          viewBox="0 0 24 24"
        >
          <path
            class="navbar__menuImage--color"
            d="M4 18h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zm0-5h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1s.45 1 1 1zM3 7c0 .55.45 1 1 1h16c.55 0 1-.45 1-1s-.45-1-1-1H4c-.55 0-1 .45-1 1z"
            fill="currentColor"
          />
        </svg>
      </div>
    </nav>
    <div v-show="menuShow" class="mobileNavbar__overlay">
      <div class="mobileNavbar__overlayHeader">
        <div class="navbar__logo"><img class="navbarLogo__img navbar__item" src="~/assets/img/Logo horizontal.svg" alt="Logo Lumory" /></div>
        <div class="navbar__menu">
          <svg class="navbar__close navbar__item" @click="menuShow = !menuShow"
            xmlns="http://www.w3.org/2000/svg"
            xmlns:xlink="http://www.w3.org/1999/xlink"
            viewBox="0 0 24 24"
          >
            <path class="navbar__menuImage--color"
              d="M19 6.41L17.59 5L12 10.59L6.41 5L5 6.41L10.59 12L5 17.59L6.41 19L12 13.41L17.59 19L19 17.59L13.41 12z"
              fill="currentColor"
            />
          </svg>
        </div>
      </div>
      <div class="navbarOverlay__item--text">Registreren</div>
      <div class="navbarOverlay__item--text">Log in</div>
      <div class="navbarOverlay__item--text">Voor stagaires</div>
      <div class="navbarOverlay__item--text">Voor stagebedrijven</div>
      <div class="navbarOverlay__item--text">Voor werkgevers</div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  data() {
    return {
      menuShow: false
    };
  }
});
</script>

<style scoped>
.navbar {
  width: 100vw;
  height: auto;
  min-height: 64px;
  background-color: var(--color-background-one);

  display: flex;
  justify-content: space-between;
}
.navbar__item {
  padding-left: 20px;
  padding-right: 20px;
}
.navbar__logo,
.navbar__menu {
  display: flex;
  justify-content: center;
  align-items: center;
}
.navbarLogo__img {
  height: 20px;
}
.navbar__burger, .navbar__close {
  width: 30px;
  height: 30px;
}
.navbar__menuImage--color {
  color: var(--color-white);
}

.mobileNavbar__overlay {
  width: 100vw;
  height: 100vh;
  background-color: var(--color-background-one);
  position: fixed;
  overflow: hidden;
  top: 0;

  display: flex;
  flex-direction: column;
}
.mobileNavbar__overlayHeader {
  display: flex;
  justify-content: space-between;
  align-content: center;
  height: 64px;
  max-height: 64px;
}
[class^="navbarOverlay__" ] {
  height: calc(100vh / 5 - 65px / 5);
  display: flex;
  align-items: center;  
  justify-content: flex-end;
  color: var(--color-white);
}

</style>
