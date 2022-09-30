<template>
  <container>
    <n-grid cols="1 s:2" x-gap="25px" responsive="screen">
      <n-grid-item class="n-grid-item">
        <n-layout>
          <n-layout-content class="CTA">
            <p class="intro-text">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus velit eros, facilisis suscipit risus sed, venenatis rutrum lectus.</p>
            <n-button round color="#FEBF00">Registreer nu!</n-button>
          </n-layout-content>
        </n-layout>
      </n-grid-item>
      <n-grid-item>
          <n-image
              src="/assets/img/new2.png"
              class="header-image"
              width="100%"
              preview-disabled
          />
      </n-grid-item>
    </n-grid>
  </container>
</template>

<script>
import {NGrid, NGridItem, NLayout, NLayoutContent, NButton, NImage} from "naive-ui";
import VCard from "./VCard";

export default {
  components: {
    VCard,
    NGrid,
    NGridItem,
    NLayout,
    NLayoutContent,
    NButton,
    NImage
  }
}
</script>

<style>
.n-grid-item {
  display: flex;
  align-items: center;
}
.n-layout-content {
  align-items: center;
}
.n-grid {
  margin-top: 150px;
}
.CTA {
  text-align: center;
  margin-bottom: 50px;
}
.intro-text {
  font-family: "Arial";
  font-weight: bold;
  font-size: 1.5rem;
  line-height: 1.2em;
  margin-bottom: 15px;
}
.header-image, .header-image img {
  width: 100%;
}
@media (min-width: 640px) {
  .CTA {
    text-align: left;
    margin-bottom: 10px;
  }
}
</style>