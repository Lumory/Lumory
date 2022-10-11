<template>
  <n-space class="partners-section" justify="space-between">
      <img
          class="carousel-img"
          src="/assets/img/partner1.png"
      >
      <img
          class="carousel-img"
          src="/assets/img/partner2.png"
      >
      <img
          class="carousel-img"
          src="/assets/img/partner3.png"
      >
      <img
          class="carousel-img"
          src="/assets/img/partner4.png"
      >
      <img
          class="carousel-img"
          src="/assets/img/partner5.png"
      >
  </n-space>
</template>

<script>
import {NCarousel, NSpace,} from "naive-ui"

export default {
  components: {
    NCarousel,
    NSpace
  }
}
</script>

<style scoped>
.carousel-img {
  width: 100%;
}
</style>