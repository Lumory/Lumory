<template>
  <n-space justify="center" class="footer --full-width --white">
    <container>
      <n-space class="footer-content" vertical>
        <n-grid cols="1 s:3" x-gap="25px" y-gap="25px" responsive="screen">
          <n-grid-item class="logo">
            <NuxtLink to="/">
              <n-image
                  class="logo--size"
                  src="/assets/img/Logo-horizontal.svg"
                  alt="Logo Lumory"
              />
            </NuxtLink>
          </n-grid-item>
          <n-grid-item>
            <n-space class="footer-menu" vertical>
              <h6>Navigatie</h6>
              <nuxt-link to="/students">Studenten</nuxt-link>
              <nuxt-link to="/stagebedrijven">Stagebedrijven</nuxt-link>
              <nuxt-link to="/werkgevers">Werkgevers</nuxt-link>
              <nuxt-link to="/signin">Login</nuxt-link>
              <nuxt-link to="/signup">Registreren</nuxt-link>
              <nuxt-link to="/tos">Algemene voorwaarden</nuxt-link>
            </n-space>
          </n-grid-item>
          <n-grid-item>
            <h6>Contact</h6>
            <p>info@lumory.nl</p>
            <p>Heidelberglaan 15, 3584 CS Utrecht</p>
          </n-grid-item>
        </n-grid>
        <n-space class="footer-copyright" justify="center">
          <p>© Copyright Lumory</p>
        </n-space>
      </n-space>
    </container>
  </n-space>
</template>

<script>
import { NGrid, NGridItem, NImage, NSpace } from "naive-ui"
import Container from "./Container";

export default {
  components: {
    Container,
    NGrid,
    NGridItem,
    NImage,
    NSpace,
  }
}
</script>

<style scoped>
.footer {
  margin-top: 100px;
  color: #a9a9a9;
}
.--full-width {
  width: calc(100vw - (100vw - 100%));
  height: auto;
  min-height: 64px;
  background-color: var(--color-background-one);
  display: flex;
  justify-content: center;
  align-items: center;
}
.footer-content {
  width: 100%;
  padding: 50px 0 20px 0;
}
.logo--size {
  height: 30px;
  width: auto;
}
.footer-menu a, .footer-menu a:visited{
  color: #a9a9a9;
}
.footer-menu a:hover, .footer-menu a:active {
  color: var(--white);
}
.footer-copyright {
  margin-top: 20px;
}
</style>
