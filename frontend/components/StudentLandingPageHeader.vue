<template>
  <n-grid class="student-hero-section" cols="1 s:2" x-gap="25px" responsive="screen">
    <n-grid-item class="n-grid-item">
      <div>
          <p class="intro-text">Vind gemakkelijk en snel de juiste stagiairen!</p>
          <n-button round secondary size="large" class="cta-button">Registreer nu!</n-button>
      </div>
    </n-grid-item>
    <n-grid-item>
        <n-image
            src="/assets/img/landing-page_hero-image.png"
            class="header-image"
            width="100%"
            preview-disabled
        />
    </n-grid-item>
  </n-grid>
</template>

<script>
import {NGrid, NGridItem, NLayout, NLayoutContent, NButton, NImage} from "naive-ui";

export default {
  components: {
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
.student-hero-section .n-grid-item {
  display: flex;
  align-items: center;
}
.student-hero-section .n-layout-content {
  align-items: center;
}
.student-hero-section {
  margin-top: 150px;
}
.intro-text {
  font-weight: bolder;
  font-size: 3rem;
  line-height: 1.2em;
  margin-bottom: 15px;
}
.cta-button {
  background-color: var(--color-primary);
  color: #333;
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