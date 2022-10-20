<template>
  <div class="container">
    <slot/>
  </div>
</template>

<style scoped>
.container {
  width: calc(100% - 20px);
  padding: 10px;
  display: flex;
  flex-direction: column;
  flex-grow: 1;
}
@media (min-width: 640px) {
  .container {
    width: 100%;
    max-width: 620px;
    margin: 0 auto;
    padding: 0 10px;
  }
}
@media (min-width: 1024px) {
  .container {
    width: 100%;
    max-width: 984px;
    margin: 0 auto;
    padding: 0 20px;
  }
}
@media (min-width: 1280px) {
  .container {
    width: 1200px;
    max-width: unset;
    margin: 0 auto;
    padding: 0 40px;
  }
}
</style>
