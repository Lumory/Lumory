<template>
  <container>
    <n-space vertical align="center">
      <n-image
          class="lumory-logo"
          src="/assets/img/Logo-horizontal.svg"
          height="50"
      />
      <stepper />
    </n-space>
  </container>
</template>

<script>
import { NImage } from "naive-ui"

export default {
  components: {
    NImage
  }
}
</script>

<style scoped>
.lumory-logo {
  margin: 50px auto !important;
  display: block;
}
</style>
