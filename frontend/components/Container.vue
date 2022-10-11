<template>
  <div class="container">
    <slot/>
  </div>
</template>

<style scoped>
.container {
  width: calc(100% - 20px);
  padding: 10px;
}
@media (min-width: 640px) {
  .container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0;
  }
}
</style>
